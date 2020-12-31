using Infrastructure.Services.ItemMasterService;
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
    public partial class MainForm :BaseController
    {
        ItemMasterService _itemMasterService = new ItemMasterService();
        public MainForm()
        {
            InitializeComponent();
        }


        #region private methods
        private void MainForm_Load(object sender, EventArgs e)
        {
            DatetimeLabel.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            CurrentUsername.Text = AppuserData.FullName;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DatetimeLabel.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
        }

        private void BarcodeTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (BarcodeTextbox.Text.Length == 13)
                {
                    var itemMaster = _itemMasterService.GetItemMasterByBarcode(BarcodeTextbox.Text);
                    if (itemMaster != null)
                    {
                        ItemListbox.Items.Add(itemMaster.LongDescription);
                    }
                    else
                    {
                        MessageBox.Show("No item found.");
                    }
                    BarcodeTextbox.Clear();
                }
            }
            catch(Exception ex)
            {

            }
          
        }

        #endregion


    }
}
