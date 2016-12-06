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
    public partial class frmAddEmployeeScreen : Form
    {
        public frmAddEmployeeScreen()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmEmployeesScreen Emp = new frmEmployeesScreen();
            this.Hide();
            Emp.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblAdd.Text = "Employee has been added";
        }
    }
}
