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
        CategoryService _categoryService = new CategoryService();

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
            PopulateCategoryButtons();
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
        private void PopulateCategoryButtons()
        {
            var categories = _categoryService.GetAllCategoriesButton();
            var counter = 0;
            foreach(var category in categories)
            {
                counter++;
                Button categoryButton = new Button();
                categoryButton.Name = category.Id.ToString();
                categoryButton.Text = category.LongDescription;
                categoryButton.Location = System.Drawing.Point.Add(new Point(4 + counter * 307, 4), new Size(20, 20));
                categoryButton.Click += CategoryClick;
                flowLayoutPanel1.Controls.Add(categoryButton);
            }
        }

        #region handlers
        private void CategoryClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var items = _itemMasterService.GetAllItemMasterButtons(int.Parse(button.Name));
            flowLayoutPanel1.Controls.Clear();
            var counter = 0;
            foreach(var item in items)
            {
                counter++;
                Button itemButton = new Button();
                itemButton.Name = item.Id.ToString();
                itemButton.Text = item.LongDescription;
                itemButton.Location = System.Drawing.Point.Add(new Point(4 + counter * 307, 4), new Size(20, 20));
               // itemButton.Click += CategoryClick;
                flowLayoutPanel1.Controls.Add(itemButton);
            }
        }
        #endregion



        #endregion
    }
}
