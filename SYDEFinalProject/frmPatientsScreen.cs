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
    public partial class frmPatientsScreen : Form
    {
        public frmPatientsScreen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainScreen Main = new frmMainScreen();
            this.Hide();
            Main.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmPatientInfoScreen Info = new frmPatientInfoScreen();
            this.Hide();
            Info.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmAddPatientScreen Add = new frmAddPatientScreen();
            this.Hide();
            Add.ShowDialog();
        }
    }
}
