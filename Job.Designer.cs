namespace ProgramNew
{
    partial class Job
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
            this.DELETE = new System.Windows.Forms.Button();
            this.UPDATEJOB = new System.Windows.Forms.Button();
            this.insertJOB = new System.Windows.Forms.Button();
            this.EmployeeIDtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jobIDtextBox = new System.Windows.Forms.TextBox();
            this.jobnametextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JobView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CLEAR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.JobView)).BeginInit();
            this.SuspendLayout();
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.Location = new System.Drawing.Point(392, 234);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(80, 35);
            this.DELETE.TabIndex = 22;
            this.DELETE.Text = "Delete";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // UPDATEJOB
            // 
            this.UPDATEJOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATEJOB.Location = new System.Drawing.Point(217, 234);
            this.UPDATEJOB.Name = "UPDATEJOB";
            this.UPDATEJOB.Size = new System.Drawing.Size(80, 35);
            this.UPDATEJOB.TabIndex = 21;
            this.UPDATEJOB.Text = "Update";
            this.UPDATEJOB.UseVisualStyleBackColor = true;
            this.UPDATEJOB.Click += new System.EventHandler(this.UPDATEJOB_Click);
            // 
            // insertJOB
            // 
            this.insertJOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertJOB.Location = new System.Drawing.Point(27, 234);
            this.insertJOB.Name = "insertJOB";
            this.insertJOB.Size = new System.Drawing.Size(80, 35);
            this.insertJOB.TabIndex = 20;
            this.insertJOB.Text = "Insert";
            this.insertJOB.UseVisualStyleBackColor = true;
            this.insertJOB.Click += new System.EventHandler(this.insertJOB_Click);
            // 
            // EmployeeIDtextBox
            // 
            this.EmployeeIDtextBox.Location = new System.Drawing.Point(140, 139);
            this.EmployeeIDtextBox.Name = "EmployeeIDtextBox";
            this.EmployeeIDtextBox.Size = new System.Drawing.Size(157, 22);
            this.EmployeeIDtextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Job ID";
            // 
            // jobIDtextBox
            // 
            this.jobIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobIDtextBox.Location = new System.Drawing.Point(140, 94);
            this.jobIDtextBox.Name = "jobIDtextBox";
            this.jobIDtextBox.Size = new System.Drawing.Size(157, 22);
            this.jobIDtextBox.TabIndex = 15;
            // 
            // jobnametextbox
            // 
            this.jobnametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobnametextbox.Location = new System.Drawing.Point(140, 50);
            this.jobnametextbox.Name = "jobnametextbox";
            this.jobnametextbox.Size = new System.Drawing.Size(157, 22);
            this.jobnametextbox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Job Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // JobView
            // 
            this.JobView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JobView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.JobView.Location = new System.Drawing.Point(0, 331);
            this.JobView.Name = "JobView";
            this.JobView.RowHeadersWidth = 51;
            this.JobView.RowTemplate.Height = 24;
            this.JobView.Size = new System.Drawing.Size(695, 254);
            this.JobView.TabIndex = 24;
            this.JobView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JobView_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Job From";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-8, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 10);
            this.panel1.TabIndex = 26;
            // 
            // CLEAR
            // 
            this.CLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR.Location = new System.Drawing.Point(553, 234);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(80, 35);
            this.CLEAR.TabIndex = 27;
            this.CLEAR.Text = "Clear";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Job Details";
            // 
            // Job
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(695, 585);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.JobView);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.UPDATEJOB);
            this.Controls.Add(this.insertJOB);
            this.Controls.Add(this.EmployeeIDtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jobIDtextBox);
            this.Controls.Add(this.jobnametextbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Job";
            this.Text = "Job";
            this.Load += new System.EventHandler(this.Job_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JobView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button UPDATEJOB;
        private System.Windows.Forms.Button insertJOB;
        private System.Windows.Forms.TextBox EmployeeIDtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jobIDtextBox;
        private System.Windows.Forms.TextBox jobnametextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView JobView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Label label5;
    }
}