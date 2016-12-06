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
    public partial class frmRoomsScreen : Form
    {
        public frmRoomsScreen()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmRoomInfo Info = new frmRoomInfo();
            this.Hide();
            Info.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMainScreen Main = new frmMainScreen();
            this.Hide();
            Main.ShowDialog();
        }
    }
}
