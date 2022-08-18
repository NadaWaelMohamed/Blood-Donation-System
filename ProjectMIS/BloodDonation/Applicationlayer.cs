using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BloodDonation
{
    class Applicationlayer
    {
  

        //insert in donor

        public void Regist(int D_id ,string D_name, string D_gender, string D_age, string D_email, string D_phone, string D_bloodtype, string D_region)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Blood_Donation;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into Donor (D_name,D_gender,D_age,D_email,D_phone,D_bloodtype,D_region) values(@name,@gender,@age,@email,@phone,@bloodtype,@region)" , con);
        

           SqlParameter parameter = new SqlParameter("@name", D_name);
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter("@gender", D_gender);
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter("@age", D_age);
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter("@email", D_email);
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter("@phone", D_phone);
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter("@bloodtype", D_bloodtype);
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter("@region", D_region);
            cmd.Parameters.Add(parameter);
          
            cmd.ExecuteNonQuery();

        }
        //insert in patient
        public void RegistPatient(int p_id, string p_name, string p_gender, string p_age, string p_email, string p_phone, string p_bloodtype, string p_region ,string H_name)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Blood_Donation;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"insert into Patient (p_name,p_gender,p_age,p_email,p_phone,p_bloodtype,p_region,H_name) values(@name,@gender,@age,@email,@phone,@bloodtype,@region,@hospital)", con);
            

             SqlParameter parameter = new SqlParameter("@name", p_name);
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter("@gender", p_gender);
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter("@age", p_age);
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter("@email", p_email);
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter("@phone", p_phone);
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter("@bloodtype", p_bloodtype);
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter("@region", p_region);
            cmd.Parameters.Add(parameter);
            parameter = new SqlParameter("@hospital", H_name);
            cmd.Parameters.Add(parameter);
          
            cmd.ExecuteNonQuery();

        }















        //update phone in donor


        public void UpdatePhone( string D_email, string D_phone)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Blood_Donation;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"update Donor set D_phone=@phone where D_email=@email ", con);

            SqlParameter parameter = new SqlParameter("@phone", D_phone);
            cmd.Parameters.Add(parameter);

           

            parameter = new SqlParameter("@email", D_email);
            cmd.Parameters.Add(parameter);

           
            cmd.ExecuteNonQuery();

        }

        //update phone in patient
        public void UpdatePhonePatient(string p_email, string p_phone)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Blood_Donation;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"update Patient set p_phone=@phone where p_email=@email ", con);

            SqlParameter parameter = new SqlParameter("@phone", p_phone);
            cmd.Parameters.Add(parameter);



            parameter = new SqlParameter("@email", p_email);
            cmd.Parameters.Add(parameter);

           
            cmd.ExecuteNonQuery();

        }

        //donor delete
        public void delete( int D_ID)
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Blood_Donation;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Delete from Donor where D_ID=@id ", con);

            SqlParameter parameter = new SqlParameter("@id", D_ID);
            cmd.Parameters.Add(parameter);

        
            
            cmd.ExecuteNonQuery();
      

        }
        //patient delete
        public void deletePatient(int p_ID)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Blood_Donation;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Delete from Patient where p_id=@id  ", con);

            SqlParameter parameter = new SqlParameter("@id", p_ID);
            cmd.Parameters.Add(parameter);

            cmd.ExecuteNonQuery();
       
           

        }













        public List<string> GetBloodBanksNames()
        {
            try
            {
                List<string> BloodBankNames = new List<string>();
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Blood_Donation;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from bloodbank ", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    BloodBankNames.Add((string)(rdr["B_name"]));

                }



                return BloodBankNames;
            }
            catch
            {
                return null;
            }

        }



      
       

       

      




        public List<string> GetHospitalNames()
        {
            try
            {
                List<string> HospitalNames = new List<string>();
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Blood_Donation;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Hospital ", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    HospitalNames.Add((string)(rdr["H_name"]));

                }



                return HospitalNames;
            }
            catch
            {
                return null;
            }
        }

      
        public void Store(String D_email , string B_name)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Blood_Donation;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select B_id from bloodbank where B_name = @Blood_name  ", con);
            SqlParameter parameter = new SqlParameter("@Blood_name", B_name);
            cmd.Parameters.Add(parameter);
            SqlDataReader rdr = cmd.ExecuteReader();
            int Bb_id = 0;
            while (rdr.Read())
            {
                
                 Bb_id = rdr.GetInt32(rdr.GetOrdinal("B_id"));
                
                  
            }


            rdr.Close();


        

            SqlCommand cmdSelect = new SqlCommand("select D_ID from Donor where D_email=@email ", con);
         
            parameter = new SqlParameter("@email", D_email);
            cmdSelect.Parameters.Add(parameter);
            SqlDataReader rdrSelect = cmdSelect.ExecuteReader();
         
            int Do_id=0;
            while (rdrSelect.Read())
            {

                 Do_id= rdrSelect.GetInt32(rdrSelect.GetOrdinal("D_ID"));


            }
            rdrSelect.Close();


      
            SqlCommand cmdInsert   = new SqlCommand(@"insert into store (D_id,B_id,medicalreport,quantity)values(@Do_id,@Bb_id,NULL,NULL)", con);
             parameter = new SqlParameter("@Do_id", Do_id);
            cmdInsert.Parameters.Add(parameter);
            parameter = new SqlParameter("@Bb_id", Bb_id);
            cmdInsert.Parameters.Add(parameter);

            cmdInsert.ExecuteNonQuery();


        }
        public void Contact(String p_email, string B_name)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Blood_Donation;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select B_id from bloodbank where B_name = @Blood_name  ", con);
            SqlParameter parameter = new SqlParameter("@Blood_name", B_name);
            cmd.Parameters.Add(parameter);
            SqlDataReader rdr = cmd.ExecuteReader();
            int Bb_id = 0;
            while (rdr.Read())
            {

                Bb_id = rdr.GetInt32(rdr.GetOrdinal("B_id"));


            }


            rdr.Close();




            SqlCommand cmdSelect = new SqlCommand("select p_id from Patient where p_email=@email ", con);

            parameter = new SqlParameter("@email", p_email);
            cmdSelect.Parameters.Add(parameter);
            SqlDataReader rdrSelect = cmdSelect.ExecuteReader();

            int patient_ID = 0;
            while (rdrSelect.Read())
            {

                patient_ID = rdrSelect.GetInt32(rdrSelect.GetOrdinal("p_id"));


            }
            rdrSelect.Close();


           
            SqlCommand cmdInsert = new SqlCommand(@"insert into contact (P_ID,B_id)values(@patient_ID,@Bb_id)", con);
            parameter = new SqlParameter("@patient_id", patient_ID);
            cmdInsert.Parameters.Add(parameter);
            parameter = new SqlParameter("@Bb_id", Bb_id);
            cmdInsert.Parameters.Add(parameter);

            cmdInsert.ExecuteNonQuery();


        }








    }

}
