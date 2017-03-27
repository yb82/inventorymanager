namespace IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.ItemForms
{
    partial class UpdateItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItemForm));
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_updateBarcode = new System.Windows.Forms.TextBox();
            this.tb_updateitemdescription = new System.Windows.Forms.TextBox();
            this.cb_updateitemcategory = new System.Windows.Forms.ComboBox();
            this.bt_updateitem = new System.Windows.Forms.Button();
            this.bt_deleteitem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl1.Location = new System.Drawing.Point(32, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(60, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(32, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // tb_updateBarcode
            // 
            this.tb_updateBarcode.Enabled = false;
            this.tb_updateBarcode.Location = new System.Drawing.Point(147, 29);
            this.tb_updateBarcode.Name = "tb_updateBarcode";
            this.tb_updateBarcode.Size = new System.Drawing.Size(130, 20);
            this.tb_updateBarcode.TabIndex = 3;
            // 
            // tb_updateitemdescription
            // 
            this.tb_updateitemdescription.Location = new System.Drawing.Point(147, 82);
            this.tb_updateitemdescription.Multiline = true;
            this.tb_updateitemdescription.Name = "tb_updateitemdescription";
            this.tb_updateitemdescription.Size = new System.Drawing.Size(130, 54);
            this.tb_updateitemdescription.TabIndex = 4;
            // 
            // cb_updateitemcategory
            // 
            this.cb_updateitemcategory.FormattingEnabled = true;
            this.cb_updateitemcategory.Location = new System.Drawing.Point(147, 158);
            this.cb_updateitemcategory.Name = "cb_updateitemcategory";
            this.cb_updateitemcategory.Size = new System.Drawing.Size(130, 21);
            this.cb_updateitemcategory.TabIndex = 5;
            // 
            // bt_updateitem
            // 
            this.bt_updateitem.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_updateitem.Location = new System.Drawing.Point(299, 25);
            this.bt_updateitem.Name = "bt_updateitem";
            this.bt_updateitem.Size = new System.Drawing.Size(89, 54);
            this.bt_updateitem.TabIndex = 6;
            this.bt_updateitem.Text = "Update Item";
            this.bt_updateitem.UseVisualStyleBackColor = true;
            this.bt_updateitem.Click += new System.EventHandler(this.bt_updateitem_Click);
            // 
            // bt_deleteitem
            // 
            this.bt_deleteitem.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.bt_deleteitem.Location = new System.Drawing.Point(299, 122);
            this.bt_deleteitem.Name = "bt_deleteitem";
            this.bt_deleteitem.Size = new System.Drawing.Size(89, 54);
            this.bt_deleteitem.TabIndex = 7;
            this.bt_deleteitem.Text = "Delete Item";
            this.bt_deleteitem.UseVisualStyleBackColor = true;
            this.bt_deleteitem.Click += new System.EventHandler(this.bt_deleteitem_Click);
            // 
            // UpdateItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 207);
            this.Controls.Add(this.bt_deleteitem);
            this.Controls.Add(this.bt_updateitem);
            this.Controls.Add(this.cb_updateitemcategory);
            this.Controls.Add(this.tb_updateitemdescription);
            this.Controls.Add(this.tb_updateBarcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateItemForm";
            this.Text = "UpdateItemForm";
            this.Load += new System.EventHandler(this.UpdateItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_updateBarcode;
        private System.Windows.Forms.TextBox tb_updateitemdescription;
        private System.Windows.Forms.ComboBox cb_updateitemcategory;
        private System.Windows.Forms.Button bt_updateitem;
        private System.Windows.Forms.Button bt_deleteitem;
    }
}