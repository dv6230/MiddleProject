using System;
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
            DBConnection d = new DBConnection();
            d.ProduceConnectStr();
            Application.Run(new Login());
        }
    }
}
