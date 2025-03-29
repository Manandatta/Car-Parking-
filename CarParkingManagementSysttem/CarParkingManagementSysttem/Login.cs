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
    public partial class Login : Form
    {
        string query = "";
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        int count;
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection connect = new OleDbConnection();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PDF\B.C.A-5\PROJECT\Project.accdb";
            connect.Open();


            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "select UserName,Password from Login";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                if (textBox1.Text == reader[0].ToString() && textBox2.Text == reader[1].ToString())
                {


                    this.Hide();
                    Homepage hp = new Homepage();
                    hp.Show();
                    break;

                }
                else if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("Enter Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else
                {
                    MessageBox.Show("Your user ID or password is incorrect.");
                    textBox1.Clear();
                    textBox2.Clear();
                }


            }

                
            count = count + 1;

            if (count > 3)
            {
                MessageBox.Show("System has been blocked");
                Application.Exit();
            }


        }
    }
}
