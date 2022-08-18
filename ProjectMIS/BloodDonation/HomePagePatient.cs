using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BloodDonation
{
    public partial class HomePagePatient : Form
    {
        public HomePagePatient()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ReservationPatient reg = new ReservationPatient();
            reg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DeletePatient del = new DeletePatient();
            del.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdatePatient up = new UpdatePatient();
            up.Show();
        }
    }
}
