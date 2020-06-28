using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace RailwayReservationSystemCSharp
{
    public partial class REGISTRATION : Form
    {
        public REGISTRATION()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True");
            con.Open();

            try
            {
                string str = " INSERT INTO REGISTER(USERNAME,PASSWORD,EMAIL) VALUES('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(USER_ID) from REGISTER;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("New USER Information Registered Successfully..");
                    MessageBox.Show("You are logged in successfully..");
                    this.Visible = false;
                    Home obj1 = new Home();
                    obj1.ShowDialog();

                }
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
