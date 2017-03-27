using IHBrisbane_ALS_Inventory_Manager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.CategoryForms
{
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Category cate = new Category();
            cate.CategoryName = tbCategoryName.Text;
            int duration = 0;
            string expireDate =tbExpiryDay.Text;
            if (Int32.TryParse(expireDate, out duration))
            {
                cate.Duration = duration;
                cate.AddCategory();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter Number only");
                tbExpiryDay.Focus();
            }

           
         


        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
