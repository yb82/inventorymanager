using IHBrisbane_ALS_Inventory_Manager.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace IHBrisbane_ALS_Inventory_Manager.ExcelDataHandler
{
    public class ImportData
    {
        private String connectionStringSrc = null;
        private const int BARCODE= 0;
        private const int DESCRIPTION = 1;
        private const int CATEGORY = 2;
        private string p;
      
        public ImportData(string p)
        {
            // TODO: Complete member initialization
            try
            {
                this.OpenData(p);
            }
            catch (Exception e)
            {

            }
        }
        private void OpenData(string filePath)
        {
            this.connectionStringSrc = string.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}; Extended Properties=\"Excel 12.0;\"", filePath);
            OleDbConnection con = new OleDbConnection(this.connectionStringSrc);
            con.Open();

           
           



            /*pull the data from excel file and store in dataset
             *pass to data to datatable collection.
            */

            var adapter = new OleDbDataAdapter("Select * From [Sheet1$]", con);
            var ds = new DataSet();

            adapter.Fill(ds);
            DataTable data = ds.Tables[0];

           
            foreach (DataRow row in data.Rows)
            {
                Item currentItem = new Item();
                

              
                string value = row[BARCODE].ToString();
                if ( value != "")
                {

                    currentItem.Barcode = value;
                    currentItem.ItemDescription = row[DESCRIPTION].ToString();
                    currentItem.ItemCategory = Category.FindCategory(row[CATEGORY].ToString());
                    currentItem.AddItem();
                 }

            }
            
            con.Close();
            //Excel.Application xlApp;
            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;

            //xlApp = new Excel.Application();
            //xlWorkBook = xlApp.Workbooks.Open(filePath);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);



        }
    }
}
