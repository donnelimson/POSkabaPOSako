using Infrastructure.Services.AppuserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSkabaPOSako
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new LoginForm());
            FormRunner a = new FormRunner();
            a.RunForm();
        }
        class FormRunner
        {
            public void RunForm()
            {
                Application.Run(new LoginForm());
            }
        }
    }
}
