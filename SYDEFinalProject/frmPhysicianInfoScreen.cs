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
    public partial class frmPhysicianInfoScreen : Form
    {
        public frmPhysicianInfoScreen()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblDelete.Text = "Physician has been deleted";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmPhysicianUpdateScreen Up = new frmPhysicianUpdateScreen();
            this.Hide();
            Up.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmPhysiciansScreen back = new frmPhysiciansScreen();
            this.Hide();
            back.ShowDialog();
        }
    }
}
