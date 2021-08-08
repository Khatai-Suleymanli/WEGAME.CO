using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WeGameregitserpage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R7QM90G/SQLEXPRESS;Initial Catalog=userregcs;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[register]
           ([firstname]
           ,[lastname]
           ,[country]
           ,[gender]
           ,[email]
           ,[phone]
           ,[username]
           ,[password]
           ,[steamid]
           ,[pstid])
     VALUES
           ('"+txtfname.Text+"','"+txtLname.Text+"','"+txtCountry.Text+"','"+cmbgender.SelectedItem.ToString()+"','"+txtemail.Text+"','"+txtphone.Text+"','"+txtusername.Text+"','"+txtpassword.Text+"','"+txtsteamid.Text+"','"+txtpstid.Text+"')", con)
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("registered successfully");
        }
    }
}
