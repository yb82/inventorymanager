using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using IHBrisbane_ALS_Inventory_Manager.Config;


namespace IHBrisbane_ALS_Inventory_Manager.Model
{
    
    public class SQLDBConnector
    {
        protected static MySqlConnection con;
        protected MySqlDataReader dReader;
        public SQLDBConnector()
        {
            SQLDBConnector.con = new MySqlConnection();

        }
        protected void CloseConnection(){
            con.Close();
        }
        protected void ExcuteQurey(string query)
        {
            this.MakeConnection();
            MySqlCommand com = new MySqlCommand(query, con);
            this.dReader = com.ExecuteReader();

        }
        protected void MakeConnection()
        {
            var temp = con.State.ToString();
            
            if (con.State != System.Data.ConnectionState.Open && temp != "Open")
            {
                con.ConnectionString = "Data Source="+Configuration.ipaddress+";Database="+Configuration.id+";User Id=bo;Password="+Configuration.password+";Convert Zero Datetime=True";
                con.Open();
            }

        }
       
        static public string CovertDateToDB(DateTime date)
        {
            string FORMAT = "yyyy-MM-dd";
            string result = date.ToString(FORMAT);
            return result;

        }
      
        static public DateTime ConvertStringToDate(string date)
        {
            
            DateTime result = new DateTime();
            DateTime.TryParse(date, out result);
            return result;
        }
       
     

    }
}
