namespace Student_Project
{
    partial class About
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
            this.loginbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Headerlabel = new System.Windows.Forms.Label();
            this.logopictureBox = new System.Windows.Forms.PictureBox();
            this.csepictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.loginbutton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(718, 19);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(65, 34);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.Aboutbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.Headerlabel);
            this.panel1.Controls.Add(this.logopictureBox);
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 72);
            this.panel1.TabIndex = 1;
            // 
            // Headerlabel
            // 
            this.Headerlabel.AutoSize = true;
            this.Headerlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.Headerlabel.Font = new System.Drawing.Font("Bebas Neue Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headerlabel.ForeColor = System.Drawing.Color.White;
            this.Headerlabel.Location = new System.Drawing.Point(90, 25);
            this.Headerlabel.Name = "Headerlabel";
            this.Headerlabel.Size = new System.Drawing.Size(271, 28);
            this.Headerlabel.TabIndex = 2;
            this.Headerlabel.Text = "Student Information System";
            // 
            // logopictureBox
            // 
            this.logopictureBox.Location = new System.Drawing.Point(14, 3);
            this.logopictureBox.Name = "logopictureBox";
            this.logopictureBox.Size = new System.Drawing.Size(70, 66);
            this.logopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logopictureBox.TabIndex = 2;
            this.logopictureBox.TabStop = false;
            // 
            // csepictureBox
            // 
            this.csepictureBox.Location = new System.Drawing.Point(1, 75);
            this.csepictureBox.Name = "csepictureBox";
            this.csepictureBox.Size = new System.Drawing.Size(801, 282);
            this.csepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.csepictureBox.TabIndex = 2;
            this.csepictureBox.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.csepictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csepictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logopictureBox;
        private System.Windows.Forms.Label Headerlabel;
        private System.Windows.Forms.PictureBox csepictureBox;
    }
}