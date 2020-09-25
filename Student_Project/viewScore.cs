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
    public partial class viewScore : Form
    {
        public viewScore()
        {
            InitializeComponent();
        }

        SqlDataAdapter da;
        private void c_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            SqlCommand command;
            con.Open();

            string selectQuery;
            try
            {
                    selectQuery = "SELECT * FROM Scores WHERE Std_id='" + stdtextBox.Text + "'";


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

        private void findbutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            SqlCommand command;
            con.Open();

            string selectQuery;
            try
            {
                selectQuery = "SELECT * FROM Scores WHERE Course_Id='" + courseidtextBox.Text + "' ORDER BY obtain_score";


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

        private void viewScore_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            SqlCommand command;
            con.Open();
            try
            { 
            string selectQuery = "SELECT * FROM Scores";
            command = new SqlCommand(selectQuery, con);
            da = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            PrintdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PrintdataGridView.RowTemplate.Height = 100;
            PrintdataGridView.AllowUserToAddRows = false;

            da.Fill(table);

            PrintdataGridView.DataSource = table;

            da.Dispose();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
    }
}
