namespace IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.Excel
{
    partial class ExcelData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelData));
            this.btImport = new System.Windows.Forms.Button();
            this.btExportData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btImport
            // 
            this.btImport.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImport.Location = new System.Drawing.Point(8, 12);
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(314, 59);
            this.btImport.TabIndex = 0;
            this.btImport.Text = "Import Data";
            this.btImport.UseVisualStyleBackColor = true;
            this.btImport.Click += new System.EventHandler(this.btImport_Click);
            // 
            // btExportData
            // 
            this.btExportData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportData.Location = new System.Drawing.Point(6, 75);
            this.btExportData.Name = "btExportData";
            this.btExportData.Size = new System.Drawing.Size(314, 59);
            this.btExportData.TabIndex = 1;
            this.btExportData.Text = "Export Data";
            this.btExportData.UseVisualStyleBackColor = true;
            this.btExportData.Click += new System.EventHandler(this.btExportData_Click);
            // 
            // ExcelData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 151);
            this.Controls.Add(this.btExportData);
            this.Controls.Add(this.btImport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcelData";
            this.Text = "ExcelData";
            this.Load += new System.EventHandler(this.ExcelData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btImport;
        private System.Windows.Forms.Button btExportData;
    }
}