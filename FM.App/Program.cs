using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetDefaultLanguage();
           Application.Run(new frmMain());//new Form1());
           // Application.Run(new Form1());
        }

        public static void SetDefaultLanguage()
        {
            string strDefaultLanguage = "ar-LB";
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo(strDefaultLanguage));
        }
    }
}
