﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Monitor
{
    public class Logger
    {
        /// <summary>
        /// 输出日志
        /// </summary>
        public static void WriteLog(string msg)
        {
            var logFile = Environment.CurrentDirectory + "\\error.log";
            if (!File.Exists(logFile))
            {
                FileStream fs1 = new FileStream(logFile, FileMode.Create, FileAccess.Write);//创建写入文件 
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(msg);
                sw.Close();
                fs1.Close();
            }
            else
            {
                FileStream fs = new FileStream(logFile, FileMode.Append);
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(msg);
                sr.Close();
                fs.Close();
            }
        }
    }
}
