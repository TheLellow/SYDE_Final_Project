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
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            frmPatientsScreen Patients = new frmPatientsScreen();
            this.Hide();
            Patients.ShowDialog();
            
        }

        private void btnPhysicians_Click(object sender, EventArgs e)
        {
            frmPhysiciansScreen Phy = new frmPhysiciansScreen();
            this.Hide();
            Phy.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmEmployeesScreen Emp = new frmEmployeesScreen();
            this.Hide();
            Emp.ShowDialog();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            frmRoomsScreen Rooms = new frmRoomsScreen();
            this.Hide();
            Rooms.ShowDialog();
        }
    }
}
