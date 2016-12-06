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
    public partial class frmHomeScreen : Form
    {
        public frmHomeScreen()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            frmAdminLoginScreen AdminLogin = new frmAdminLoginScreen();
            this.Hide();
            AdminLogin.ShowDialog();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterNewAdmin_Click(object sender, EventArgs e)
        {
            frmRegisterScreen Register = new frmRegisterScreen();
            this.Hide();
            Register.ShowDialog();
        }
    }
}
