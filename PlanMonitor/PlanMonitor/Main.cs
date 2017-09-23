using Monitor.lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor
{
    public partial class Main : Form
    {
        PlanMonitor plan = new PlanMonitor();
        CookieContainer cookieContainer = new CookieContainer();

        public Main()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var url = this.txt_loginurl.Text.Trim();
            var response = HttpHelper.CreateGetHttpResponse(url, null, null, null);
            this.txt_logmessage.Text = HttpHelper.GetResponseContent(response);
        }
    }
}
