using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CarParkingManagementSysttem
{
    public partial class Level1 : Form
    {
        public static Level1 lo;
        public TextBox tbx;         
        public Level1()
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

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label3.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label5.Text;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label6.Text;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label7.Text;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label8.Text;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label9.Text;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label10.Text;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label11.Text;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label12.Text;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label13.Text;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label14.Text;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label15.Text;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label16.Text;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label17.Text;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label18.Text;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label19.Text;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label20.Text;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label21.Text;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label22.Text;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label23.Text;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label24.Text;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label25.Text;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label26.Text;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label27.Text;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label28.Text;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label29.Text;
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label30.Text;
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label31.Text;
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label32.Text;
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParking acp = new AssingCarParking();
            acp.Show();
            AssingCarParking.acp.tbx.Text = textBox1.Text;
            AssingCarParking.acp.t.Text = label33.Text;
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void carParkingExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssingCarParkingExit acpe = new AssingCarParkingExit();
            acpe.Show();
        }

        private void Level1_Load(object sender, EventArgs e)
        {

        }
    }
}
