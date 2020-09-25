namespace Student_Project
{
    partial class CourseStats
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
            this.courselabel = new System.Windows.Forms.Label();
            this.findbutton = new System.Windows.Forms.Button();
            this.PrintdataGridView = new System.Windows.Forms.DataGridView();
            this.searchbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrintdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // courseidtextBox
            // 
            this.courseidtextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseidtextBox.Location = new System.Drawing.Point(573, 33);
            this.courseidtextBox.Name = "courseidtextBox";
            this.courseidtextBox.Size = new System.Drawing.Size(205, 31);
            this.courseidtextBox.TabIndex = 51;
            // 
            // courselabel
            // 
            this.courselabel.AutoSize = true;
            this.courselabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courselabel.ForeColor = System.Drawing.Color.White;
            this.courselabel.Location = new System.Drawing.Point(461, 35);
            this.courselabel.Name = "courselabel";
            this.courselabel.Size = new System.Drawing.Size(109, 25);
            this.courselabel.TabIndex = 50;
            this.courselabel.Text = "Course Id";
            // 
            // findbutton
            // 
            this.findbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findbutton.Location = new System.Drawing.Point(795, 39);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(75, 23);
            this.findbutton.TabIndex = 49;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // PrintdataGridView
            // 
            this.PrintdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintdataGridView.Location = new System.Drawing.Point(8, 90);
            this.PrintdataGridView.Name = "PrintdataGridView";
            this.PrintdataGridView.Size = new System.Drawing.Size(863, 338);
            this.PrintdataGridView.TabIndex = 48;
            // 
            // searchbutton
            // 
            this.searchbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.Location = new System.Drawing.Point(343, 37);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 52;
            this.searchbutton.Text = "Show";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Show All Numbers of students";
            // 
            // CourseStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.courseidtextBox);
            this.Controls.Add(this.courselabel);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.PrintdataGridView);
            this.Name = "CourseStats";
            this.Text = "CourseStats";
            ((System.ComponentModel.ISupportInitialize)(this.PrintdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseidtextBox;
        private System.Windows.Forms.Label courselabel;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.DataGridView PrintdataGridView;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label label1;
    }
}