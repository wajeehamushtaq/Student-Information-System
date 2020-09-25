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
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }

        

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
                SqlCommand command;
                con.Open();

                string selectQuery = "SELECT * FROM Add_Student";
                command = new SqlCommand(selectQuery, con);
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                StdListdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                StdListdataGridView.RowTemplate.Height = 100;
                StdListdataGridView.AllowUserToAddRows = false;

                da.Fill(table);

                StdListdataGridView.DataSource = table;

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)StdListdataGridView.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                da.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
