using Infrastructure.Services.AppuserService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSkabaPOSako
{
    public partial class LoginForm : BaseController
    {
        AppuserService _appuserService = new AppuserService();
        public LoginForm()
        {
            InitializeComponent();
        }

        #region Actions method
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login();
        }
        #endregion

        #region private methods
        private void Login()
        {
            ProgressBarColor.SetState(progressBar1, 1); // 1 green
            try
            {
                AppuserData = _appuserService.Login(UserTextbox.Text, PasswordTextbox.Text);
                InitiateProgress(progressBar1);
                backgroundWorker1.RunWorkerAsync();
                if (AppuserData != null)
                {
                    _appuserService.InsertLoginHistory(AppuserData.Id);
                    MessageBox.Show("Login successfully");
                    ShowNewForm(this, new MainForm());
                }
                else
                {
                    MessageBox.Show("Login failed");
                    ClearText();
                }
                progressBar1.Value = 0;
            }
            catch (Exception ex)
            {
                ProgressBarColor.SetState(progressBar1, 2); //2 red
                InitiateProgress(progressBar1);
                MessageBox.Show("An error occured");
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void ClearText()
        {
            UserTextbox.Clear();
            PasswordTextbox.Clear();
        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            for (int j = 0; j < 100000; j++)
            {
                backgroundWorker.ReportProgress((j * 100) / 100000);
            }

        }
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage+1;
        }
  
        private void LoginForm_Load(object sender, EventArgs e)
        {
            DatetimeLabel.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DatetimeLabel.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
        }

        #endregion

        private void LoginKeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
