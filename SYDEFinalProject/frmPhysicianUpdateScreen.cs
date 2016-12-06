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
    public partial class frmPhysicianUpdateScreen : Form
    {
        public frmPhysicianUpdateScreen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmPhysicianInfoScreen back = new frmPhysicianInfoScreen();
            this.Hide();
            back.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblUpdate.Text = "Physician has been updated";
        }
    }
}
