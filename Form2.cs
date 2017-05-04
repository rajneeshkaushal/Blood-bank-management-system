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
    public partial class Form2 : Form
    {
         private string Mycon;
         private MySqlConnection connect;
        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Age_Click(object sender, EventArgs e)
        {

        }

      

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

       
      

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //database connection code
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
        //Submit button code
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                db_connection();
                MySqlCommand cmd = new MySqlCommand();
               
                cmd.CommandText= "INSERT INTO blood_donor " +
                          "(name, age,sex,blood_type,phone_no,address,city,donor_id,password) " +
                      "VALUES " +
                          "(@n, @ag, @sx, @bt,@ph,@ad,@ct,@di,@ps)";

                cmd.Parameters.AddWithValue("@n", this.textBox1.Text);
                cmd.Parameters.AddWithValue("@ag", this.textBox2.Text);
                cmd.Parameters.AddWithValue("@sx", this.comboBox3.Text);
                cmd.Parameters.AddWithValue("@bt", this.comboBox1.Text);
                cmd.Parameters.AddWithValue("@ph", this.textBox4.Text);
                cmd.Parameters.AddWithValue("@ad", this.textBox5.Text);
                cmd.Parameters.AddWithValue("@ct", this.textBox6.Text);
                cmd.Parameters.AddWithValue("@di", this.textBox3.Text);
                cmd.Parameters.AddWithValue("@ps", this.textBox7.Text);
               
               
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
               // MessageBox.Show(ex.Message);
            }
        }

       
       //Code for reset button
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            this.comboBox3.Text = string.Empty;
            this.comboBox1.Text = string.Empty;
            this.textBox4.Text = string.Empty;
            this.textBox5.Text = string.Empty;
            this.textBox3.Text = string.Empty;
            this.textBox6.Text = string.Empty;
            this.textBox7.Text = string.Empty;


          }
    }
}
