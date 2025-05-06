using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Password_Manager;
namespace Password_Manager
{
    public partial class Form2 : Form
    {
        private Point lastclick;



        public Form2()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblcheckphone.Text = "";
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            string gender = "";



            if (rdomale.Checked)
            {
                gender = "Male";
            }
            else if (rdofemale.Checked)
            {
                gender = "Female";
            }

            if (txtusername.Text == "")
            {
                lblcheckusername.Text = "Please enter a username";
                isValid = false;
            }
            else if (txtusername.Text.Length < 5)
            {
                lblcheckusername.Text = "Username must be at least 5 characters long";
                isValid = false;
            }
            else if (txtusername.Text.Length > 15)
            {
                lblcheckusername.Text = "Username must be less than 15 characters long";
                isValid = false;
            }
            else
            {
                lblcheckusername.Text = "";
            }
            if (txtemail.Text == "")
            {
                lblcheckemail.Text = "Please enter an email";
                isValid = false;

            }
            else
            {
                lblcheckemail.Text = "";
            }
            if (txtpassword.Text == "")
            {
                lblcheckpassword.Text = "Please enter a password";
                isValid = false;
            }
            else if (txtpassword.Text.Length < 8)
            {
                lblcheckpassword.Text = "Password must be at least 8 characters long";
                isValid = false;
            }

            else
            {
                lblcheckpassword.Text = "";
            }
            if (txtphone.Text == "" || cbophone.SelectedIndex == -1)
            {
                lblcheckphone.Text = "Please enter a phone number";
                isValid = false;
            }
            else
            {
                string Fullphone = cbophone.SelectedItem.ToString() + txtphone.Text;

                lblcheckphone.Text = "";
            }
            if (rdomale.Checked == false && rdofemale.Checked == false)
            {
                lblcheckgender.Text = "Please Select a gender ";
                isValid = false;
            }
            else
            {
                lblcheckgender.Text = "";
            }
            if (cbocountry.SelectedIndex == -1)
            {
                lblcheckcountry.Text = "Please select a country";
                isValid = false;
            }
            else
            {
                lblcheckcountry.Text = "";
            }
            if (isValid)
            {
                //  string constring = @"Data Source=DESKTOP-L56IBDC\SQLEXPRESS;Initial Catalog=User_Database;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection con = new SqlConnection("Server=DESKTOP-L56IBDC\\SQLEXPRESS; DataBase=User_Database; Integrated Security=true;Trust Server Certificate=True");
                //insert into Registration_form (name,Email,Password, phone,gender,country,countrycode) values('a','a','aad','ad','male','afda','ada')
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO[dbo].[Registration_form]
            ([username]
           , [email]
           , [password]
           , [phone]
           , [gender]
           , [country]
            ,[country_code])
     VALUES
           ('" + txtusername.Text + "','" + txtemail.Text +
           "','" + txtpassword.Text + "','" + txtphone.Text +
           "','" + gender + "','" + cbocountry.SelectedItem.ToString()
           + "','" + cbophone.SelectedItem.ToString() + "')",
                    con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inserted Successfully","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtusername.Text = "";
                txtemail.Text = "";
                txtpassword.Text = "";
                txtphone.Text = "";
                cbocountry.SelectedIndex = -1;
                cbophone.SelectedIndex = -1;
                rdomale.Checked = false;
                rdofemale.Checked = false;
                checkBox1.Checked = false;




                // SqlCommand sql = new SqlCommand(@"Insert Into Registration_form (Username,Email,Phone,password,gender,country,country_code) values ('"+txtusername.Text+"','"+txtemail.Text+"','"+txtphone.Text+"','");

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblcheckusername_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            lblcheckusername.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - lastclick.X, this.Location.Y + e.Y - lastclick.Y);
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            lblcheckemail.Text = "";
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            lblcheckpassword.Text = "";
        }
    }
}
