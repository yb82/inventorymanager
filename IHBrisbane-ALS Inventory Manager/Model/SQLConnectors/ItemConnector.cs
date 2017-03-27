using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IHBrisbane_ALS_Inventory_Manager.Model
{
    public class ItemConnector:CategoryConnector
    {
        #region ITEM Table related Methods
        public ItemConnector():base()
        {
        
        }

        public void InsertItem(string barcode, string itemDescription, string itemCategory)
        {
            try
            {
                this.ExcuteQurey("insert into Items (Barcode, Item_Description, Item_Category ) values('" + barcode + "','" + itemDescription + "','" + itemCategory + "');");
                while (this.dReader.Read())
                {

                }
                this.CloseConnection();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.CloseConnection();
            }
        }

        public List<Item> SelectAllItem()
        {
            List<Item> result = new List<Item>();
            try
            {
                this.ExcuteQurey("Select * from Items;");

                while (this.dReader.Read())
                {
                    Item item = new Item();
                    item.Barcode = this.dReader[0].ToString();
                    item.ItemDescription = this.dReader[1].ToString();
                    Boolean status;
                    item.Status = Boolean.TryParse(this.dReader[2].ToString(), out status);
                    item.StudentNo = this.dReader[3].ToString();
                    item.CheckoutDate = this.dReader[4].ToString();
                    item.ExpiryDate= this.dReader[5].ToString();
                    item.CategoryName = this.dReader[6].ToString();
                    item.Initial = this.dReader[7].ToString();
                    result.Add(item);
                }

                this.CloseConnection();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.CloseConnection();
            }
            return result;

        }
        public void DeleteItem(string barcode)
        {
            try
            {
                this.ExcuteQurey("DELETE FROM `Items` WHERE Barcode = '" + barcode + "' ;");
                while (this.dReader.Read())
                {

                }

                this.CloseConnection();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.CloseConnection();
            }
            //   return result;
        }
        public void UpdateItem(string oldBarcode, string newBarcode, string itemdescription, bool status, string itemCategory, string studentNo, string checkOutDate, string expiryDate, string userInitial)
        {
            try
            {
                int statusFlag = 1;
                if (!status)
                {
                    statusFlag = 0;
                    this.ExcuteQurey("UPDATE `Items` SET `Barcode` = '" + newBarcode + "', `Status` = " + statusFlag + ", `Item_Description` = '" + itemdescription + "', `Item_Category` = '" + itemCategory + "' , `Student_No`='" + studentNo + "', `Checkout_Date`= '" + checkOutDate + "', `Expiry_Date`='" + expiryDate + "', `User_Initial`='" + userInitial + "' WHERE `Items`.`Barcode` = '" + oldBarcode + "';");


                }
                else this.ExcuteQurey("UPDATE `Items` SET `Barcode` = '" + newBarcode + "', `Status` = " + statusFlag + ", `Item_Description` = '" + itemdescription + "', `Item_Category` = '" + itemCategory + "' , `Student_No`= NULL, `Checkout_Date`= NULL, `Expiry_Date`=NULL, `User_Initial`=NULL WHERE `Items`.`Barcode` = '" + oldBarcode + "';");
                while (this.dReader.Read())
                {

                }

                this.CloseConnection();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.CloseConnection();
            }
            //   return result;
        }



        public Item SelectItem(string Barcode)
        {

            Item resultItem = new Item();
            string categoryName = "";
            try
            {
                this.ExcuteQurey("Select * from Items where Barcode ='" + Barcode + "';");

                while (this.dReader.Read())
                {

                    resultItem.Barcode = this.dReader[0].ToString();
                    resultItem.ItemDescription = this.dReader[1].ToString();
                    Boolean status;
                    if (Boolean.TryParse(this.dReader[2].ToString(), out status))
                    {
                        resultItem.Status = status;
                    }
                    categoryName = this.dReader[3].ToString();
                    
                    resultItem.StudentNo = this.dReader[4].ToString();
                    string checkoutDate =this.dReader[5].ToString();
                    if( checkoutDate!="") resultItem.CheckoutDate = checkoutDate;
                    
                    checkoutDate = this.dReader[6].ToString();
                    if (checkoutDate != "") resultItem.ExpiryDate = checkoutDate;
                }
                //disconnect and close 
                this.CloseConnection();
                resultItem.ItemCategory = this.SelectCategory(categoryName);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.CloseConnection();
            }
            return resultItem;
        }
        public List<Item> SelectAllItemExpiredItem()
        {
            List<Item> result = new List<Item>();
            try
            {
                this.ExcuteQurey("Select * from Items where Expiry_Date <= Now() ;");

                while (this.dReader.Read())
                {
                    Item item = new Item();
                    item.Barcode = this.dReader[0].ToString();
                    item.ItemDescription = this.dReader[1].ToString();
                    Boolean status;
                    if( Boolean.TryParse(this.dReader[2].ToString(), out status)){
                    item.Status = status;
                        }
                    item.StudentNo = this.dReader[4].ToString();
                    item.CheckoutDate = this.dReader[5].ToString();
                    item.ExpiryDate = this.dReader[6].ToString();
                    item.CategoryName = this.dReader[3].ToString();
                    item.Initial = this.dReader[7].ToString();
                    
                    result.Add(item);
                }

                this.CloseConnection();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.CloseConnection();
            }
            return result;

        }
        #endregion

        internal List<Item> SelectUnreturendItem()
        {
            List<Item> result = new List<Item>();
            try
            {
                this.ExcuteQurey("Select * from Items where Status = 0 ;");

                while (this.dReader.Read())
                {
                    Item item = new Item();
                    item.Barcode = this.dReader[0].ToString();
                    item.ItemDescription = this.dReader[1].ToString();
                    Boolean status;
                    if (Boolean.TryParse(this.dReader[2].ToString(), out status))
                    {
                        item.Status = status;
                    }
                    item.StudentNo = this.dReader[4].ToString();
                    item.CheckoutDate = this.dReader[5].ToString();
                    item.ExpiryDate = this.dReader[6].ToString();
                    item.CategoryName = this.dReader[3].ToString();
                    item.Initial = this.dReader[7].ToString();

                    result.Add(item);
                }

                this.CloseConnection();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                this.CloseConnection();
            }
            return result;
        }
    }
}
