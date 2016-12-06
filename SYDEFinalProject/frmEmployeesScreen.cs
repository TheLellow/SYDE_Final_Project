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
    public partial class frmEmployeesScreen : Form
    {
        public frmEmployeesScreen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainScreen Main = new frmMainScreen();
            this.Hide();
            Main.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmAddEmployeeScreen Emp = new frmAddEmployeeScreen();
            this.Hide();
            Emp.ShowDialog();
        }

        private void btnViewEmployeeInfo_Click(object sender, EventArgs e)
        {
            frmEmployeeInfoScreen Info = new frmEmployeeInfoScreen();
            this.Hide();
            Info.ShowDialog();
        }
    }
}
