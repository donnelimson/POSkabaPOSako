using Infrastructure.Services.AppuserService;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSkabaPOSako
{
    public class BaseController:Form
    {
        public static AppuserDTO AppuserData;
        public void DisableEnterOnMultilineTextbox(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                SendKeys.Send("{ENTER}");
                e.SuppressKeyPress = true;
            }
        }
        public void InitiateProgress(ProgressBar progressBar)
        {
            progressBar.Maximum = 100;
            progressBar.Step = 1;
            progressBar.Value = 0;
        }
        public void ShowNewForm(Form oldForm, Form newForm)
        {
            oldForm.Hide();
            newForm.ShowDialog();
            oldForm.Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseController
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseController";
            this.ResumeLayout(false);

        }


        //public void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    var backgroundWorker = sender as BackgroundWorker;
        //    for (int j = 0; j < 100000; j++)
        //    {

        //        backgroundWorker.ReportProgress((j * 100) / 100000);
        //    }

        //}
    }
}
