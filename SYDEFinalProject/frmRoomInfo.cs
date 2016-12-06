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
    public partial class frmRoomInfo : Form
    {
        public frmRoomInfo()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmRoomsScreen back = new frmRoomsScreen();
            this.Hide();
            back.ShowDialog();
        }
    }
}
