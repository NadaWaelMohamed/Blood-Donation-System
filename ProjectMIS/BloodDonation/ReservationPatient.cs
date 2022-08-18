using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace BloodDonation
{
    public partial class ReservationPatient : Form
    {
        public ReservationPatient()
        {
            InitializeComponent();
        }

        Applicationlayer obj = new Applicationlayer();
        private void button1_Click(object sender, EventArgs e)
        {
       
            int p_id = LoginPatient.id;
            String name = txtname.Text;
            String gender = txtGender.Text;
            String age = txtAge.Text;
            String email = txtEmail.Text;
            String phone = txtPhone.Text;
            String Bloodtype = txtBloodType.Text;
            String region = txtRegion.Text;
            String Hospital = txtHospital.Text;
            string bank_name = (comboBox1.SelectedItem).ToString();
            obj.RegistPatient(p_id, name, gender, age, email, phone, Bloodtype, region,Hospital);
            obj.Contact(email, bank_name);
            MessageBox.Show("Registeration done ");
        }

        private void ReservationPatient_Load(object sender, EventArgs e)
        {
           
            listBox2.DataSource = obj.GetHospitalNames();
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Blood_Donation;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from bloodbank", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                string name = (string)rdr["B_name"];
                comboBox1.Items.Add(name);

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
