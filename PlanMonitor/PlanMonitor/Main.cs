using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor
{
    public partial class Main : Form
    {

        private string HomePage = string.Empty;
        /// <summary>
        /// 当前窗体的引用
        /// </summary>
        private static Main _instance;

        /// <summary>
        /// 计划软件监控类
        /// </summary>
        private PlanMonitor plan;

        /// <summary>
        /// 获取计划计时器
        /// </summary>
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Main()
        {
            _instance = this;
            InitializeComponent();
            //初始化控件
            InitControl();
        }

        public static Main GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// 初始化入口
        /// </summary>
        private void InitControl()
        {
            HomePage = this.txt_loginurl.Text.Trim();
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
            plan = PlanMonitor.GetInstance();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            plan.Start();
        }

        #region 异步登录
        /// <summary>
        /// 执行登录
        /// </summary>
        public void Login()
        {
            Thread threadGetLoginCode = new Thread(new ThreadStart(LoginThread));
            threadGetLoginCode.Name = "LoginThread";
            threadGetLoginCode.Start();
        }

        private void LoginThread()
        {
            #region 打开登录首页
            HttpHelper.GetResponse(HomePage, "GET", null);
            #endregion

            #region 验证码破解
            Stream stream = null;
            for (int i = 0; i < 10000; i++)
            {
                stream = HttpHelper.GetResponseImage($"{HomePage}/verifyCode?{new Random().Next(0, 1)}");
                if (stream != null)
                {
                    break;
                }
            }

            Image image = Image.FromStream(stream);
            var filePath = $"{Environment.CurrentDirectory}\\captcha.png";
            image.Save(filePath);
            string str = NetRecognizePic.CJY_RecognizeFile(filePath, "wangjackie", NetRecognizePic.MD5String(this.txt_password.Text.Trim()), CaptchaDecorder.SoftId, CaptchaDecorder.CodeType, "0", "0", "");
            string strerr = NetRecognizePic.GetTextByKey(str, "err_str");
            if (strerr != "OK")
            {
                SetLogMessageResult("[" + DateTime.Now.ToString("HH:mm:ss") + "]" + strerr);
                return;
            }

            string strpic_id = NetRecognizePic.GetTextByKey(str, "pic_id");
            string strpic_str = NetRecognizePic.GetTextByKey(str, "pic_str");


            SetLogMessageResult("[" + DateTime.Now.ToString("HH:mm:ss") + "] 验证码:" + strpic_str);
            SetLogMessageResult(strpic_str);//验证码识别结果
            this.pic_captchacode.Image = image;
            #endregion

            #region 发送登录请求
            SetLogMessageResult(HttpHelper.GetResponse($"{HomePage}/login/safe.mvc?null", "POST", null));
            SetLogMessageResult(HttpHelper.GetResponse($"{HomePage}/login/login.mvc", "POST", $"username={this.txt_username.Text.Trim()}&validate={strpic_str}&password={this.txt_password.Text.Trim()}&_BrowserInfo=chrome/53.0.2785.104"));
            #endregion

            #region 获取投注Token值
            //请求登录成功后首页
            HttpHelper.GetResponse($"{HomePage}/Index", "GET", null);
            HttpHelper.GetResponse($"{HomePage}/userInfo/getUserInfo.mvc", "POST", $"menuName=");
            //打开时时彩
            var tokenString = HttpHelper.GetResponse($"{HomePage}/gameType/initGame.mvc", "POST", $"gameID=1");
            var tokenObj = JObject.Parse(tokenString);
            var token = string.Empty;
            if (tokenObj != null && tokenObj["data"] != null && tokenObj["data"]["token_tz"] != null)
            {
                token = tokenObj["data"]["token_tz"].ToString();
            }
            SetLogMessageResult($"token_tz={token}");
            #endregion

            //获取当前账号余额
            SetLogMessageResult(HttpHelper.GetResponse($"{HomePage}/userInfo/getBalance.mvc", "GET", null));

            //执行后一投注
            SetLogMessageResult(HttpHelper.GetResponse($"{HomePage}/cathectic/cathectic.mvc", "POST", $"json={{'token':'{token}','issueNo':'20170924-056','gameId':'1','tingZhiZhuiHao':'true','zhuiHaoQiHao':[],'touZhuHaoMa':[{{'wanFaID':'41','touZhuHaoMa':'||||4,5','digit':'4','touZhuBeiShu':'1','danZhuJinEDanWei':'1','yongHuSuoTiaoFanDian':'0','zhuShu':'2','bouse':'7.7'}}]}}"));
        }
        #endregion

        #region 按钮事件
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txt_password.Text))
            {
                MessageBox.Show("密码不能为空");
                return;
            }
            this.timer.Start();
        }

        private void txt_logmessage_DoubleClick(object sender, EventArgs e)
        {
            this.txt_logmessage.Text = string.Empty;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            this.timer.Stop();
        }
        #endregion

        #region 委托实现跨线程更新文本内容
        public void SetCaptcheCodeResult(string text)
        {
            this.txt_captchacode.Invoke(new WriteTextBoxDelegate(WriteCaptcheCodeMessage), text);
        }
        public void SetLogMessageResult(string text)
        {
            this.txt_logmessage.Invoke(new WriteTextBoxDelegate(WriteLogMessage), text);
        }
        private delegate void WriteTextBoxDelegate(string message);
        private void WriteLogMessage(string text)
        {
            this.txt_logmessage.AppendText($"\r\n{text.Trim()}");
            Logger.WriteLog(text.Trim());
        }
        private void WriteCaptcheCodeMessage(string text)
        {
            this.txt_captchacode.Text = text.Trim();
        }
        #endregion
    }
}
