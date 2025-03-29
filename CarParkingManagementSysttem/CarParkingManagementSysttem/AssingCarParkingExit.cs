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
    public partial class AssingCarParkingExit : Form
    {
        string query="" ;
        public AssingCarParkingExit()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hp = new Homepage();
            hp.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (!Regex.Match(text, "^[0-9]*$").Success)
            {
                MessageBox.Show("Enter Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if (!Regex.Match(text, "^[0-9]*$").Success)
            {
                MessageBox.Show("Enter Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string text = textBox5.Text;
            if (!Regex.Match(text, "^[A-Z||a-z]*$").Success)
            {
                MessageBox.Show("Enter Name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Clear();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string text = textBox6.Text;
            if (!Regex.Match(text, "^[0-9]*$").Success)
            {
                MessageBox.Show("Enter Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Clear();
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string text = textBox7.Text;
            if (!Regex.Match(text, "^[0-9 && Rs]*$").Success)
            {
                MessageBox.Show("Enter Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox7.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (textBox1.Text == "" && textBox2.Text == "" && dateTimePicker3.Text == "" && dateTimePicker4.Text == "" && textBox5.Text == "" && comboBox1.Text == "" && textBox7.Text=="" )
            {
                MessageBox.Show("Blank text box not allowed", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    OleDbConnection con = new OleDbConnection();
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PDF\B.C.A-5\PROJECT\Project.accdb";
                    con.Open();
                    string query = "update CarParkingReport SET ExitDate='"+dateTimePicker2.Text+"',ExitTime='"+dateTimePicker4.Text+"',Rupees='"+textBox7.Text+"' where id="+id;
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Update ");
                    dataGridView1.Refresh();
                    comboBox1.Text = null;
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + query);
                }
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
        }
       
        private void AssingCarParkingExit_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        static int id = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePicker4.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void parkingToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void textBox6_Validated(object sender, EventArgs e)
        {
            if (textBox6.Text.Length == 10)
            {
            }
            else
            {
                MessageBox.Show("Enter 10 digit only", "Error");
            }
        }

        private void dateTimePicker3_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker3.CustomFormat = "HH:mm:ss";
        }

       

        private void dateTimePicker4_MouseDown_1(object sender, MouseEventArgs e)
        {
            dateTimePicker4.CustomFormat = "HH:mm:ss";
        }

       

    }
}

