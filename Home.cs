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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Train obj = new Train();
            obj.ShowDialog();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservation obj1 = new Reservation();
            obj1.ShowDialog();
        }

        private void customerCareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerComplain obj2 = new CustomerComplain();
            obj2.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete obj3 = new Delete();
            obj3.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports obj4 = new Reports();
            obj4.ShowDialog();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tRACKINGRECORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TRACKING_RECORD obj4 = new TRACKING_RECORD();
            obj4.ShowDialog();
        }
    }
}
