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
    public partial class frmPatientUpdateScreen : Form
    {
        public frmPatientUpdateScreen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmPatientInfoScreen Info = new frmPatientInfoScreen();
            this.Hide();
            Info.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblUpdate.Text = "Patient has been updated";
        }
    }
}
