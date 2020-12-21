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
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = _appuserService.Login("admin", "asdf1234");
            if (login != null)
            {
                MessageBox.Show("Login successfully");
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }
    }
}
