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
    public partial class UpdateCourse : Form
    {
        public UpdateCourse()
        {
            InitializeComponent();
        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            con.Open();
            SqlCommand command;
            try
            {
                string sql = "SELECT Course_Name,Credit_Hours,Course_Description FROM Courses WHERE Course_Id='" + courseidtextBox.Text + "'";
                if (con.State != ConnectionState.Open)
                    con.Open();
                command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    courseNametextBox.Text = reader[0].ToString();
                    descriptiontextBox.Text = reader[2].ToString();


                    if (reader[1].ToString() == "1")
                    {
                        radioButton1.Checked = true;


                    }
                    else if (reader[1].ToString() == "2")
                    {
                        radioButton2.Checked = true;
                    }
                    else if (reader[1].ToString() == "3")
                    {
                        radioButton3.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("There are no records");
                        //con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

            string crd = "";
        private void updateCoursebutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
                string Query = "Update Courses Set Course_Name=@a,Credit_Hours=@b,Course_Description=@c where Course_Id=@sid";
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@sid", courseidtextBox.Text);
                cmd.Parameters.AddWithValue("@a", courseNametextBox.Text);
                cmd.Parameters.Add(new SqlParameter("@b", crd));
                cmd.Parameters.AddWithValue("@c", descriptiontextBox.Text);


                //cmd.Parameters.AddWithValue("@imge", pictureBox1);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student's record has been updated successfully!!");

                courseidtextBox.Focus();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            crd = "1";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            crd = "2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            crd = "3";
        }
    }
}