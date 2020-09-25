namespace Student_Project
{
    partial class viewAllCourses
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
            this.coursesdataGridView = new System.Windows.Forms.DataGridView();
            this.closebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coursesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // coursesdataGridView
            // 
            this.coursesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesdataGridView.Location = new System.Drawing.Point(87, 110);
            this.coursesdataGridView.Name = "coursesdataGridView";
            this.coursesdataGridView.Size = new System.Drawing.Size(627, 327);
            this.coursesdataGridView.TabIndex = 0;
            // 
            // closebutton
            // 
            this.closebutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closebutton.Location = new System.Drawing.Point(371, 454);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(75, 23);
            this.closebutton.TabIndex = 1;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(313, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Courses Form";
            // 
            // viewAllCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(39)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.coursesdataGridView);
            this.Name = "viewAllCourses";
            this.Text = "viewAllCourses";
            this.Load += new System.EventHandler(this.viewAllCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView coursesdataGridView;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Label label1;
    }
}