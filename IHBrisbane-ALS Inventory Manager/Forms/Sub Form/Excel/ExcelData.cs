using IHBrisbane_ALS_Inventory_Manager.ExcelDataHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.Excel
{
    public partial class ExcelData : Form
    {
        private OpenFileDialog fileDialog = null;
        private ImportData importDate;
        public ExcelData()
        {
            InitializeComponent();
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            this.initOpenDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                importDate = new ImportData(fileDialog.FileName);
                MessageBox.Show("Import Data Complete!");
                this.Close();
            }
           
        }
        private void initOpenDialog()
        {
            this.fileDialog = new OpenFileDialog();
            this.fileDialog.Title = "Open file";

        }

        private void ExcelData_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btExportData_Click(object sender, EventArgs e)
        {
            DateSelector dsForm = new DateSelector();
            dsForm.ShowDialog();
        }
    }
}
