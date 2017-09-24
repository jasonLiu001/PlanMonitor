using Newtonsoft.Json.Linq;
using PlanMonitor;
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
        /// <summary>
        /// 网站首页
        /// </summary>
        private static string HomePage = "https://123.jn707.com";

        PlanMonitor plan = new PlanMonitor();

        public Main()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        #region 异步登录
        private void Login()
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
            SetCaptcheCodeResult(strpic_str);//验证码识别结果
            this.pic_captchacode.Image = image;
            #endregion

            #region 发送登录请求
            SetLogMessageResult(HttpHelper.GetResponse($"{HomePage}/login/safe.mvc?null", "POST", null));
            SetLogMessageResult(HttpHelper.GetResponse($"{HomePage}/login/login.mvc", "POST", $"username={this.txt_username.Text.Trim()}&validate={strpic_str}&password={this.txt_password.Text.Trim()}&_BrowserInfo=chrome/53.0.2785.104"));
            #endregion
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
