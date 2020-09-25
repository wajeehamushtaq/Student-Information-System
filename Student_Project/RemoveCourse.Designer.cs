namespace Student_Project
{
    partial class RemoveCourse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.courseidtextBox = new System.Windows.Forms.TextBox();
            this.courseIdlabel = new System.Windows.Forms.Label();
            this.finddataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.findbutton = new System.Windows.Forms.Button();
            this.removebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.finddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // courseidtextBox
            // 
            this.courseidtextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseidtextBox.Location = new System.Drawing.Point(320, 83);
            this.courseidtextBox.Name = "courseidtextBox";
            this.courseidtextBox.Size = new System.Drawing.Size(254, 21);
            this.courseidtextBox.TabIndex = 17;
            // 
            // courseIdlabel
            // 
            this.courseIdlabel.AutoSize = true;
            this.courseIdlabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseIdlabel.ForeColor = System.Drawing.Color.White;
            this.courseIdlabel.Location = new System.Drawing.Point(134, 83);
            this.courseIdlabel.Name = "courseIdlabel";
            this.courseIdlabel.Size = new System.Drawing.Size(171, 25);
            this.courseIdlabel.TabIndex = 16;
            this.courseIdlabel.Text = "Enter Course Id:";
            // 
            // finddataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.finddataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.finddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finddataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.finddataGridView.Location = new System.Drawing.Point(139, 135);
            this.finddataGridView.Name = "finddataGridView";
            this.finddataGridView.Size = new System.Drawing.Size(544, 224);
            this.finddataGridView.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Course_Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Credit Hourse";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Course_Description";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // findbutton
            // 
            this.findbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findbutton.Location = new System.Drawing.Point(591, 81);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(75, 23);
            this.findbutton.TabIndex = 19;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // removebutton
            // 
            this.removebutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebutton.Location = new System.Drawing.Point(364, 381);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(75, 23);
            this.removebutton.TabIndex = 20;
            this.removebutton.Text = "Remove";
            this.removebutton.UseVisualStyleBackColor = true;
            this.removebutton.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // RemoveCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(39)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removebutton);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.finddataGridView);
            this.Controls.Add(this.courseidtextBox);
            this.Controls.Add(this.courseIdlabel);
            this.Name = "RemoveCourse";
            this.Text = "RemoveCourse";
            ((System.ComponentModel.ISupportInitialize)(this.finddataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox courseidtextBox;
        private System.Windows.Forms.Label courseIdlabel;
        private System.Windows.Forms.DataGridView finddataGridView;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button removebutton;
    }
}