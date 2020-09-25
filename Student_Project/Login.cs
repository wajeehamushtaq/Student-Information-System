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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Log_In where username='" + textBoxUsername.Text + "' and u_password='" + textBoxPassword.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue = comboBox1.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("You are successfully login!!");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][6].ToString() == cmbItemValue)
                    {
                        MessageBox.Show("You are successfully login!!" + dt.Rows[i][6]);
                        if (comboBox1.SelectedIndex == 0)
                        {
                            AdminDashboard f = new AdminDashboard();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            StudentDashboard w = new StudentDashboard();
                            w.Show();
                            this.Hide();
                        }
                    }
                    //MessageBox.Show("therer");
                }

            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("admin");
            comboBox1.Items.Add("student");
            // set image 
            logopictureBox.Image = Image.FromFile("../../images/CSEdptLogoWhite.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpForm sgn = new SignUpForm();
            sgn.Show(this);
        }
    }
}
