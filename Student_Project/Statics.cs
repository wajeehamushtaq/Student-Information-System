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
    public partial class Statics : Form
    {
        public Statics()
        {
            InitializeComponent();
        }


        private string execCount(string query)
        {
            SqlConnection con = new SqlConnection("Data Source=WAJEEHA\\SQLEXPRESS;Initial Catalog=StudentSystem;Integrated Security=True");
            SqlCommand sqlcom = new SqlCommand(query, con);
            con.Open();

            string count = sqlcom.ExecuteScalar().ToString();
            con.Close();
            return count;
        }

        // get total students
        private string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM Add_Student ");
        }

        // get total male students
        private string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM Add_Student WHERE gender='Male'");
        }

        // get total female students
        private string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM Add_Student WHERE gender='Female'");
        }


        private void Statics_Load(object sender, EventArgs e)
        {
            totallabel.Text = "Total Students: " + totalStudent().ToString();
            maleSizelabel.Text = "Male Students: " + totalMaleStudent().ToString();
            femaleSizelabel.Text = "Female Students: " + totalFemaleStudent().ToString();

        }
    }
}
