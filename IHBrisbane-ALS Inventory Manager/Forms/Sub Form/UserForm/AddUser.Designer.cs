namespace IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.UserForm
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddUserID = new System.Windows.Forms.TextBox();
            this.tbAddUserPW = new System.Windows.Forms.TextBox();
            this.tbAddUserInitial = new System.Windows.Forms.TextBox();
            this.cbAddUserAccType = new System.Windows.Forms.ComboBox();
            this.btAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Initial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account Type";
            // 
            // tbAddUserID
            // 
            this.tbAddUserID.Location = new System.Drawing.Point(123, 30);
            this.tbAddUserID.Name = "tbAddUserID";
            this.tbAddUserID.Size = new System.Drawing.Size(176, 20);
            this.tbAddUserID.TabIndex = 4;
            // 
            // tbAddUserPW
            // 
            this.tbAddUserPW.Location = new System.Drawing.Point(123, 74);
            this.tbAddUserPW.Name = "tbAddUserPW";
            this.tbAddUserPW.PasswordChar = '*';
            this.tbAddUserPW.Size = new System.Drawing.Size(176, 20);
            this.tbAddUserPW.TabIndex = 5;
            // 
            // tbAddUserInitial
            // 
            this.tbAddUserInitial.Location = new System.Drawing.Point(123, 122);
            this.tbAddUserInitial.Name = "tbAddUserInitial";
            this.tbAddUserInitial.Size = new System.Drawing.Size(66, 20);
            this.tbAddUserInitial.TabIndex = 6;
            // 
            // cbAddUserAccType
            // 
            this.cbAddUserAccType.FormattingEnabled = true;
            this.cbAddUserAccType.Location = new System.Drawing.Point(123, 168);
            this.cbAddUserAccType.Name = "cbAddUserAccType";
            this.cbAddUserAccType.Size = new System.Drawing.Size(121, 21);
            this.cbAddUserAccType.TabIndex = 7;
            // 
            // btAddUser
            // 
            this.btAddUser.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddUser.Location = new System.Drawing.Point(205, 210);
            this.btAddUser.Name = "btAddUser";
            this.btAddUser.Size = new System.Drawing.Size(122, 62);
            this.btAddUser.TabIndex = 8;
            this.btAddUser.Text = "Add User";
            this.btAddUser.UseVisualStyleBackColor = true;
            this.btAddUser.Click += new System.EventHandler(this.btAddUser_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 275);
            this.Controls.Add(this.btAddUser);
            this.Controls.Add(this.cbAddUserAccType);
            this.Controls.Add(this.tbAddUserInitial);
            this.Controls.Add(this.tbAddUserPW);
            this.Controls.Add(this.tbAddUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddUserID;
        private System.Windows.Forms.TextBox tbAddUserPW;
        private System.Windows.Forms.TextBox tbAddUserInitial;
        private System.Windows.Forms.ComboBox cbAddUserAccType;
        private System.Windows.Forms.Button btAddUser;
    }
}