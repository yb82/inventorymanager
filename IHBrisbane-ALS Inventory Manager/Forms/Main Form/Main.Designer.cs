namespace IHBrisbane_ALS_Inventory_Manager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tb_barcode = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.tb_Display = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItemCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteITEMCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewITEMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportItemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btUpdateItem = new System.Windows.Forms.Button();
            this.btn_In = new System.Windows.Forms.Button();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.exportUnreturnedItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_barcode
            // 
            this.tb_barcode.Location = new System.Drawing.Point(18, 286);
            this.tb_barcode.Name = "tb_barcode";
            this.tb_barcode.Size = new System.Drawing.Size(264, 20);
            this.tb_barcode.TabIndex = 0;
            this.tb_barcode.TextChanged += new System.EventHandler(this.tb_barcode_TextChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_reset.Location = new System.Drawing.Point(317, 279);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(104, 31);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // tb_Display
            // 
            this.tb_Display.Enabled = false;
            this.tb_Display.Location = new System.Drawing.Point(18, 49);
            this.tb_Display.Multiline = true;
            this.tb_Display.Name = "tb_Display";
            this.tb_Display.Size = new System.Drawing.Size(403, 183);
            this.tb_Display.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.iTEMToolStripMenuItem,
            this.exportDataToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddItemCategory,
            this.deleteITEMCategoryToolStripMenuItem});
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.categoryToolStripMenuItem.Text = "Category";
            // 
            // AddItemCategory
            // 
            this.AddItemCategory.Name = "AddItemCategory";
            this.AddItemCategory.Size = new System.Drawing.Size(188, 22);
            this.AddItemCategory.Text = "Add ITEM Category";
            this.AddItemCategory.Click += new System.EventHandler(this.AddItemCategory_Click);
            // 
            // deleteITEMCategoryToolStripMenuItem
            // 
            this.deleteITEMCategoryToolStripMenuItem.Name = "deleteITEMCategoryToolStripMenuItem";
            this.deleteITEMCategoryToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.deleteITEMCategoryToolStripMenuItem.Text = "Delete ITEM Category";
            this.deleteITEMCategoryToolStripMenuItem.Click += new System.EventHandler(this.deleteITEMCategoryToolStripMenuItem_Click);
            // 
            // iTEMToolStripMenuItem
            // 
            this.iTEMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewITEMToolStripMenuItem,
            this.exportItemListToolStripMenuItem,
            this.exportUnreturnedItemToolStripMenuItem});
            this.iTEMToolStripMenuItem.Name = "iTEMToolStripMenuItem";
            this.iTEMToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.iTEMToolStripMenuItem.Text = "ITEM";
            // 
            // addNewITEMToolStripMenuItem
            // 
            this.addNewITEMToolStripMenuItem.Name = "addNewITEMToolStripMenuItem";
            this.addNewITEMToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.addNewITEMToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addNewITEMToolStripMenuItem.Text = "Add New ITEM";
            this.addNewITEMToolStripMenuItem.Click += new System.EventHandler(this.addNewITEMToolStripMenuItem_Click);
            // 
            // exportItemListToolStripMenuItem
            // 
            this.exportItemListToolStripMenuItem.Name = "exportItemListToolStripMenuItem";
            this.exportItemListToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.exportItemListToolStripMenuItem.Text = "Export Item List";
            this.exportItemListToolStripMenuItem.Click += new System.EventHandler(this.exportItemListToolStripMenuItem_Click);
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.exportDataToolStripMenuItem.Text = "Data Import/ Export";
            this.exportDataToolStripMenuItem.Click += new System.EventHandler(this.exportDataToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem});
            this.userToolStripMenuItem.Enabled = false;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // btUpdateItem
            // 
            this.btUpdateItem.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.btUpdateItem.Location = new System.Drawing.Point(248, 238);
            this.btUpdateItem.Name = "btUpdateItem";
            this.btUpdateItem.Size = new System.Drawing.Size(173, 41);
            this.btUpdateItem.TabIndex = 10;
            this.btUpdateItem.Text = "Update Item (Scan First)";
            this.btUpdateItem.UseVisualStyleBackColor = true;
            this.btUpdateItem.Click += new System.EventHandler(this.btUpdateItem_Click);
            // 
            // btn_In
            // 
            this.btn_In.Image = global::IHBrisbane_ALS_Inventory_Manager.Properties.Resources._1443005947_ark2;
            this.btn_In.Location = new System.Drawing.Point(225, 333);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(196, 145);
            this.btn_In.TabIndex = 4;
            this.btn_In.UseVisualStyleBackColor = true;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Image = global::IHBrisbane_ALS_Inventory_Manager.Properties.Resources._1443005165_box_out;
            this.btn_CheckOut.Location = new System.Drawing.Point(18, 333);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(201, 145);
            this.btn_CheckOut.TabIndex = 3;
            this.btn_CheckOut.UseVisualStyleBackColor = true;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // exportUnreturnedItemToolStripMenuItem
            // 
            this.exportUnreturnedItemToolStripMenuItem.Name = "exportUnreturnedItemToolStripMenuItem";
            this.exportUnreturnedItemToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.exportUnreturnedItemToolStripMenuItem.Text = "Export Unreturned Item";
            this.exportUnreturnedItemToolStripMenuItem.Click += new System.EventHandler(this.exportUnreturnedItemToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 501);
            this.Controls.Add(this.btUpdateItem);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.tb_Display);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.tb_barcode);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "IH Brisbane-ALS Library (internal use only)";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_barcode;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox tb_Display;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Button btn_In;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddItemCategory;
        private System.Windows.Forms.ToolStripMenuItem deleteITEMCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTEMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewITEMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.Button btUpdateItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportItemListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportUnreturnedItemToolStripMenuItem;
    }
}

