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
using IHBrisbane_ALS_Inventory_Manager.ExcelDataHandler;
namespace IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.Excel
{
    public partial class DateSelector : Form
    {
        public DateSelector()
        {
            InitializeComponent();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            DateTime fromDate, toDate;
            if (DateTime.TryParse(tbFromDate.Text, out fromDate) && DateTime.TryParse(tbToDate.Text, out toDate))
            {
                List<CheckLog> result = CheckLog.GetData(tbFromDate.Text, tbToDate.Text);
                ExportData exportData = new ExportData(result);
            }
            else MessageBox.Show("Please Check your Date format(dd/MM/YYYY)");
            
        }

        private void DateSelector_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Item> result = Item.FindExpiredItem();
            
            ExportData exData = new ExportData(result);
            exData.WriteExpiredItemToExcel();
            this.Close();
        }

        private void btExport_Click_1(object sender, EventArgs e)
        {
            if (tbFromDate != null && tbFromDate.Text != null && tbToDate.Text !="" && tbToDate.Text != null) { 
                DateTime temp;
                if (DateTime.TryParse(tbFromDate.Text, out temp) && DateTime.TryParse(tbFromDate.Text, out temp)) { 
                    List<CheckLog> result = CheckLog.GetData(tbFromDate.Text, tbToDate.Text);
                    ExportData expData = new ExportData(result);
                    expData.WriteResultToExcel();
                }
            }
        }
    }
}
