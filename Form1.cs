using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Password_Manager;

namespace Password_Manager
{
    public partial class Form1 : Form
    {
        private Point lastClick;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnsubmit_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                lblcheckUsername.Text = "Please enter a username";
            }
            if (txtpassword.Text == "")
            {
                lblcheckemail.Text = "Please enter an Password";
            }
            else
            {

                string constring = @"Data Source=DESKTOP-abc\SQLEXPRESS;Initial Catalog=User_Database;Integrated Security=True;Trust Server Certificate=True";
                SqlConnection con = new SqlConnection(constring);

                string query = "SELECT id FROM Registration_form WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    Program.userid = Convert.ToInt32(dt.Rows[0]["id"]);
                    internalform form = new internalform();
                    this.Hide();
                    form.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // SqlCommand cmd = new SqlCommand(query, con);
            // con.Open();

            //int count = (int)cmd.ExecuteScalar();

            //if (count > 0)


            // con.Close();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titlepanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastClick = e.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void titlepanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - lastClick.X, this.Location.Y + e.Y - lastClick.Y);
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            lblcheckUsername.Text = "";
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            lblcheckemail.Text = "";
        }
    }
}
