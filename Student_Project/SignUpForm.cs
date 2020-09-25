using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
{
    public partial class SignUpForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
        SqlCommand command;
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            //set image 
            logopictureBox.Image = Image.FromFile("../../images/CSEdptLogoWhite.png");

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        string type = "";
        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if(nametextBox.Text!= null && emailtextBox.Text!=null && cnictextBox.Text != null && phonetextBox.Text!=null && usernametextBox.Text!=null && passwordtextBox.Text!=null)
                {
                string sql = "INSERT INTO Log_In VALUES('" + nametextBox.Text + "','" + emailtextBox.Text + "','" + cnictextBox.Text + "','" + phonetextBox.Text + "','" + usernametextBox.Text + "','" + passwordtextBox.Text + "', @g)";
                if (con.State != ConnectionState.Open)
                    con.Open();

                command = new SqlCommand(sql, con);
                command.Parameters.Add(new SqlParameter("@g", type));

                int x = command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "record(s) saved");
                nametextBox.Text = "";
                emailtextBox.Text = "";
                cnictextBox.Text = "";
                phonetextBox.Text = "";
                usernametextBox.Text = "";
                passwordtextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("There should be not any empty field");
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonadmin_CheckedChanged(object sender, EventArgs e)
        {
            type = "admin";
        }

        private void radioButtonStudent_CheckedChanged(object sender, EventArgs e)
        {
            type = "student";
        }
    }
}
