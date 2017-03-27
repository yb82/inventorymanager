namespace IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.CheckForms
{
    partial class CheckoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbStudentNo = new System.Windows.Forms.TextBox();
            this.btCheckOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(2, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student No.";
            // 
            // tbStudentNo
            // 
            this.tbStudentNo.Location = new System.Drawing.Point(87, 36);
            this.tbStudentNo.Name = "tbStudentNo";
            this.tbStudentNo.Size = new System.Drawing.Size(108, 20);
            this.tbStudentNo.TabIndex = 1;
            // 
            // btCheckOut
            // 
            this.btCheckOut.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.btCheckOut.Location = new System.Drawing.Point(216, 27);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(89, 35);
            this.btCheckOut.TabIndex = 2;
            this.btCheckOut.Text = "CheckOut";
            this.btCheckOut.UseVisualStyleBackColor = true;
            this.btCheckOut.Click += new System.EventHandler(this.btCheckOut_Click);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(317, 88);
            this.Controls.Add(this.btCheckOut);
            this.Controls.Add(this.tbStudentNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckoutForm";
            this.Text = "CheckoutForm";
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStudentNo;
        private System.Windows.Forms.Button btCheckOut;
    }
}