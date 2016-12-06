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
    public partial class frmAddPhysicianScreen : Form
    {
        public frmAddPhysicianScreen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmPhysiciansScreen back = new frmPhysiciansScreen();
            this.Hide();
            back.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblAdd.Text = "Physician has been added";
        }
    }
}
