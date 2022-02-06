﻿using System;
using System.Windows.Forms;

namespace MiddleProject
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ManagePage());
            var d = new DBProduceStr();
            d.ProduceConnectStr();
            //d.ProduceConnectStr2(); 
            new Initialization();
            Application.Run(new ManagePage());
        }
    }
}
