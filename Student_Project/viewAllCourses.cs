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
    public partial class viewAllCourses : Form
    {
        public viewAllCourses()
        {
            InitializeComponent();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewAllCourses_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
                SqlCommand command;
                con.Open();

                string selectQuery = "SELECT * FROM Courses";
                command = new SqlCommand(selectQuery, con);
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                coursesdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                coursesdataGridView.RowTemplate.Height = 100;
                coursesdataGridView.AllowUserToAddRows = false;

                da.Fill(table);

                coursesdataGridView.DataSource = table;

                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
