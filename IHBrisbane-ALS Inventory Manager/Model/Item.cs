using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHBrisbane_ALS_Inventory_Manager.Model
{
    public class Item
    {
        public String Barcode { get; set; }
        public String ItemDescription { get; set; }
        public Boolean Status { get; set; }

        public Category  ItemCategory { get;  set; }
        public string CheckoutDate { get; set; }
        public string ExpiryDate { get; set; }
        public string Initial { get; set; }
        public string StudentNo { get; set; }
        public string CategoryName { get; set; }

        public Item()
        {
            this.ItemCategory = new Category();
        }
        static public Item FindItem(string barcodeNo)
        {
            ItemConnector sc = new ItemConnector();
            
            Item resultItem = sc.SelectItem(barcodeNo);
            return resultItem;
            
        }

        public void MakeTransaction(bool status)
        {
            DateTime now = DateTime.Now;
            DateTime expiryDate = now.AddDays(this.ItemCategory.Duration);
            this.CheckoutDate = SQLDBConnector.CovertDateToDB(now);
            this.ExpiryDate = SQLDBConnector.CovertDateToDB(expiryDate);
            ItemConnector sc = new ItemConnector();

            if (status)
            {
                sc.UpdateItem(this.Barcode, this.Barcode, this.ItemDescription, status, this.ItemCategory.CategoryName, "NULL", "NULL", "NULL", this.Initial);
                CheckLog.TransactionItem(this.StudentNo, this.Barcode, this.ItemDescription, this.Initial, status, "NULL");
            }
            else
            {
                sc.UpdateItem(this.Barcode, this.Barcode, this.ItemDescription, status, this.ItemCategory.CategoryName, this.StudentNo, this.CheckoutDate, this.ExpiryDate, this.Initial);
                CheckLog.TransactionItem(this.StudentNo, this.Barcode, this.ItemDescription, this.Initial, status, this.ExpiryDate);
            }
            //CheckLog cl = new CheckLog();
            

        }
       static public void AddItem(string barcode, string itemDescription,string itemCategory)
        {
            ItemConnector sc = new ItemConnector();
            sc.InsertItem(barcode,itemDescription,itemCategory);
        }
       public void AddItem()
       {
           ItemConnector sc = new ItemConnector();
           sc.InsertItem(this.Barcode, this.ItemDescription, this.ItemCategory.CategoryName);
       }

       static public void DelItem(string barcode)
       {
           ItemConnector sc = new ItemConnector();
           sc.DeleteItem(barcode);
       }
       static public void UpdateItem(string oldBarcode,string newBarcode,string itemDescription,bool status, string ItemCategory)
       {
           ItemConnector sc = new ItemConnector();
           sc.UpdateItem(oldBarcode, newBarcode, itemDescription, status  ,ItemCategory,"","","","");
       }
       static public List<Item> FindExpiredItem()
       {
           
           ItemConnector sc = new ItemConnector();
           List<Item> result = sc.SelectAllItemExpiredItem();
           return result;
       }
       static public List<Item> SelectAllItems()
       {
           ItemConnector sc = new ItemConnector();
           List<Item> result = sc.SelectAllItem();
           return result;
       }
       static public List<Item> SelectUnreturnedItems()
       {
           ItemConnector sc = new ItemConnector();
           List<Item> result = sc.SelectUnreturendItem();
           return result;
       }
       
       
    }
}
