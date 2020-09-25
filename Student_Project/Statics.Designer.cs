namespace Student_Project
{
    partial class Statics
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.maleSizelabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.femaleSizelabel = new System.Windows.Forms.Label();
            this.totallabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.maleSizelabel);
            this.panel1.Location = new System.Drawing.Point(1, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 243);
            this.panel1.TabIndex = 0;
            // 
            // maleSizelabel
            // 
            this.maleSizelabel.AutoSize = true;
            this.maleSizelabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleSizelabel.ForeColor = System.Drawing.Color.White;
            this.maleSizelabel.Location = new System.Drawing.Point(89, 107);
            this.maleSizelabel.Name = "maleSizelabel";
            this.maleSizelabel.Size = new System.Drawing.Size(111, 28);
            this.maleSizelabel.TabIndex = 3;
            this.maleSizelabel.Text = "Male: 50";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(39)))), ((int)(((byte)(175)))));
            this.panel2.Controls.Add(this.femaleSizelabel);
            this.panel2.Location = new System.Drawing.Point(345, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 243);
            this.panel2.TabIndex = 1;
            // 
            // femaleSizelabel
            // 
            this.femaleSizelabel.AutoSize = true;
            this.femaleSizelabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleSizelabel.ForeColor = System.Drawing.Color.White;
            this.femaleSizelabel.Location = new System.Drawing.Point(110, 107);
            this.femaleSizelabel.Name = "femaleSizelabel";
            this.femaleSizelabel.Size = new System.Drawing.Size(139, 28);
            this.femaleSizelabel.TabIndex = 3;
            this.femaleSizelabel.Text = "Female: 50";
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallabel.Location = new System.Drawing.Point(224, 91);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(247, 28);
            this.totallabel.TabIndex = 2;
            this.totallabel.Text = "TOTAL STUDENTS: 100";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.totallabel);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(703, 193);
            this.panel3.TabIndex = 3;
            // 
            // Statics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 427);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Statics";
            this.Text = "Statics";
            this.Load += new System.EventHandler(this.Statics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label maleSizelabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label femaleSizelabel;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Panel panel3;
    }
}