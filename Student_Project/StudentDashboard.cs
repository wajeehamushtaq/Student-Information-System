using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            logopictureBox.Image = Image.FromFile("../../images/CSEdptLogo.png");
        }

        private void RegCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register rgt = new Register();
            rgt.Show(this);
        }

        private void myScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_Score_Form st_score = new Student_Score_Form();
            st_score.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
