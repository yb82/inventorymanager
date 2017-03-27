using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IHBrisbane_ALS_Inventory_Manager.Model;

namespace IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.UserForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            string id = tb_ID.Text;
            string pw = tb_Password.Text;

            if (User.Login(id, pw))
            {
                Main.loggedInUser = User.FindUser(id);

                this.Close();
            }
            else
            {
                MessageBox.Show("Please check your password!!!");
                this.tb_Password.Focus();
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
