using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Student_Project
{
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            SqlCommand command;
            try
            {
                if (textBoxstdId.Text.ToString() != "" && textBoxcourseId.Text!="" && textBoxobtmarks.Text!="" && textBoxtotalmarks.Text != "" )
                {


                    string sql = "INSERT INTO Scores(Std_id,Course_Id,obtain_score,Total_score,sc_description) VALUES('" + textBoxstdId.Text + "','" + textBoxcourseId.Text + "', '" + textBoxobtmarks.Text + "','" + textBoxtotalmarks.Text + "','" + textBoxdescrip.Text + "')";
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    command = new SqlCommand(sql, con);

                    int x = command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(x.ToString() + "record(s) saved");
                    textBoxstdId.Text = "";
                    textBoxcourseId.Text = "";
                    textBoxobtmarks.Text = "";
                    textBoxtotalmarks.Text = "";
                    textBoxdescrip.Text = "";
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

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
