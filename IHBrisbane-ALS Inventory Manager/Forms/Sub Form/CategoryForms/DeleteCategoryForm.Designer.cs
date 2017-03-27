namespace IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.CategoryForms
{
    partial class DeleteCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCategoryForm));
            this.cbDelCategory = new System.Windows.Forms.ComboBox();
            this.btDelCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDelCategory
            // 
            this.cbDelCategory.FormattingEnabled = true;
            this.cbDelCategory.Location = new System.Drawing.Point(12, 27);
            this.cbDelCategory.Name = "cbDelCategory";
            this.cbDelCategory.Size = new System.Drawing.Size(194, 21);
            this.cbDelCategory.TabIndex = 0;
            // 
            // btDelCategory
            // 
            this.btDelCategory.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.btDelCategory.Location = new System.Drawing.Point(231, 27);
            this.btDelCategory.Name = "btDelCategory";
            this.btDelCategory.Size = new System.Drawing.Size(75, 30);
            this.btDelCategory.TabIndex = 1;
            this.btDelCategory.Text = "Delete";
            this.btDelCategory.UseVisualStyleBackColor = true;
            this.btDelCategory.Click += new System.EventHandler(this.btDelCategory_Click);
            // 
            // DeleteCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 90);
            this.Controls.Add(this.btDelCategory);
            this.Controls.Add(this.cbDelCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteCategoryForm";
            this.Text = "DeleteCategory";
            this.Load += new System.EventHandler(this.DeleteCategoryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDelCategory;
        private System.Windows.Forms.Button btDelCategory;
    }
}