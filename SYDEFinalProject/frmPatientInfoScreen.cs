using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYDEFinalProject
{
    public partial class frmPatientInfoScreen : Form
    {
        public frmPatientInfoScreen()
        {
            InitializeComponent();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            frmBillingInfoScreen Bill = new frmBillingInfoScreen();
            this.Hide();
            Bill.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmPatientUpdateScreen Up = new frmPatientUpdateScreen();
            this.Hide();
            Up.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            frmTransactionScreen Trans = new frmTransactionScreen();
            this.Hide();
            Trans.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmPatientsScreen Pat = new frmPatientsScreen();
            this.Hide();
            Pat.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblDelete.Text = "Patient has been deleted";
        }
    }
}
