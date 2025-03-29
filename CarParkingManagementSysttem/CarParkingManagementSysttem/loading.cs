using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarParkingManagementSysttem
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value >=99)
            {
                Login l = new Login();
                this.Hide();
                l.Show();

                timer1.Enabled = false;
                progressBar1.Value = progressBar1.Value - 1;
            }
        }

        private void loading_Load(object sender, EventArgs e)
        {

        }
    }
}
