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
    public partial class AssingCarParking : Form
    {
        
        string query = "";
        public static AssingCarParking acp;
        public TextBox tbx;
        public TextBox t;
        public AssingCarParking()
        {
            InitializeComponent();
            acp = this;
            tbx = textBox6;
            t = textBox1;
           
            
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text == "" && textBox2.Text == "" &&  textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "")
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
                    query = "INSERT INTO CarParkingReport(CarNo,EntryDate,EntryTime,SlotNo,Name,MobileNo,ParkingSpace) values ('" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";                                               
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Save ");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + query);
                }
            }
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string text = textBox4.Text;
            if (!Regex.Match(text, "^[A-Z||a-z]*$").Success)
            {
                MessageBox.Show("Enter Name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Clear();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string text = textBox5.Text;
            if (!Regex.Match(text, "^[0-9]*$").Success )
            {
                
                    MessageBox.Show("Enter Number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox5.Clear();

                
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

        private void AssingCarParking_Load(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
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

        private void textBox5_Validated(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 10)
            {
            }
            else
            {
                MessageBox.Show("Enter 10 digit only", "Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker2_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker2.CustomFormat = "HH:mm:ss";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string d = "-------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString("MANAN CAR PARKING SYSTEM ", new Font("Arial", 24, FontStyle.Bold),Brushes.Black,new Point(180,10));
            e.Graphics.DrawString(d, new Font("Arial", 26, FontStyle.Bold), Brushes.Black, new Point(0, 25));
            e.Graphics.DrawString("RECIPT", new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(350, 55));
            e.Graphics.DrawString("Date:-" + dateTimePicker1.Text, new Font("Arial", 22, FontStyle.Regular), Brushes.Black, new Point(500, 55));
            e.Graphics.DrawString(d , new Font("Arial", 26, FontStyle.Bold), Brushes.Black, new Point(0,65));
            e.Graphics.DrawString("Name:-"+textBox4.Text,new Font("Arial",20,FontStyle.Regular),Brushes.Black,new Point(40,95));
            e.Graphics.DrawString(d, new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(0,125));
            e.Graphics.DrawString("Contact No:-" + textBox5.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(40, 155));
            e.Graphics.DrawString(d, new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(0, 185));
            e.Graphics.DrawString("Car No:-" + textBox2.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(40, 215));
            e.Graphics.DrawString(d, new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(0, 245));
            e.Graphics.DrawString("Entry Date:-" + dateTimePicker1.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(40,275));
            e.Graphics.DrawString(d, new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(0, 305));
            e.Graphics.DrawString("Entry Time:-" + dateTimePicker2.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(40, 335));
            e.Graphics.DrawString(d, new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(0, 365));
            e.Graphics.DrawString("Parking Space:-" + textBox6.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(40, 395));
            e.Graphics.DrawString(d, new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(0, 425));
            e.Graphics.DrawString("Slot No:-" + textBox1.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(40, 455));
            e.Graphics.DrawString(d, new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(0,1000));
            e.Graphics.DrawString("Thank You", new Font("Arial", 24, FontStyle.Regular), Brushes.Black, new Point(40,1020));
            
        }
    }
}
