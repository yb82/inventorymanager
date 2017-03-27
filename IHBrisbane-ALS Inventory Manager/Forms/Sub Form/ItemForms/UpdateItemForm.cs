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
    public partial class UpdateItemForm : Form
    {
        private Item currentItem;
        public UpdateItemForm()
        {
            InitializeComponent();
            
        }
        public void initCom(string barcode)
        {
            this.currentItem = Item.FindItem(barcode);
            tb_updateBarcode.Text = this.currentItem.Barcode;
            tb_updateitemdescription.Text = this.currentItem.ItemDescription;
            List<Category> cate = Category.FindAllCategory();

            int counter = 0 , selectedItem = 0;
            
            foreach (Category c in cate){
                if (c.CategoryName == this.currentItem.ItemCategory.CategoryName) selectedItem = counter;
                cb_updateitemcategory.Items.Add(c.CategoryName);
                counter++;
                
            }
            cb_updateitemcategory.SelectedIndex = selectedItem;

        }

        private void bt_updateitem_Click(object sender, EventArgs e)
        {
            Item currentItem = Item.FindItem(tb_updateBarcode.Text);
            if (currentItem.Status)
            {
                string selectedItemName = cb_updateitemcategory.SelectedItem.ToString();

                if (selectedItemName != "" && selectedItemName != null)
                {
                    Item.UpdateItem(currentItem.Barcode, currentItem.Barcode, tb_updateitemdescription.Text, true, selectedItemName);
                    MessageBox.Show("Item has been updated!");
                    this.Close();
                }
                else MessageBox.Show("Please select Item Category!");
            }
            else MessageBox.Show("Please Release the Item First!!");
            
        }

        private void bt_deleteitem_Click(object sender, EventArgs e)
        {
            Item currentItem = Item.FindItem(tb_updateBarcode.Text);
            if (currentItem.Status)
            {
                Item.DelItem(currentItem.Barcode);
                MessageBox.Show("Item has been deleted!!");
                this.Close();
                
            }
            else MessageBox.Show("Please Release the Item First!!");
            

        }

        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
    }
}
