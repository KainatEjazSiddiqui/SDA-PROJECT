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
    public partial class PASSENGERS : Form
    {
        public PASSENGERS()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True"))
                {

                    string str = "SELECT * FROM STATIONS WHERE Id = '" + comboBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True"))
                {

                    string str = "SELECT * FROM TRAIN_SCHEDULE WHERE Id = '" + comboBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True"))
                {

                    string str = "SELECT * FROM PASSENGERS WHERE Id = '" + comboBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True"))
                {

                    string str = "SELECT * FROM TRAIN WHERE Id = '" + comboBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True"))
                {

                    string str = "SELECT * FROM STATIONS ";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True"))
                {

                    string str = "SELECT * FROM TRAIN_SHEDULES";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True"))
                {

                    string str = "SELECT * FROM PASSENGERS";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True"))
                {

                    string str = "SELECT * FROM TRAIN";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
        }
    }
}
