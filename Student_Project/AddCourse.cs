using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
{
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        string credithrs = "";
        private void addCoursebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            SqlCommand command;
            try
            {

                if (courseidtextBox.Text.ToString() != "")
                {


                    string sql = "INSERT INTO Courses VALUES('" + courseidtextBox.Text + "','" + courseNametextBox.Text + "',@g,'" + descriptiontextBox.Text + "')";
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    command = new SqlCommand(sql, con);
                    command.Parameters.Add(new SqlParameter("@g", credithrs));


                    int x = command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(x.ToString() + "record(s) saved");
                    courseidtextBox.Text = "";
                    courseNametextBox.Text = "";
                    descriptiontextBox.Text = "";
                }
            else
                {
                    MessageBox.Show("Empty record not entered");
                }
                
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            credithrs = "1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            credithrs = "2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            credithrs = "3";
        }
    }
}
