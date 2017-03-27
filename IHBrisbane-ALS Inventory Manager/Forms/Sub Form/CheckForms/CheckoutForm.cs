using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHBrisbane_ALS_Inventory_Manager.Forms.Sub_Form.CheckForms
{
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
            
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void btCheckOut_Click(object sender, EventArgs e)
        {
            Main.studentNo = tbStudentNo.Text;
            this.Close();
        }
    }
}
