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
    public partial class Delete_Record_ID : Form
    {
        public Delete_Record_ID()
        {
            InitializeComponent();
        }

        Applicationlayer obj = new Applicationlayer();
        private void button1_Click(object sender, EventArgs e)
        {

            int id = Int32.Parse(textBox1.Text);
            obj.delete(id);
            MessageBox.Show("Deleted Successfully");
           

        }
    }
}
