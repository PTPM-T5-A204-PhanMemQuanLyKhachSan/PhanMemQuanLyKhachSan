using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        public static GUI_Main GUI_Main = null;
        public static GUI_CauHinh GUI_CauHinh = null;
        public static GUI_DangNhap GUI_DangNhap = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GUI_DangNhap = new GUI_DangNhap();
            Application.Run(GUI_DangNhap);
        }
    }
}