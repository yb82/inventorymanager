namespace IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.CategoryForms
{
    partial class AddCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbExpiryDay = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(167, 37);
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(158, 20);
            this.tbCategoryName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lending Period (Days)";
            // 
            // tbExpiryDay
            // 
            this.tbExpiryDay.Location = new System.Drawing.Point(167, 75);
            this.tbExpiryDay.Name = "tbExpiryDay";
            this.tbExpiryDay.Size = new System.Drawing.Size(55, 20);
            this.tbExpiryDay.TabIndex = 3;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.btAdd.Location = new System.Drawing.Point(236, 97);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(87, 29);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 138);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbExpiryDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCategoryName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCategoryForm";
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.AddCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbExpiryDay;
        private System.Windows.Forms.Button btAdd;
    }
}