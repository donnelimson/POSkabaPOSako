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
    public partial class Form1 : BaseController
    {
        public Form1()
        {
            InitializeComponent();
            ConnectDatabase();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         //  MessageBox.Show("Database Connected");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
