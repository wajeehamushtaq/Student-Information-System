namespace Student_Project
{
    partial class StudentListForm
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
            this.StdListdataGridView = new System.Windows.Forms.DataGridView();
            this.cbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StdListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StdListdataGridView
            // 
            this.StdListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StdListdataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StdListdataGridView.Location = new System.Drawing.Point(44, 81);
            this.StdListdataGridView.Name = "StdListdataGridView";
            this.StdListdataGridView.Size = new System.Drawing.Size(823, 351);
            this.StdListdataGridView.TabIndex = 0;
            // 
            // cbutton
            // 
            this.cbutton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(39)))), ((int)(((byte)(175)))));
            this.cbutton.Location = new System.Drawing.Point(418, 449);
            this.cbutton.Name = "cbutton";
            this.cbutton.Size = new System.Drawing.Size(75, 23);
            this.cbutton.TabIndex = 1;
            this.cbutton.Text = "Close";
            this.cbutton.UseVisualStyleBackColor = true;
            this.cbutton.Click += new System.EventHandler(this.cbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Student Form";
            // 
            // StudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(82)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(920, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbutton);
            this.Controls.Add(this.StdListdataGridView);
            this.Name = "StudentListForm";
            this.Text = "StudentListForm";
            this.Load += new System.EventHandler(this.StudentListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StdListdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StdListdataGridView;
        private System.Windows.Forms.Button cbutton;
        private System.Windows.Forms.Label label1;
    }
}