namespace ProgramNew
{
    partial class Request
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
            this.reasontextbox = new System.Windows.Forms.TextBox();
            this.enddatetextbox = new System.Windows.Forms.TextBox();
            this.startdatetextbox = new System.Windows.Forms.TextBox();
            this.leavetextbox = new System.Windows.Forms.TextBox();
            this.RequestIDtextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleterq = new System.Windows.Forms.Button();
            this.updaterq = new System.Windows.Forms.Button();
            this.insertrq = new System.Windows.Forms.Button();
            this.RQviwe = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LeaveIDtextbox = new System.Windows.Forms.TextBox();
            this.clearrq = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RQviwe)).BeginInit();
            this.SuspendLayout();
            // 
            // reasontextbox
            // 
            this.reasontextbox.Location = new System.Drawing.Point(466, 147);
            this.reasontextbox.Name = "reasontextbox";
            this.reasontextbox.Size = new System.Drawing.Size(193, 22);
            this.reasontextbox.TabIndex = 40;
            // 
            // enddatetextbox
            // 
            this.enddatetextbox.Location = new System.Drawing.Point(467, 99);
            this.enddatetextbox.Name = "enddatetextbox";
            this.enddatetextbox.Size = new System.Drawing.Size(193, 22);
            this.enddatetextbox.TabIndex = 41;
            // 
            // startdatetextbox
            // 
            this.startdatetextbox.Location = new System.Drawing.Point(466, 48);
            this.startdatetextbox.Name = "startdatetextbox";
            this.startdatetextbox.Size = new System.Drawing.Size(193, 22);
            this.startdatetextbox.TabIndex = 42;
            // 
            // leavetextbox
            // 
            this.leavetextbox.Location = new System.Drawing.Point(139, 142);
            this.leavetextbox.Name = "leavetextbox";
            this.leavetextbox.Size = new System.Drawing.Size(193, 22);
            this.leavetextbox.TabIndex = 43;
            // 
            // RequestIDtextbox
            // 
            this.RequestIDtextbox.Location = new System.Drawing.Point(139, 48);
            this.RequestIDtextbox.Name = "RequestIDtextbox";
            this.RequestIDtextbox.Size = new System.Drawing.Size(193, 22);
            this.RequestIDtextbox.TabIndex = 39;
            this.RequestIDtextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Reason";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "End date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Start date ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Leave Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Request ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // deleterq
            // 
            this.deleterq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleterq.Location = new System.Drawing.Point(363, 258);
            this.deleterq.Name = "deleterq";
            this.deleterq.Size = new System.Drawing.Size(75, 36);
            this.deleterq.TabIndex = 33;
            this.deleterq.Text = "Delete";
            this.deleterq.UseVisualStyleBackColor = true;
            this.deleterq.Click += new System.EventHandler(this.deleterq_Click);
            // 
            // updaterq
            // 
            this.updaterq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updaterq.Location = new System.Drawing.Point(167, 258);
            this.updaterq.Name = "updaterq";
            this.updaterq.Size = new System.Drawing.Size(84, 36);
            this.updaterq.TabIndex = 32;
            this.updaterq.Text = "Update";
            this.updaterq.UseVisualStyleBackColor = true;
            this.updaterq.Click += new System.EventHandler(this.updaterq_Click);
            // 
            // insertrq
            // 
            this.insertrq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertrq.Location = new System.Drawing.Point(12, 258);
            this.insertrq.Name = "insertrq";
            this.insertrq.Size = new System.Drawing.Size(75, 36);
            this.insertrq.TabIndex = 31;
            this.insertrq.Text = "Insert";
            this.insertrq.UseVisualStyleBackColor = true;
            this.insertrq.Click += new System.EventHandler(this.insertrq_Click);
            // 
            // RQviwe
            // 
            this.RQviwe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RQviwe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RQviwe.Location = new System.Drawing.Point(0, 343);
            this.RQviwe.Name = "RQviwe";
            this.RQviwe.RowHeadersWidth = 51;
            this.RQviwe.RowTemplate.Height = 24;
            this.RQviwe.Size = new System.Drawing.Size(695, 242);
            this.RQviwe.TabIndex = 44;
            this.RQviwe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RQviwe_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Request From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Leave ID";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // LeaveIDtextbox
            // 
            this.LeaveIDtextbox.Location = new System.Drawing.Point(139, 96);
            this.LeaveIDtextbox.Name = "LeaveIDtextbox";
            this.LeaveIDtextbox.Size = new System.Drawing.Size(193, 22);
            this.LeaveIDtextbox.TabIndex = 39;
            this.LeaveIDtextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clearrq
            // 
            this.clearrq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearrq.Location = new System.Drawing.Point(539, 258);
            this.clearrq.Name = "clearrq";
            this.clearrq.Size = new System.Drawing.Size(75, 36);
            this.clearrq.TabIndex = 46;
            this.clearrq.Text = "Clear";
            this.clearrq.UseVisualStyleBackColor = true;
            this.clearrq.Click += new System.EventHandler(this.clearrq_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 12);
            this.panel1.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 48;
            this.label8.Text = "Request Detalis";
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(695, 585);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clearrq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RQviwe);
            this.Controls.Add(this.reasontextbox);
            this.Controls.Add(this.enddatetextbox);
            this.Controls.Add(this.startdatetextbox);
            this.Controls.Add(this.leavetextbox);
            this.Controls.Add(this.LeaveIDtextbox);
            this.Controls.Add(this.RequestIDtextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleterq);
            this.Controls.Add(this.updaterq);
            this.Controls.Add(this.insertrq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Request";
            this.Text = "Request";
            this.Load += new System.EventHandler(this.Requestinsert_Click);
            ((System.ComponentModel.ISupportInitialize)(this.RQviwe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reasontextbox;
        private System.Windows.Forms.TextBox enddatetextbox;
        private System.Windows.Forms.TextBox startdatetextbox;
        private System.Windows.Forms.TextBox leavetextbox;
        private System.Windows.Forms.TextBox RequestIDtextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleterq;
        private System.Windows.Forms.Button updaterq;
        private System.Windows.Forms.Button insertrq;
        private System.Windows.Forms.DataGridView RQviwe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LeaveIDtextbox;
        private System.Windows.Forms.Button clearrq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
    }
}