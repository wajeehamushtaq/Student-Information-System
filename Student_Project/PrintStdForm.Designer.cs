namespace Student_Project
{
    partial class PrintStdForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PrintdataGridView = new System.Windows.Forms.DataGridView();
            this.AllradioButton = new System.Windows.Forms.RadioButton();
            this.maleradioButton = new System.Windows.Forms.RadioButton();
            this.femaleradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gobutton = new System.Windows.Forms.Button();
            this.askdatelabel = new System.Windows.Forms.Label();
            this.yesradioButton = new System.Windows.Forms.RadioButton();
            this.noradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.birthbetweenlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PrintdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrintdataGridView
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.PrintdataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PrintdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrintdataGridView.GridColor = System.Drawing.Color.Black;
            this.PrintdataGridView.Location = new System.Drawing.Point(12, 112);
            this.PrintdataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PrintdataGridView.Name = "PrintdataGridView";
            this.PrintdataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PrintdataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.PrintdataGridView.Size = new System.Drawing.Size(847, 338);
            this.PrintdataGridView.TabIndex = 0;
            // 
            // AllradioButton
            // 
            this.AllradioButton.AutoSize = true;
            this.AllradioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllradioButton.ForeColor = System.Drawing.Color.White;
            this.AllradioButton.Location = new System.Drawing.Point(7, 36);
            this.AllradioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllradioButton.Name = "AllradioButton";
            this.AllradioButton.Size = new System.Drawing.Size(47, 25);
            this.AllradioButton.TabIndex = 2;
            this.AllradioButton.TabStop = true;
            this.AllradioButton.Text = "All";
            this.AllradioButton.UseVisualStyleBackColor = true;
            // 
            // maleradioButton
            // 
            this.maleradioButton.AutoSize = true;
            this.maleradioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleradioButton.ForeColor = System.Drawing.Color.White;
            this.maleradioButton.Location = new System.Drawing.Point(108, 36);
            this.maleradioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.maleradioButton.Name = "maleradioButton";
            this.maleradioButton.Size = new System.Drawing.Size(67, 25);
            this.maleradioButton.TabIndex = 3;
            this.maleradioButton.TabStop = true;
            this.maleradioButton.Text = "Male";
            this.maleradioButton.UseVisualStyleBackColor = true;
            // 
            // femaleradioButton
            // 
            this.femaleradioButton.AutoSize = true;
            this.femaleradioButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleradioButton.ForeColor = System.Drawing.Color.White;
            this.femaleradioButton.Location = new System.Drawing.Point(210, 36);
            this.femaleradioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.femaleradioButton.Name = "femaleradioButton";
            this.femaleradioButton.Size = new System.Drawing.Size(85, 25);
            this.femaleradioButton.TabIndex = 4;
            this.femaleradioButton.TabStop = true;
            this.femaleradioButton.Text = "Female";
            this.femaleradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gobutton);
            this.groupBox1.Controls.Add(this.femaleradioButton);
            this.groupBox1.Controls.Add(this.AllradioButton);
            this.groupBox1.Controls.Add(this.maleradioButton);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(845, 85);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // gobutton
            // 
            this.gobutton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobutton.ForeColor = System.Drawing.Color.Black;
            this.gobutton.Location = new System.Drawing.Point(696, 30);
            this.gobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gobutton.Name = "gobutton";
            this.gobutton.Size = new System.Drawing.Size(87, 30);
            this.gobutton.TabIndex = 5;
            this.gobutton.Text = "Go";
            this.gobutton.UseVisualStyleBackColor = true;
            this.gobutton.Click += new System.EventHandler(this.gobutton_Click);
            // 
            // askdatelabel
            // 
            this.askdatelabel.AutoSize = true;
            this.askdatelabel.Location = new System.Drawing.Point(7, 28);
            this.askdatelabel.Name = "askdatelabel";
            this.askdatelabel.Size = new System.Drawing.Size(111, 17);
            this.askdatelabel.TabIndex = 5;
            this.askdatelabel.Text = "Use Date Range";
            // 
            // yesradioButton
            // 
            this.yesradioButton.AutoSize = true;
            this.yesradioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesradioButton.ForeColor = System.Drawing.Color.White;
            this.yesradioButton.Location = new System.Drawing.Point(133, 25);
            this.yesradioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yesradioButton.Name = "yesradioButton";
            this.yesradioButton.Size = new System.Drawing.Size(46, 21);
            this.yesradioButton.TabIndex = 6;
            this.yesradioButton.TabStop = true;
            this.yesradioButton.Text = "Yes";
            this.yesradioButton.UseVisualStyleBackColor = true;
            this.yesradioButton.CheckedChanged += new System.EventHandler(this.yesradioButton_CheckedChanged);
            // 
            // noradioButton
            // 
            this.noradioButton.AutoSize = true;
            this.noradioButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noradioButton.ForeColor = System.Drawing.Color.White;
            this.noradioButton.Location = new System.Drawing.Point(239, 25);
            this.noradioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.noradioButton.Name = "noradioButton";
            this.noradioButton.Size = new System.Drawing.Size(43, 21);
            this.noradioButton.TabIndex = 7;
            this.noradioButton.TabStop = true;
            this.noradioButton.Text = "No";
            this.noradioButton.UseVisualStyleBackColor = true;
            this.noradioButton.CheckedChanged += new System.EventHandler(this.noradioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.birthbetweenlabel);
            this.groupBox2.Controls.Add(this.noradioButton);
            this.groupBox2.Controls.Add(this.askdatelabel);
            this.groupBox2.Controls.Add(this.yesradioButton);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(345, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(345, 102);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "to";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(253, 63);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(81, 23);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 62);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(81, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // birthbetweenlabel
            // 
            this.birthbetweenlabel.AutoSize = true;
            this.birthbetweenlabel.Location = new System.Drawing.Point(7, 66);
            this.birthbetweenlabel.Name = "birthbetweenlabel";
            this.birthbetweenlabel.Size = new System.Drawing.Size(126, 17);
            this.birthbetweenlabel.TabIndex = 8;
            this.birthbetweenlabel.Text = "Birthdate Between";
            // 
            // PrintStdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(865, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PrintdataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PrintStdForm";
            this.Text = "Search Student ";
            this.Load += new System.EventHandler(this.PrintStdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrintdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PrintdataGridView;
        private System.Windows.Forms.RadioButton AllradioButton;
        private System.Windows.Forms.RadioButton maleradioButton;
        private System.Windows.Forms.RadioButton femaleradioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label askdatelabel;
        private System.Windows.Forms.RadioButton yesradioButton;
        private System.Windows.Forms.RadioButton noradioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label birthbetweenlabel;
        private System.Windows.Forms.Button gobutton;
        private System.Windows.Forms.Label label1;
    }
}