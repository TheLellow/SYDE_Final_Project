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
    public partial class frmAddPatientScreen : Form
    {
        public frmAddPatientScreen()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblAdd.Text = "Paitent has been added";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmPatientsScreen back = new frmPatientsScreen();
            this.Hide();
            back.ShowDialog();
        }
    }
}
