namespace Student_Project
{
    partial class Student_Score_Form
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
            this.stdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.courseidtextBox = new System.Windows.Forms.TextBox();
            this.stdidlabel = new System.Windows.Forms.Label();
            this.findbutton = new System.Windows.Forms.Button();
            this.stdFindbutton = new System.Windows.Forms.Button();
            this.PrintdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PrintdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stdtextBox
            // 
            this.stdtextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdtextBox.Location = new System.Drawing.Point(558, 23);
            this.stdtextBox.Name = "stdtextBox";
            this.stdtextBox.Size = new System.Drawing.Size(205, 31);
            this.stdtextBox.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(438, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Student Id";
            // 
            // courseidtextBox
            // 
            this.courseidtextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseidtextBox.Location = new System.Drawing.Point(123, 22);
            this.courseidtextBox.Name = "courseidtextBox";
            this.courseidtextBox.Size = new System.Drawing.Size(205, 31);
            this.courseidtextBox.TabIndex = 54;
            // 
            // stdidlabel
            // 
            this.stdidlabel.AutoSize = true;
            this.stdidlabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdidlabel.ForeColor = System.Drawing.Color.White;
            this.stdidlabel.Location = new System.Drawing.Point(11, 24);
            this.stdidlabel.Name = "stdidlabel";
            this.stdidlabel.Size = new System.Drawing.Size(109, 25);
            this.stdidlabel.TabIndex = 53;
            this.stdidlabel.Text = "Course Id";
            // 
            // findbutton
            // 
            this.findbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findbutton.Location = new System.Drawing.Point(250, 68);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(75, 23);
            this.findbutton.TabIndex = 52;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // stdFindbutton
            // 
            this.stdFindbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdFindbutton.Location = new System.Drawing.Point(688, 68);
            this.stdFindbutton.Name = "stdFindbutton";
            this.stdFindbutton.Size = new System.Drawing.Size(75, 23);
            this.stdFindbutton.TabIndex = 51;
            this.stdFindbutton.Text = "Find";
            this.stdFindbutton.UseVisualStyleBackColor = true;
            this.stdFindbutton.Click += new System.EventHandler(this.stdFindbutton_Click);
            // 
            // PrintdataGridView
            // 
            this.PrintdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintdataGridView.Location = new System.Drawing.Point(8, 126);
            this.PrintdataGridView.Name = "PrintdataGridView";
            this.PrintdataGridView.Size = new System.Drawing.Size(785, 302);
            this.PrintdataGridView.TabIndex = 50;
            // 
            // Student_Score_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(39)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stdtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseidtextBox);
            this.Controls.Add(this.stdidlabel);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.stdFindbutton);
            this.Controls.Add(this.PrintdataGridView);
            this.Name = "Student_Score_Form";
            this.Text = "Student_Score_Form";
            ((System.ComponentModel.ISupportInitialize)(this.PrintdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stdtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseidtextBox;
        private System.Windows.Forms.Label stdidlabel;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.Button stdFindbutton;
        private System.Windows.Forms.DataGridView PrintdataGridView;
    }
}