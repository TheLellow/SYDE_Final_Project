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
    public partial class frmAdminLoginScreen : Form
    {
        public frmAdminLoginScreen()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMainScreen Main = new frmMainScreen();
            this.Hide();
            Main.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHomeScreen Home = new frmHomeScreen();
            this.Hide();
            Home.ShowDialog();
        }
    }
}
