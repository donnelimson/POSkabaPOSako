using Infrastructure.Services.ItemMasterService;
using Model.DTO;
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
        string headers = "{0,-10}{1,50}";

        public MainForm()
        {
            InitializeComponent();
        }

        BindingList<ItemMasterListboxMainPOS> items = new BindingList<ItemMasterListboxMainPOS>();
        int orderCount = 0;
        #region private methods
        private void MainForm_Load(object sender, EventArgs e)
        {
            DatetimeLabel.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            CurrentUsername.Text = AppuserData.FullName;
            ItemListbox.DataSource = items;
            ItemListbox.DisplayMember = "LongDescription";
            QuantityListbox.DataSource = items;
            QuantityListbox.DisplayMember = "Quantity";
            // ItemListbox.Items.Add(String.Format(headers, "Description", "Quantity"));
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
                        orderCount++;
                        var item = items.FirstOrDefault(x => x.Id == itemMaster.Id);
                        if (item==null)
                        {
                            items.Add(new ItemMasterListboxMainPOS
                            {
                                Id = itemMaster.Id,
                                LongDescription = itemMaster.LongDescription,
                                Quantity = 1,
                                Index = orderCount
                            });
                        }
                        else
                        {
                            item.Quantity++;
                            item.Index = orderCount;
                        }
                        items.OrderByDescending(x => x.Index);
                        items.Add(new ItemMasterListboxMainPOS
                        {
                            Id = 0,
                            LongDescription = "",
                            Quantity = 1,
                            Index = 0
                        });
                        items.RemoveAt(items.Count - 1);
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
                MessageBox.Show(ex.ToString());
            }
          
        }




        #endregion
    }
}
