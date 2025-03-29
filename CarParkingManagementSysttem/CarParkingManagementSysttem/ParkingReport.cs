using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CarParkingManagementSysttem
{
    public partial class ParkingReport : Form
    {
        string query = "";
        public ParkingReport()
        {
            InitializeComponent();
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

        private void allotParkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ParkingSpace ps = new ParkingSpace();
            ps.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.Show();
        }

        private void ParkingReport_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PDF\B.C.A-5\PROJECT\Project.accdb";
                con.Open();
                query = "select * from CarParkingReport";
                OleDbDataAdapter da = new OleDbDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + query);
            }
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
       
    }
}
