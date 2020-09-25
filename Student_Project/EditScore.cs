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
    public partial class EditScore : Form
    {
        public EditScore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            con.Open();
            SqlCommand command;
            try
            {
                string sql = "SELECT Std_id,Course_Id,obtain_score,Total_score,sc_description FROM Scores WHERE score_id='" + textBoxscoreid.Text + "'";
                if (con.State != ConnectionState.Open)
                    con.Open();
                command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textBoxstdid.Text = reader[0].ToString();
                    textBoxcourseid.Text = reader[1].ToString();
                    textBoxobtmarks.Text = reader[2].ToString();
                    textBoxtotalmarks.Text = reader[3].ToString();
                    textBoxdescrp.Text = reader[4].ToString();
                }
                else {
                    MessageBox.Show("There are no records");
                }
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
                string Query = "Update Scores Set Std_id=@a,Course_Id=@b,obtain_score=@c, Total_score=@d,sc_description=@e where score_id='" + textBoxscoreid.Text + "'";
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@a", textBoxstdid.Text);
                cmd.Parameters.AddWithValue("@b", textBoxcourseid.Text);
                cmd.Parameters.AddWithValue("@c", textBoxobtmarks.Text);
                cmd.Parameters.AddWithValue("@d", textBoxtotalmarks.Text);
                cmd.Parameters.AddWithValue("@e", textBoxdescrp.Text);




                //cmd.Parameters.AddWithValue("@imge", pictureBox1);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student's record has been updated successfully!!");

                textBoxscoreid.Focus();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
