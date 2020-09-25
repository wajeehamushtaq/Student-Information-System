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
    public partial class RemoveCourse : Form
    {
        public RemoveCourse()
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
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                finddataGridView.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    //string Course_ID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string Course_Name = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string Credit_Hours = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string Course_Description = ds.Tables[0].Rows[i].ItemArray[2].ToString();

                    DataGridViewRow abc = new DataGridViewRow();
                    finddataGridView.ColumnCount = 3;
                    abc.CreateCells(finddataGridView);
                    //abc.Cells[0].Value = Course_ID;
                    abc.Cells[0].Value = Course_Name;
                    abc.Cells[1].Value = Credit_Hours;
                    abc.Cells[2].Value = Course_Description;
                    finddataGridView.Rows.Add(abc);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            con.Open();
            
            SqlCommand cmd = new SqlCommand("delete from Courses where Course_Id=@a", con);
            cmd.Parameters.AddWithValue("@a", courseidtextBox.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
        }
    }
}
