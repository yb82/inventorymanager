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

namespace IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.ItemForms
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item newItem = new Item();
            newItem.Barcode = tbBarcode.Text;
            newItem.ItemDescription = tbDescription.Text;
            newItem.ItemCategory.CategoryName = cbAddItemCategory.SelectedItem.ToString();
            newItem.AddItem();
            this.Close();

        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            List<Category> list = Category.FindAllCategory();
            foreach (Category a in list)
            {
                cbAddItemCategory.Items.Add(a.CategoryName);
            }
            this.CenterToParent();
        }
    }
}
