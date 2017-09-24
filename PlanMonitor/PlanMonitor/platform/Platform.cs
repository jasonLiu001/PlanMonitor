using Monitor;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Monitor
{
    public class Platform
    {
        /// <summary>
        /// 网站首页
        /// </summary>


        private static Platform _instance;

        /// <summary>
        /// 主窗体的引用
        /// </summary>
        private static Main main;

        private Platform()
        {

        }

        public static Platform GetInstance(Main win)
        {
            if (_instance == null)
            {
                _instance = new Platform();
            }
            main = win;
            return _instance;
        }


    }
}
