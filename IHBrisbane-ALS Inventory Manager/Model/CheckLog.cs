using IHBrisbane_ALS_Inventory_Manager.Model.SQLConnectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHBrisbane_ALS_Inventory_Manager.Model
{
    public class CheckLog
    {
        public string Id { get; set; }
        public string Barcode { get; set; }
        public string UserInit { get; set; }
        public string StudentNo { get; set; }
        public bool Status { get; set; }
        public string CheckOutDate { get; set; }
        public string ItemDescription { get; set; }
        public string ExpireDate { get; set; }
        
        
        public CheckLog()
        {
            
            
        }
        static public void TransactionItem(string studentNo, string itemBarcode, string itemDescription,string initial, bool status, string expirDate)
        {
            CheckLogConnector sc = new CheckLogConnector();
            sc.MakeLog(studentNo, itemBarcode, itemDescription,initial, status, expirDate);
            
            
        }
        static public List<CheckLog> GetData(string from, string to)
        {
           
            CheckLogConnector sc = new CheckLogConnector();
            string dbFromDateTime = SQLDBConnector.CovertDateToDB( SQLDBConnector.ConvertStringToDate(from));
            string dbToDateTime = SQLDBConnector.CovertDateToDB(SQLDBConnector.ConvertStringToDate(to));
            List<CheckLog> result = sc.SelectAllData(dbFromDateTime, dbToDateTime);
            return result;
        }
        
    }
}
