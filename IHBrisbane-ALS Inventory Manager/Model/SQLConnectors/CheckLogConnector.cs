using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHBrisbane_ALS_Inventory_Manager.Model.SQLConnectors
{
    class CheckLogConnector:SQLDBConnector
    {
        public CheckLogConnector()
            : base()
        {

        }


        #region CheckLog Table related Methods

        public void MakeLog(string studentNo, string itemBarcode,string itemDescription,  string initial,  bool status, string expiryDate)
        {
            int checkedStatus = 1;
            if (!status) checkedStatus = 0;
            try
            {
             if(expiryDate != "NULL"){
                 expiryDate = "'" + expiryDate + "'";
             }   

                this.ExcuteQurey("insert into CheckLog ( Items_Barcode,Item_Description , User_initial, StudentNo, Check_Status,Expiry_Date ) values('" + itemBarcode + "','"+itemDescription+"','" + initial + "','" + studentNo + "', " + checkedStatus + ","+expiryDate+");");

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
            Item currentItem = new Item();
            //currentItem = Item.FindItem(itemBarcode);
            //currentItem.ChangeStatus(status);
        }
        public List<CheckLog> SelectAllData(string from, string to)
        {
            List<CheckLog> result = new List<CheckLog>();
            try
            {
                this.ExcuteQurey("Select * from CheckLog where Check_Date Between '" + from + " 12:00:00' AND '" + to + " 12:00:00';");

                while (this.dReader.Read())
                {
                    CheckLog check = new CheckLog();
                    check.Id = this.dReader[0].ToString();
                    check.Barcode = this.dReader[1].ToString();
                    check.ItemDescription = this.dReader[2].ToString();
                    check.UserInit = this.dReader[3].ToString();
                    
                    //check.ItemDescription = 
                    bool status;
                    if (Boolean.TryParse(this.dReader[5].ToString(), out status))
                    if (status )
                    {
                        check.StudentNo = "";
                        check.Status = true;
                    }
                    else
                    {
                        check.StudentNo = this.dReader[4].ToString();
                        check.Status = false;
                    }

                    check.CheckOutDate = this.dReader[6].ToString();
                    
                    check.ExpireDate = this.dReader[7].ToString();
                    result.Add(check);
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

    }
}
