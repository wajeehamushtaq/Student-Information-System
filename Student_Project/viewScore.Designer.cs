namespace Student_Project
{
    partial class viewScore
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
            this.PrintdataGridView = new System.Windows.Forms.DataGridView();
            this.stdFindbutton = new System.Windows.Forms.Button();
            this.findbutton = new System.Windows.Forms.Button();
            this.courseidtextBox = new System.Windows.Forms.TextBox();
            this.stdidlabel = new System.Windows.Forms.Label();
            this.stdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrintdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintdataGridView
            // 
            this.PrintdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintdataGridView.Location = new System.Drawing.Point(9, 136);
            this.PrintdataGridView.Name = "PrintdataGridView";
            this.PrintdataGridView.Size = new System.Drawing.Size(785, 302);
            this.PrintdataGridView.TabIndex = 0;
            // 
            // stdFindbutton
            // 
            this.stdFindbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdFindbutton.Location = new System.Drawing.Point(689, 78);
            this.stdFindbutton.Name = "stdFindbutton";
            this.stdFindbutton.Size = new System.Drawing.Size(75, 23);
            this.stdFindbutton.TabIndex = 1;
            this.stdFindbutton.Text = "Find";
            this.stdFindbutton.UseVisualStyleBackColor = true;
            this.stdFindbutton.Click += new System.EventHandler(this.c_Click);
            // 
            // findbutton
            // 
            this.findbutton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findbutton.Location = new System.Drawing.Point(251, 78);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(75, 23);
            this.findbutton.TabIndex = 2;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = true;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // courseidtextBox
            // 
            this.courseidtextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseidtextBox.Location = new System.Drawing.Point(124, 32);
            this.courseidtextBox.Name = "courseidtextBox";
            this.courseidtextBox.Size = new System.Drawing.Size(205, 31);
            this.courseidtextBox.TabIndex = 47;
            // 
            // stdidlabel
            // 
            this.stdidlabel.AutoSize = true;
            this.stdidlabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdidlabel.ForeColor = System.Drawing.Color.White;
            this.stdidlabel.Location = new System.Drawing.Point(12, 34);
            this.stdidlabel.Name = "stdidlabel";
            this.stdidlabel.Size = new System.Drawing.Size(109, 25);
            this.stdidlabel.TabIndex = 46;
            this.stdidlabel.Text = "Course Id";
            // 
            // stdtextBox
            // 
            this.stdtextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdtextBox.Location = new System.Drawing.Point(559, 33);
            this.stdtextBox.Name = "stdtextBox";
            this.stdtextBox.Size = new System.Drawing.Size(205, 31);
            this.stdtextBox.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(439, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Student Id";
            // 
            // viewScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stdtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courseidtextBox);
            this.Controls.Add(this.stdidlabel);
            this.Controls.Add(this.findbutton);
            this.Controls.Add(this.stdFindbutton);
            this.Controls.Add(this.PrintdataGridView);
            this.Name = "viewScore";
            this.Text = "viewScore";
            this.Load += new System.EventHandler(this.viewScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrintdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PrintdataGridView;
        private System.Windows.Forms.Button stdFindbutton;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.TextBox courseidtextBox;
        private System.Windows.Forms.Label stdidlabel;
        private System.Windows.Forms.TextBox stdtextBox;
        private System.Windows.Forms.Label label1;
    }
}