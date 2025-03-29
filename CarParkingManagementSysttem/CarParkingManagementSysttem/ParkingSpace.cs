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
    public partial class ParkingSpace : Form
    {
       
        public ParkingSpace()
        {
            InitializeComponent();
            
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Parking_Space_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.Show();
        }

        
        private void spaceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpaceReport sr = new SpaceReport();
            sr.Show();
        }

        private void parkingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParkingReport pr = new ParkingReport();
            pr.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Level0 lo = new Level0();
            lo.Show();
            Level0.lo.tbx.Text = label4.Text;
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level1 ll = new Level1();
            ll.Show();
            Level1.lo.tbx.Text = label6.Text;
            
        }

       

        private void carParkingExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParkingExit acpe = new AssingCarParkingExit();
            acpe.Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        public TextBox textbox6 { get; set; }
    }
}
