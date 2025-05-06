using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Windows.Forms;
using System.Data;


using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Text;

namespace Password_Manager
{
    public partial class internalform : Form
    {
        private Point lastclick;
        private int selectedRecordId = -1; // Variable to store the selected record ID
        public internalform()
        {
            InitializeComponent();
            
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastclick = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - lastclick.X, this.Location.Y + e.Y - lastclick.Y);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblnote_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtwebsite.Text == "")
            {
                lblcheckwebsite.Text = "Please enter a website";
            }
            if (txtusername.Text == "")
            {
                lblcheckusername.Text = "Please enter a username";
            }
            if (txtpassword.Text == "")
            {
                lblcheckpassword.Text = "Please enter a password";
            }
            else
            {


                // Save the password logic here
                string conn = @"Data Source=DESKTOP-L56IBDC\SQLEXPRESS;Initial Catalog=User_Database;Integrated Security=True;Trust Server Certificate = True";
                string Website = txtwebsite.Text;
                string Username = txtusername.Text;
                string Passwords = txtpassword.Text;
                string note = txtnote.Text;
                int id = Program.userid;
                using (SqlConnection con = new SqlConnection(conn))
                {
                    con.Open();
                    string query = "INSERT INTO Passwords (Website, Username, Passwords,note,id) VALUES (@Website, @Username, @Passwords,@note,@id)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Website", txtwebsite.Text);
                        cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                        cmd.Parameters.AddWithValue("@Passwords", txtpassword.Text);
                        cmd.Parameters.AddWithValue("@note", txtnote.Text);
                        cmd.Parameters.AddWithValue("@id", Program.userid);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ClearFields();
                        LoadWebsitesToListView();
                        MessageBox.Show("Password saved successfully","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            //Data Source = DESKTOP - L56IBDC\SQLEXPRESS; Initial Catalog = User_Database; Integrated Security = True; Encrypt = True; Trust Server Certificate = True



        }
        private void ClearFields()
        {

            txtwebsite.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            txtnote.Clear();
        }


        private void btnnew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtwebsite_TextChanged(object sender, EventArgs e)
        {
            lblcheckwebsite.Text = "";
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            lblcheckusername.Text = "";
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            lblcheckpassword.Text = "";
        }
        private void LoadWebsitesToListView()
        {
            lv.Items.Clear();

            string conn = @"Data Source=DESKTOP-L56IBDC\SQLEXPRESS;Initial Catalog=User_Database;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT  id_no,Website FROM Passwords WHERE id = @UserId";

            using (SqlConnection con = new SqlConnection(conn))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@UserId", Program.userid);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Website"].ToString());
                    item.Tag = reader["id_no"];// store record id for future use
                    lv.Items.Add(item);
                }
            }
        }

        private void internalform_Load(object sender, EventArgs e)
        {
            LoadWebsitesToListView();
        }

        private void lv_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (lv.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv.SelectedItems[0];
                 selectedRecordId = Convert.ToInt32(selectedItem.Tag);

                string conn = @"Data Source=DESKTOP-L56IBDC\SQLEXPRESS;Initial Catalog=User_Database;Integrated Security=True;TrustServerCertificate=True";
                string query = "SELECT Website, Username, Passwords, note FROM Passwords WHERE id_no = @Id";

                using (SqlConnection con = new SqlConnection(conn))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", selectedRecordId);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtwebsite.Text = reader["Website"].ToString();
                        txtusername.Text = reader["Username"].ToString();
                        txtpassword.Text = reader["Passwords"].ToString();
                        txtnote.Text = reader["note"].ToString();
                    }
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (lv.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                             "Confirm Delete",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    ListViewItem selectedItem = lv.SelectedItems[0];
                    int selectedRecordId = Convert.ToInt32(selectedItem.Tag);

                    string conn = @"Data Source=DESKTOP-L56IBDC\SQLEXPRESS;Initial Catalog=User_Database;Integrated Security=True;TrustServerCertificate=True";
                    string query = "DELETE FROM Passwords WHERE id_no = @Id";

                    using (SqlConnection con = new SqlConnection(conn))
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", selectedRecordId);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    lv.Items.Remove(selectedItem);
                   
                    LoadWebsitesToListView();
                    ClearFields();


                }
                else
                {
                    MessageBox.Show("Delete cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
         
            if (selectedRecordId == -1)
            {
                MessageBox.Show("Select a record to update.");
                return;
            }

            string conn = @"Data Source=DESKTOP-L56IBDC\SQLEXPRESS;Initial Catalog=User_Database;Integrated Security=True;TrustServerCertificate=True";
            string query = "UPDATE Passwords SET Website=@Website, Username=@Username, Passwords=@Passwords, note=@note WHERE id_no=@Id";

            using (SqlConnection con = new SqlConnection(conn))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Website", txtwebsite.Text);
                cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                cmd.Parameters.AddWithValue("@Passwords", txtpassword.Text);
                cmd.Parameters.AddWithValue("@note", txtnote.Text);
                cmd.Parameters.AddWithValue("@Id", selectedRecordId);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(" Record updated","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ClearFields();
            selectedRecordId = -1; // Reset the selected record ID
            LoadWebsitesToListView();
        }

    }
}



