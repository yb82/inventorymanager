using IHBrisbane_ALS_Inventory_Manager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace IHBrisbane_ALS_Inventory_Manager.ExcelDataHandler
{
    public class ExportData
    {
        private Excel.Application xlApp = null;
        private List<CheckLog> resultList1;
        private List<Item> resultList2;
        public ExportData(List<CheckLog> result)
        {
            this.resultList1 = result; 
        }
        public ExportData(List<Item> result)
        {
            this.resultList2 = result;
        }
        private void initApplication()
        {
            this.xlApp = new Excel.Application();
            if (this.xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
            }
            this.xlApp.Visible = false;
           
        }
        public void WriteResultToExcel()
        {
            this.initApplication();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(1);
            Excel.Sheets xlWorksheet = xlWorkBook.Worksheets;
            var xlNewSheet = (Excel.Worksheet)xlWorksheet.Add(xlWorksheet[1]);
            int row = 1;
           
            foreach (CheckLog check in resultList1)
            {
                xlNewSheet.Cells[row, 1] = check.Barcode;
                xlNewSheet.Cells[row, 2] = check.ItemDescription;
                xlNewSheet.Cells[row, 3] = check.UserInit;

                if (check.Status) { 

                  xlNewSheet.Cells[row, 4] = "";
                    xlNewSheet.Cells[row, 5] = "IN";
                }
                else
                {
                    xlNewSheet.Cells[row, 4] = check.StudentNo;
                    xlNewSheet.Cells[row, 5] = "Out";
                }
                xlNewSheet.Cells[row, 6] = check.CheckOutDate;
                xlNewSheet.Cells[row, 7] = check.ExpireDate;
                row++;
                
                
            }


            //Excel.Range range = xlNewSheet.UsedRange;
            //range.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
            var filename = xlApp.GetSaveAsFilename("result.xls", "Excel files (*.xls), *.xls");
            bool temp;
            if (Boolean.TryParse(filename, out temp))
            {
                MessageBox.Show("Cancelled!!");
            }
            else 
            {
                xlWorkBook.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                xlWorkBook.Close(true, Type.Missing, Type.Missing);
                xlApp.Quit();
                MessageBox.Show("Done!!!!");
            }
            
        }

        public void WriteExpiredItemToExcel()
        {
            this.initApplication();
           
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(1);
            Excel.Sheets xlWorksheet = xlWorkBook.Worksheets;
            var xlNewSheet = (Excel.Worksheet)xlWorksheet.Add(xlWorksheet[1]);
            int row = 1;
           
            foreach (Item check in resultList2)
            {
              
                    xlNewSheet.Cells[row, 1] = check.Barcode;
                    xlNewSheet.Cells[row, 2] = check.ItemDescription;
                    xlNewSheet.Cells[row, 3] = check.StudentNo;
                       
                    if(check.CheckoutDate != null && check.CheckoutDate !="")
                        xlNewSheet.Cells[row, 4] = SQLDBConnector.CovertDateToDB( SQLDBConnector.ConvertStringToDate( check.CheckoutDate));
                    if (check.ExpiryDate != null && check.ExpiryDate != "")
                        xlNewSheet.Cells[row, 5] = SQLDBConnector.CovertDateToDB( SQLDBConnector.ConvertStringToDate( check.ExpiryDate));
                    xlNewSheet.Cells[row, 6] = check.Initial;
                row++;
                
                



            }


            //Excel.Range range = xlNewSheet.UsedRange;
            //range.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);

            var filename = xlApp.GetSaveAsFilename("result.xls", "Excel files (*.xls), *.xls");
            bool temp;
            if (Boolean.TryParse(filename, out temp))
            {
                MessageBox.Show("Cancelled!!");
            }
            else
            {
                xlWorkBook.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                xlWorkBook.Close(true, Type.Missing, Type.Missing);
                xlApp.Quit();
                MessageBox.Show("Done!!!!");
            }
        }
        public void WriteAllItemToExcel()
        {
            this.initApplication();

            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(1);
            Excel.Sheets xlWorksheet = xlWorkBook.Worksheets;
            var xlNewSheet = (Excel.Worksheet)xlWorksheet.Add(xlWorksheet[1]);
            int row = 1;

            foreach (Item check in resultList2)
            {
                string status = "Out";
                if (check.Status)
                {
                    status = "In";
                }
                    xlNewSheet.Cells[row, 1] = check.Barcode;
                    xlNewSheet.Cells[row, 2] = check.ItemDescription;
                    xlNewSheet.Cells[row, 3] = check.StudentNo;
                    //xlNewSheet.Cells[row, 4] = status;
                    //if (check.CheckoutDate != null && check.CheckoutDate != "")
                    //    xlNewSheet.Cells[row, 5] = SQLDBConnector.CovertDateToDB(SQLDBConnector.ConvertStringToDate(check.CheckoutDate));
                    //if (check.ExpiryDate != null && check.ExpiryDate != "")
                    //    xlNewSheet.Cells[row, 6] = SQLDBConnector.CovertDateToDB(SQLDBConnector.ConvertStringToDate(check.ExpiryDate));
                    ////xlNewSheet.Cells[row, 7] = check.Initial;
                
                    row++;





            }


            //Excel.Range range = xlNewSheet.UsedRange;
            //range.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
            var filename = xlApp.GetSaveAsFilename("result.xls", "Excel files (*.xls), *.xls");
            bool temp;
            if (Boolean.TryParse(filename, out temp))
            {
                MessageBox.Show("Cancelled!!");
            }
            else
            {
                xlWorkBook.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                xlWorkBook.Close(true, Type.Missing, Type.Missing);
                xlApp.Quit();
                MessageBox.Show("Done!!!!");
            }
        }

        
    }
}
