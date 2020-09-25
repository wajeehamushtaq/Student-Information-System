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
    public partial class PrintStdForm : Form
    {
        public PrintStdForm()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;

        private void PrintStdForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
                SqlCommand command;
                con.Open();

                if (noradioButton.Checked)
                {
                    dateTimePicker1.Enabled = false;
                    dateTimePicker2.Enabled = false;
                }

                string selectQuery = "SELECT * FROM Add_Student";
                command = new SqlCommand(selectQuery, con);
                da = new SqlDataAdapter(command);

                DataTable table = new DataTable();

                PrintdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                PrintdataGridView.RowTemplate.Height = 100;
                PrintdataGridView.AllowUserToAddRows = false;

                da.Fill(table);

                PrintdataGridView.DataSource = table;

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)PrintdataGridView.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

                               
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void noradioButton_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void gobutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            SqlCommand command;
            con.Open();

            string selectQuery;
            try
            {
                
                if (yesradioButton.Checked)
                {
                    string date1 = dateTimePicker1.Value.ToString();
                    string date2 = dateTimePicker2.Value.ToString();
                    if (maleradioButton.Checked)
                    {
                        selectQuery = "SELECT * FROM Add_Student WHERE DOB BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender='Male'";
                    }
                    else if (femaleradioButton.Checked)
                    {
                        selectQuery = "SELECT * FROM Add_Student WHERE DOB BETWEEN '" + date1 + "' AND '" + date2 + "' AND gender='Female'";

                    }
                    else
                    {
                        selectQuery = "SELECT * FROM Add_Student WHERE DOB BETWEEN '" + date1 + "' AND '" + date2 + "' ";
                    }
                    
                                    }
                else
                {
                    if (maleradioButton.Checked)
                    {
                        selectQuery = "SELECT * FROM Add_Student WHERE gender='Male'";
                    }
                    else if (femaleradioButton.Checked)
                    {
                        selectQuery = "SELECT * FROM Add_Student WHERE gender='Female'";

                    }
                    else
                    {
                        selectQuery = "SELECT * FROM Add_Student";
                    }
                }
                command = new SqlCommand(selectQuery, con);
                da = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                PrintdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                PrintdataGridView.RowTemplate.Height = 100;
                PrintdataGridView.AllowUserToAddRows = false;


                da.Fill(table);

                PrintdataGridView.DataSource = table;

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)PrintdataGridView.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void yesradioButton_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }
    }
}
