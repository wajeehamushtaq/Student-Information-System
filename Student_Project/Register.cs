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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            SqlCommand command;
            try
            {

                if (courseidtextBox.Text != "")
                {


                    string sql = "INSERT INTO Registration(Std_id,Course_id) values('" + stdIdtextBox.Text + "','" + courseidtextBox.Text + "')";
                    if (con.State != ConnectionState.Open)
                        con.Open();

                    command = new SqlCommand(sql, con);
                    
                    int x = command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(x.ToString() + "record(s) saved");
                    courseidtextBox.Text = "";
                    stdIdtextBox.Text = "";
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
    }
}
