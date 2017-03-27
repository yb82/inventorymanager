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
    public partial class AddUser : Form
    {

        public AddUser()
        {
            InitializeComponent();
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            User addUser = new User();
            bool initialFlag = true;
            
            if (tbAddUserInitial.Text.Length >= 4)
            {
                MessageBox.Show("Too long(3 letters only)!!");
                initialFlag = false;
                tbAddUserInitial.Focus();
            }
            addUser.userid=tbAddUserID.Text;
            addUser.password=tbAddUserPW.Text;
            string selectedItemName = cbAddUserAccType.SelectedItem.ToString();

            if (selectedItemName != "" && selectedItemName != null)
            {
                addUser.role = "User";
            }
            if (initialFlag) { 
                User.AddUser(addUser);
                MessageBox.Show("User has been added!!!");
                this.Close();
            }
            

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            if (cbAddUserAccType.Items.Count == 0)
            {
                cbAddUserAccType.Items.Add("User");
                cbAddUserAccType.Items.Add("Admin");
                
            }
            this.CenterToParent();
        }

   

       
    }
}
