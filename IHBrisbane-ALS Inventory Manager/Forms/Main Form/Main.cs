using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.ItemForms;
using IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.CategoryForms;
using IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.UserForm;
using IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.Excel;
using IHBrisbane_ALS_Inventory_Manager.Model;
using IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.CheckForms;
using IHBrisbane_ALS_Inventory_Manager.Config;
using IHBrisbane_ALS_Inventory_Manager.ExcelDataHandler;

namespace IHBrisbane_ALS_Inventory_Manager
{
    public partial class Main : Form
    {
        static public User loggedInUser = new User();
        private Item currentItem;
        static public string studentNo;
        public Main()
        {            
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Configuration config = new Configuration();
            LoginForm login = new LoginForm();
            login.ShowDialog();
            if (loggedInUser.userid == null)
            {
                this.Close();
            }
            if (loggedInUser.role == "Admin")
                userToolStripMenuItem.Enabled = true;
            
            
        }

        private void AddItemCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm aCForm = new AddCategoryForm();
            aCForm.ShowDialog();
  
         
        }

        private void deleteITEMCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCategoryForm dCForm = new DeleteCategoryForm();
            dCForm.ShowDialog();
        }

        private void addNewITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm aIForm = new AddItemForm();
            aIForm.ShowDialog();
        }

        private void btUpdateItem_Click(object sender, EventArgs e)
        {
            if (tb_barcode.Text.Length !=0 ) {
                Item item = Item.FindItem(tb_barcode.Text);
                if (item.Barcode != "")
                {
                    UpdateItemForm uIForm = new UpdateItemForm();
                    uIForm.initCom(tb_barcode.Text);
                    uIForm.ShowDialog();
                }
            }
            this.resetDisplay();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.resetDisplay();
            tb_barcode.Focus();

        }

        private void tb_barcode_TextChanged(object sender, EventArgs e)
        {
            if (tb_barcode.Text.Length == 13)
            {
                tb_Display.Text = "";
                this.currentItem = Item.FindItem(tb_barcode.Text);
                if (this.currentItem.Barcode != null && this.currentItem.Barcode != "")
                {
                    tb_Display.Text = "Current Barcode No. :" + currentItem.Barcode + "\r\n" +
                        "Item Description :" + currentItem.ItemDescription + "\r\n" +
                        "Item Category :" + currentItem.ItemCategory.CategoryName + "\r\n" +
                        "Item Loan Period :" + currentItem.ItemCategory.Duration + "\r\n" +
                        "Current status :";
                    string avail;
                    if (currentItem.Status)
                    {
                        avail = "Available";
                        btn_CheckOut.Enabled = true;
                        btn_In.Enabled = false;
                    }
                    else
                    {
                        avail = "Unavailable\r\n" +
                            "Borrower's Student No. :" + currentItem.StudentNo + "\r\n" +
                            "Check Out Date :" + currentItem.CheckoutDate + "\r\n" +
                            "Expiry Date :" + currentItem.ExpiryDate;
                        btn_CheckOut.Enabled = false;
                        btn_In.Enabled = true;
                    }

                    tb_Display.AppendText(avail + "\r\n");

                }
                else MessageBox.Show("There is no item No." + tb_barcode.Text);

                tb_barcode.Focus();



            }
        }
        private void resetDisplay()
        {
            tb_Display.Text = "";
            tb_barcode.Text = "";
            this.currentItem = new Item();
            btn_CheckOut.Enabled = true;
            btn_In.Enabled = false;
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            if (Main.loggedInUser.userid != "" && Main.loggedInUser.userid != null && currentItem != null )
            {
                CheckoutForm checkoutForm = new CheckoutForm();
                checkoutForm.ShowDialog();
                currentItem.Initial = Main.loggedInUser.initial;
                if (Main.studentNo != null && Main.studentNo != "")
                {
                    currentItem.StudentNo = Main.studentNo;
                    currentItem.MakeTransaction(!currentItem.Status);
                    resetDisplay();

                    MessageBox.Show("Transaction Complete!");
                }
                else MessageBox.Show("Check the student Number!");
                
                tb_barcode.Focus();
            }
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            if (Main.loggedInUser.userid != "" && Main.loggedInUser.userid != null && currentItem.Barcode != null)
            {
                currentItem.Initial = Main.loggedInUser.initial;
                currentItem.StudentNo = "";
                currentItem.MakeTransaction(!currentItem.Status);
                resetDisplay();
                MessageBox.Show("Transaction Complete!");
                tb_barcode.Focus();
            }
        }

        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcelData excelForm = new ExcelData();
            excelForm.ShowDialog();
            tb_barcode.Focus();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        private void exportItemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            List<Item> result = Item.SelectAllItems();
            ExportData exData = new ExportData(result);
            exData.WriteAllItemToExcel();
            //MessageBox.Show("Done!");
        }

        private void exportUnreturnedItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Item> result = Item.SelectUnreturnedItems();
            ExportData exData = new ExportData(result);
            exData.WriteExpiredItemToExcel();
        }
    }
}
