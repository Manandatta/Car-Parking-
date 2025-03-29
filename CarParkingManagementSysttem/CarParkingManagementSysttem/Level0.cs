using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace CarParkingManagementSysttem
{
    public partial class Level0 : Form
    {
        public static Level0 lo;
        public TextBox tbx;
        
        public Level0()
        {
            InitializeComponent();
            lo = this;
            tbx = textBox1;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.Show();
        }

        private void allotParkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParkingSpace ps = new ParkingSpace();
            ps.Show();
        }

        private void soaceReportToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label3.Text;
            pictureBox1.Enabled = false;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label5.Text;
            pictureBox2.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label6.Text;
            pictureBox3.Enabled = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label7.Text;
            pictureBox4.Enabled = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label8.Text;
            pictureBox5.Enabled = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label9.Text;
            pictureBox6.Enabled = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label10.Text;
            pictureBox7.Enabled = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label11.Text;
            pictureBox8.Enabled = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label12.Text;
            pictureBox9.Enabled = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label13.Text;
            pictureBox10.Enabled = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label14.Text;
            pictureBox11.Enabled = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label15.Text;
            pictureBox12.Enabled = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label16.Text;
            pictureBox13.Enabled = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label17.Text;
            pictureBox14.Enabled = false;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label18.Text;
            pictureBox15.Enabled = false;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label19.Text;
            pictureBox16.Enabled = false;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label20.Text;
            pictureBox17.Enabled = false;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label21.Text;
            pictureBox18.Enabled = false;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label22.Text;
            pictureBox19.Enabled = false;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label23.Text;
            pictureBox20.Enabled = false;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label24.Text;
            pictureBox21.Enabled = false;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label25.Text;
            pictureBox22.Enabled = false;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label26.Text;
            pictureBox23.Enabled = false;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label27.Text;
            pictureBox24.Enabled = false;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label28.Text;
            pictureBox25.Enabled = false;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label29.Text;
            pictureBox26.Enabled = false;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label30.Text;
            pictureBox27.Enabled = false;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label31.Text;
            pictureBox28.Enabled = false;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label32.Text;
            pictureBox29.Enabled = false;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label33.Text;
            pictureBox30.Enabled = false;
        }

      

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.Show();
        }

        private void carParkingExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParkingExit acpe = new AssingCarParkingExit();
            acpe.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Level0__Load(object sender, EventArgs e)
        {

        }

        
    }
}
