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
    public partial class Form4 : Form
    {
        private string Mycon;
        private MySqlConnection connect;
        public Form4()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                db_connection();
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "INSERT INTO orders " +
                          "(order_id,blood_type,quantity) " +
                      "VALUES " +
                          "(@oi, @bt, @qt)";

                cmd.Parameters.AddWithValue("@oi", this.textBox1.Text);
                cmd.Parameters.AddWithValue("@bt", this.comboBox1.Text);
                cmd.Parameters.AddWithValue("@qt", this.comboBox2.Text);
               


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
    }
}
