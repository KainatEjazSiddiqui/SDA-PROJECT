using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayReservationSystemCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "KAINAT EJAZ" || TextBox2.Text == "KAINAT")
            {
                MessageBox.Show("You are logged in successfully..");
                this.Visible = false;
                Home obj1 = new Home();
                obj1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter Valid Username and Password.");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            REGISTRATION obj1 = new REGISTRATION();
            obj1.ShowDialog();
        }
    }
}
