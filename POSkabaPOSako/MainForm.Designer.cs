
namespace POSkabaPOSako
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentUsername = new System.Windows.Forms.Label();
            this.DatetimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BarcodeTextbox = new System.Windows.Forms.TextBox();
            this.appuserDTOBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemMasterListboxMainPOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appuserDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemListbox = new System.Windows.Forms.ListBox();
            this.QuantityListbox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appuserDTOBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterListboxMainPOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appuserDTOBindingSource)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.CurrentUsername);
            this.panel1.Controls.Add(this.DatetimeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 27);
            this.panel1.TabIndex = 1;
            // 
            // CurrentUsername
            // 
            this.CurrentUsername.AutoSize = true;
            this.CurrentUsername.Dock = System.Windows.Forms.DockStyle.Left;
            this.CurrentUsername.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUsername.ForeColor = System.Drawing.Color.White;
            this.CurrentUsername.Location = new System.Drawing.Point(0, 0);
            this.CurrentUsername.Name = "CurrentUsername";
            this.CurrentUsername.Size = new System.Drawing.Size(47, 16);
            this.CurrentUsername.TabIndex = 2;
            this.CurrentUsername.Text = "label1";
            // 
            // DatetimeLabel
            // 
            this.DatetimeLabel.AutoSize = true;
            this.DatetimeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DatetimeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatetimeLabel.ForeColor = System.Drawing.Color.White;
            this.DatetimeLabel.Location = new System.Drawing.Point(753, 0);
            this.DatetimeLabel.Name = "DatetimeLabel";
            this.DatetimeLabel.Size = new System.Drawing.Size(47, 16);
            this.DatetimeLabel.TabIndex = 1;
            this.DatetimeLabel.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.875F));
            this.tableLayoutPanel1.Controls.Add(this.BarcodeTextbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 400);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // BarcodeTextbox
            // 
            this.BarcodeTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarcodeTextbox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTextbox.Location = new System.Drawing.Point(3, 249);
            this.BarcodeTextbox.Name = "BarcodeTextbox";
            this.BarcodeTextbox.Size = new System.Drawing.Size(379, 29);
            this.BarcodeTextbox.TabIndex = 1;
            this.BarcodeTextbox.TextChanged += new System.EventHandler(this.BarcodeTextbox_TextChanged);
            // 
            // itemMasterListboxMainPOSBindingSource
            // 
            this.itemMasterListboxMainPOSBindingSource.DataSource = typeof(Model.DTO.ItemMasterListboxMainPOS);
            // 
            // appuserDTOBindingSource
            // 
            this.appuserDTOBindingSource.DataSource = typeof(Model.DTO.AppuserDTO);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel3.Controls.Add(this.QuantityListbox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ItemListbox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(379, 240);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // ItemListbox
            // 
            this.ItemListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListbox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListbox.FormattingEnabled = true;
            this.ItemListbox.ItemHeight = 22;
            this.ItemListbox.Location = new System.Drawing.Point(3, 3);
            this.ItemListbox.Name = "ItemListbox";
            this.ItemListbox.Size = new System.Drawing.Size(326, 234);
            this.ItemListbox.TabIndex = 2;
            // 
            // QuantityListbox
            // 
            this.QuantityListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuantityListbox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityListbox.FormattingEnabled = true;
            this.QuantityListbox.ItemHeight = 22;
            this.QuantityListbox.Location = new System.Drawing.Point(335, 3);
            this.QuantityListbox.Name = "QuantityListbox";
            this.QuantityListbox.Size = new System.Drawing.Size(41, 234);
            this.QuantityListbox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appuserDTOBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemMasterListboxMainPOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appuserDTOBindingSource)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DatetimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label CurrentUsername;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox BarcodeTextbox;
        private System.Windows.Forms.BindingSource appuserDTOBindingSource;
        private System.Windows.Forms.BindingSource appuserDTOBindingSource1;
        private System.Windows.Forms.BindingSource itemMasterListboxMainPOSBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox QuantityListbox;
        private System.Windows.Forms.ListBox ItemListbox;
    }
}