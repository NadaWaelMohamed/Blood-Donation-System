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
    public partial class HomePageDonor : Form
    {
        public static int id;
        public HomePageDonor()
        {
            InitializeComponent();
        }

        Applicationlayer obj = new Applicationlayer();
        private void button3_Click(object sender, EventArgs e)
        {
            Registeration reg = new Registeration();
            reg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Delete_Record_ID del = new Delete_Record_ID();
            del.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Update up = new Update();
            up.Show();
        }
    }
}
