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
    public partial class UpdateDelStd : Form
    {
        public UpdateDelStd()
        {
            InitializeComponent();
        }

        string gendr = "";
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string imgloc = "";
                byte[] img = null;
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Student Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgloc;
                }
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);

                SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
                string Query = "Update Add_Student Set First_Name=@a,Last_Name=@b,DOB=@c,gender=@d,phone=@e,std_address =@f,stdImage= @imge where id=@sid";
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@sid", idtextBox.Text);
                cmd.Parameters.AddWithValue("@a", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@b", textBoxlastname.Text);
                cmd.Parameters.AddWithValue("@c", dateTimePicker1.Value);
                cmd.Parameters.Add(new SqlParameter("@d", gendr));
                // cmd.Parameters.AddWithValue("@d", );
                cmd.Parameters.AddWithValue("@e", textBoxphone.Text);
                cmd.Parameters.AddWithValue("@f", textBoxaddress.Text);
                cmd.Parameters.Add(new SqlParameter("@imge", img));
                
                //cmd.Parameters.AddWithValue("@imge", pictureBox1);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Student's record has been updated successfully!!");

                textBoxFirstName.Focus();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void findbutton_Click(object sender, EventArgs e)
        {
          
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            con.Open();
            SqlCommand command;
            try
            {
                string sql = "SELECT First_Name,Last_Name,DOB,gender,phone,std_address,stdImage FROM Add_Student WHERE id=" + idtextBox.Text + "";
                if (con.State != ConnectionState.Open)
                    con.Open();
                command = new SqlCommand(sql, con);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    textBoxFirstName.Text = reader[0].ToString();
                    textBoxlastname.Text = reader[1].ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(reader[2]);
                    textBoxphone.Text = reader[4].ToString();
                    textBoxaddress.Text = reader[5].ToString();

                    if (reader[3].ToString() == "Male")
                    {
                        radioButtonmale.Checked = true;


                    }
                    else if (reader[3].ToString() == "Female")
                    {
                        radioButtonfemale.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("There are no records");
                        //con.Close();
                    }


                    byte[] img = (byte[])(reader[6]);
                    if (img == null)
                        pictureBox1.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }

                }
                else
                {
                    MessageBox.Show("This is not exist");
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonupload_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            SqlCommand command;
            string imgloc = "";
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Student Picture";
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

        private void removebutton_Click(object sender, EventArgs e)
        {
            String st = "DELETE FROM Add_Student WHERE id =" + idtextBox.Text;
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            SqlCommand sqlcom = new SqlCommand(st, con);
            con.Open();
            try
            {
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("delete successful");
                con.Close();
            }
            catch (SqlException ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
