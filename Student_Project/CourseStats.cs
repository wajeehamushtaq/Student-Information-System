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
    public partial class CourseStats : Form
    {
        public CourseStats()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        private void findbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            SqlCommand command;
            con.Open();

            string selectQuery;
            try
            {
                selectQuery = "SELECT S.id, S.First_Name FROM Add_Student S INNER JOIN Registration R ON S.id = R.Std_id WHERE Course_Id='" + courseidtextBox.Text+"'";


                command = new SqlCommand(selectQuery, con);
                da = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                PrintdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                PrintdataGridView.RowTemplate.Height = 100;
                PrintdataGridView.AllowUserToAddRows = false;


                da.Fill(table);

                PrintdataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            SqlCommand command;
            con.Open();

            string selectQuery;
            try
            {
                selectQuery = "SELECT Registration.Course_Id,Courses.Course_Name,COUNT(Registration.Std_id) AS NoOfStudent FROM Registration INNER JOIN Courses ON Registration.Course_ID = Courses.Course_ID GROUP BY Registration.Course_ID, Courses.Course_Name; ";
                command = new SqlCommand(selectQuery, con);
                da = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                PrintdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                PrintdataGridView.RowTemplate.Height = 100;
                PrintdataGridView.AllowUserToAddRows = false;


                da.Fill(table);

                PrintdataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
