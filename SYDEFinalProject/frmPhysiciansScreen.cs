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
    public partial class frmPhysiciansScreen : Form
    {
        public frmPhysiciansScreen()
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
            frmPhysicianInfoScreen Info = new frmPhysicianInfoScreen();
            this.Hide();
            Info.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmAddPhysicianScreen Add = new frmAddPhysicianScreen();
            this.Hide();
            Add.ShowDialog();
        }
    }
}
