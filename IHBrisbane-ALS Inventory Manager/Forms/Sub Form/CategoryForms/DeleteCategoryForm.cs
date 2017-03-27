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
    public partial class DeleteCategoryForm : Form
    {
        public DeleteCategoryForm()
        {
            InitializeComponent();
        }

        private void DeleteCategoryForm_Load(object sender, EventArgs e)
        {
            this.RefreshCategoryCombobox();
            this.CenterToParent();
        }

        private void RefreshCategoryCombobox()
        {
            if (cbDelCategory.Items.Count != 0)
            {
                cbDelCategory.Items.Clear();
            }
            Category cate = new Category();
            List<Category> list = Category.FindAllCategory();
            foreach (Category a in list)
            {
                cbDelCategory.Items.Add(a.CategoryName);
            }
        }
        private void btDelCategory_Click(object sender, EventArgs e)
        {
            //int seletedItem = cbDelCategory.SelectedIndex;
            string selectedItemName = cbDelCategory.SelectedItem.ToString();

            if (selectedItemName != "" && selectedItemName != null) { 
                Category.DelCategory(selectedItemName);
                this.RefreshCategoryCombobox();
                cbDelCategory.Text="";
            }
        }
    }
}
