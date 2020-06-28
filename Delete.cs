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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == 0)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True"))
                {

                    string str = "SELECT * FROM TRAIN_DETAILS ";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }

            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True"))
                {

                    string str = "SELECT * FROM RESERVATION";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True"))
                {

                    string str = "SELECT * FROM CUSTOMER_COMPLAIN";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True");
                    con.Open();

                    string str = "DELETE FROM TRAIN_DETAILS WHERE id = '" + TextBox3.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(" Train Record Delete Successfully");
                    this.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Please Enter TRAIN Id..");
                }
            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True");
                    con.Open();

                    string str = "DELETE FROM RESERVATION WHERE id = '" + TextBox3.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(" Reservation Record Delete Successfully");
                    this.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Please Enter Reservation Id..");
                }
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-043P9BC\HEK;Initial Catalog=RAILWAY_MANAGEMENT_SYSTEM;Integrated Security=True");
                    con.Open();

                    string str = "DELETE FROM CUSTOMER_COMPLAIN WHERE id = '" + TextBox3.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(" Complain information Delete Successfully");
                    this.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Please Enter complain Id..");
                }
            }
        }
    }
}
