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
using System.IO;

namespace Student_Project
{
    public partial class AddStudentForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
        SqlCommand command;
        string imgloc = "";

        public AddStudentForm()
        {
            InitializeComponent();
        }

        string gendr = "";      
        // add student button
        private void buttonaddstd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxFirstName.Text != "" && textBoxlastname.Text != "" && textBoxphone.Text != "" && textBoxaddress.Text != "" )
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    string sql = "INSERT INTO Add_Student(First_Name ,Last_Name,DOB,gender,phone,std_address,stdImage)VALUES('" + textBoxFirstName.Text + "','" + textBoxlastname.Text + "','" + dateTimePicker1.Value + "',@g,'" + textBoxphone.Text + "','" + textBoxaddress.Text + "', @img)";
                    if (con.State != ConnectionState.Open)
                        con.Open();



                    command = new SqlCommand(sql, con);
                    command.Parameters.Add(new SqlParameter("@g", gendr));
                    command.Parameters.Add(new SqlParameter("@img", img));

                    int x = command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(x.ToString() + "record(s) saved");
                    textBoxFirstName.Text = "";
                    textBoxlastname.Text = "";
                    //dateTimePicker1.Value = ;
                    textBoxphone.Text = "";
                    textBoxaddress.Text = "";
                    pictureBox1.Image = null;

                }
                else {
                    MessageBox.Show("Any field should not left be empty");
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }


        }



        private void buttoncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonupload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Employee Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgloc;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonmale_CheckedChanged(object sender, EventArgs e)
        {
            gendr = "Male"; 
        }

        private void radioButtonfemale_CheckedChanged(object sender, EventArgs e)
        {
            gendr = "Female";
        }
    }
}
