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
    public partial class LogIn : Form
    {
        public static int id;
        public LogIn()
        {
            InitializeComponent();
        }
        Applicationlayer obj = new Applicationlayer();
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
          

        }
     
      



        private void button2_Click(object sender, EventArgs e)
        {

             Delete_Record_ID del = new Delete_Record_ID();
             del.Show();
          

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginPatient pat = new LoginPatient();
            pat.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            
          
            DeletePatient del = new DeletePatient();
            del.Show();
           
        }

     

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

       

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            HomePageDonor Donor_Home = new HomePageDonor();
            Donor_Home.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            HomePagePatient Patient_Home = new HomePagePatient();
            Patient_Home.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            HomePageDonor Donor_Home = new HomePageDonor();
            Donor_Home.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            HomePagePatient Patient_Home = new HomePagePatient();
            Patient_Home.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
