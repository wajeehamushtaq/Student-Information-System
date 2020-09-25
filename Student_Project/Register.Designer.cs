namespace Student_Project
{
    partial class Register
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
            this.courseidtextBox = new System.Windows.Forms.TextBox();
            this.courseIdlabel = new System.Windows.Forms.Label();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.stdIdtextBox = new System.Windows.Forms.TextBox();
            this.StudentId = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseidtextBox
            // 
            this.courseidtextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseidtextBox.Location = new System.Drawing.Point(275, 114);
            this.courseidtextBox.Name = "courseidtextBox";
            this.courseidtextBox.Size = new System.Drawing.Size(254, 21);
            this.courseidtextBox.TabIndex = 26;
            // 
            // courseIdlabel
            // 
            this.courseIdlabel.AutoSize = true;
            this.courseIdlabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdlabel.ForeColor = System.Drawing.Color.White;
            this.courseIdlabel.Location = new System.Drawing.Point(154, 114);
            this.courseIdlabel.Name = "courseIdlabel";
            this.courseIdlabel.Size = new System.Drawing.Size(115, 25);
            this.courseIdlabel.TabIndex = 25;
            this.courseIdlabel.Text = "Course Id:";
            // 
            // Registerbutton
            // 
            this.Registerbutton.Location = new System.Drawing.Point(275, 271);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(75, 23);
            this.Registerbutton.TabIndex = 30;
            this.Registerbutton.Text = "Register";
            this.Registerbutton.UseVisualStyleBackColor = true;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // stdIdtextBox
            // 
            this.stdIdtextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdIdtextBox.Location = new System.Drawing.Point(275, 184);
            this.stdIdtextBox.Name = "stdIdtextBox";
            this.stdIdtextBox.Size = new System.Drawing.Size(254, 21);
            this.stdIdtextBox.TabIndex = 29;
            // 
            // StudentId
            // 
            this.StudentId.AutoSize = true;
            this.StudentId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentId.ForeColor = System.Drawing.Color.White;
            this.StudentId.Location = new System.Drawing.Point(96, 184);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(173, 25);
            this.StudentId.TabIndex = 28;
            this.StudentId.Text = "Your Student ID:";
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(454, 271);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(75, 23);
            this.closebutton.TabIndex = 31;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(39)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.stdIdtextBox);
            this.Controls.Add(this.StudentId);
            this.Controls.Add(this.courseidtextBox);
            this.Controls.Add(this.courseIdlabel);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox courseidtextBox;
        private System.Windows.Forms.Label courseIdlabel;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.TextBox stdIdtextBox;
        private System.Windows.Forms.Label StudentId;
        private System.Windows.Forms.Button closebutton;
    }
}