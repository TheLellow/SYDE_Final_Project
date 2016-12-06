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
    public partial class frmEmployeeUpdateScreen : Form
    {
        public frmEmployeeUpdateScreen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmEmployeeInfoScreen Info = new frmEmployeeInfoScreen();
            this.Hide();
            Info.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblUpdate.Text = "Employee has been updated";
        }
    }
}
