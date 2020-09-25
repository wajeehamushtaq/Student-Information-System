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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void cOURSESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdf = new AddStudentForm();
            addStdf.Show(this);
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm stdlist = new StudentListForm();
            stdlist.Show(this);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDelStd upd = new UpdateDelStd();
            upd.Show(this);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            logopictureBox.Image = Image.FromFile("../../images/CSEdptLogo.png");
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statics stat = new Statics();
            stat.Show(this);
        }

        private void printFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStdForm pstd = new PrintStdForm();
            pstd.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse course = new AddCourse();
            course.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourse rmc = new RemoveCourse();
            rmc.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCourse upt = new UpdateCourse();
            upt.Show(this);
        }

        private void viewCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAllCourses v = new viewAllCourses();
            v.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScore asc = new AddScore();
            asc.Show(this);
        }

        private void editScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditScore esc = new EditScore();
            esc.Show(this);
        }

        private void viewScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewScore vsc = new viewScore();
            vsc.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseStats crs = new CourseStats();
            crs.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
