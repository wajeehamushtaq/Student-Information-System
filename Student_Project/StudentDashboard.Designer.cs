namespace Student_Project
{
    partial class StudentDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RegCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logopictureBox = new System.Windows.Forms.PictureBox();
            this.wellabel = new System.Windows.Forms.Label();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(39)))), ((int)(((byte)(175)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegCourseToolStripMenuItem,
            this.myScoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RegCourseToolStripMenuItem
            // 
            this.RegCourseToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegCourseToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.RegCourseToolStripMenuItem.Name = "RegCourseToolStripMenuItem";
            this.RegCourseToolStripMenuItem.Size = new System.Drawing.Size(164, 27);
            this.RegCourseToolStripMenuItem.Text = "Register Course";
            this.RegCourseToolStripMenuItem.Click += new System.EventHandler(this.RegCourseToolStripMenuItem_Click);
            // 
            // myScoreToolStripMenuItem
            // 
            this.myScoreToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myScoreToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.myScoreToolStripMenuItem.Name = "myScoreToolStripMenuItem";
            this.myScoreToolStripMenuItem.Size = new System.Drawing.Size(82, 27);
            this.myScoreToolStripMenuItem.Text = "Scores";
            this.myScoreToolStripMenuItem.Click += new System.EventHandler(this.myScoreToolStripMenuItem_Click);
            // 
            // logopictureBox
            // 
            this.logopictureBox.Location = new System.Drawing.Point(180, 126);
            this.logopictureBox.Name = "logopictureBox";
            this.logopictureBox.Size = new System.Drawing.Size(416, 298);
            this.logopictureBox.TabIndex = 1;
            this.logopictureBox.TabStop = false;
            // 
            // wellabel
            // 
            this.wellabel.AutoSize = true;
            this.wellabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wellabel.Location = new System.Drawing.Point(222, 83);
            this.wellabel.Name = "wellabel";
            this.wellabel.Size = new System.Drawing.Size(325, 28);
            this.wellabel.TabIndex = 6;
            this.wellabel.Text = "Student Information System";
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel.Location = new System.Drawing.Point(295, 45);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(167, 28);
            this.welcomelabel.TabIndex = 5;
            this.welcomelabel.Text = "WELCOME TO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wellabel);
            this.Controls.Add(this.welcomelabel);
            this.Controls.Add(this.logopictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegCourseToolStripMenuItem;
        private System.Windows.Forms.PictureBox logopictureBox;
        private System.Windows.Forms.Label wellabel;
        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Button button1;
    }
}