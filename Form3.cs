using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BLOOD_BANK_MANAGEMENT_SYSTEM
{
    public partial class Form3 : Form
    {
        private string Mycon;
        private MySqlConnection connect;
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void db_connection()
        {
            try
            {
                Mycon = "server=localhost;user id=root;password=GLOOMBLOOMboomporn@111;database=Bloodbank";
                this.connect = new MySqlConnection(Mycon);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                db_connection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "INSERT INTO recepient " +
                          "(name, age,sex,rec_id,blood_type,city,date_of_req,phone_no) " +
                      "VALUES " +
                          "(@n, @ag, @sx, @ri,@bt,@ct,@dt,@ph)";

                cmd.Parameters.AddWithValue("@n", this.textBox1.Text);
                cmd.Parameters.AddWithValue("@ag", this.textBox2.Text);
                cmd.Parameters.AddWithValue("@sx", this.comboBox1.Text);
                cmd.Parameters.AddWithValue("@ri", this.textBox3.Text);
                cmd.Parameters.AddWithValue("@bt", this.comboBox2.Text);
                cmd.Parameters.AddWithValue("@ct", this.textBox4.Text);
                cmd.Parameters.AddWithValue("@dt", this.dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@ph", this.textBox5.Text);
      
                cmd.Connection = connect;
                MySqlDataReader login = cmd.ExecuteReader();
                MySqlDataReader isis;
                connect.Open();
                isis = cmd.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                
                while (isis.Read())
                {
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                 //MessageBox.Show("");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            this.comboBox1.Text = string.Empty;
            this.textBox3.Text = string.Empty;
            this.comboBox2.Text = string.Empty;
            this.textBox4.Text = string.Empty;
            this.dateTimePicker1.Value = DateTime.Today.AddYears(-2);
            this.textBox5.Text = string.Empty;
           

        }

        private void textBox3_TextChanged(object sender,EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
