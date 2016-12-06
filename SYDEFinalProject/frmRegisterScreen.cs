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
    public partial class frmRegisterScreen : Form
    {
        public frmRegisterScreen()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtPasswordCon.PasswordChar = '*';
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHomeScreen Home = new frmHomeScreen();
            this.Hide();
            Home.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmAdminLoginScreen Log = new frmAdminLoginScreen();
            this.Hide();
            Log.ShowDialog();
        }
    }
}
