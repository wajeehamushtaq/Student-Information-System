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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Aboutbutton_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void About_Load(object sender, EventArgs e)
        {
            // set image 
            logopictureBox.Image = Image.FromFile("../../images/CSEdptLogoWhite.png");
            csepictureBox.Image = Image.FromFile("../../images/dept.jpg");
        }
    }
}
