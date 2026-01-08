namespace ProgramNew
{
    partial class Leave
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leaveIDtextBox = new System.Windows.Forms.TextBox();
            this.reminingLeavetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberofleavetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.employeeidtextBox = new System.Windows.Forms.TextBox();
            this.employeeVIEW = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leave ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remining Leave";
            // 
            // leaveIDtextBox
            // 
            this.leaveIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveIDtextBox.Location = new System.Drawing.Point(137, 62);
            this.leaveIDtextBox.Name = "leaveIDtextBox";
            this.leaveIDtextBox.Size = new System.Drawing.Size(157, 22);
            this.leaveIDtextBox.TabIndex = 1;
            // 
            // reminingLeavetextBox
            // 
            this.reminingLeavetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reminingLeavetextBox.Location = new System.Drawing.Point(491, 59);
            this.reminingLeavetextBox.Name = "reminingLeavetextBox";
            this.reminingLeavetextBox.Size = new System.Drawing.Size(157, 22);
            this.reminingLeavetextBox.TabIndex = 1;
            this.reminingLeavetextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Leave";
            // 
            // NumberofleavetextBox
            // 
            this.NumberofleavetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofleavetextBox.Location = new System.Drawing.Point(491, 105);
            this.NumberofleavetextBox.Name = "NumberofleavetextBox";
            this.NumberofleavetextBox.Size = new System.Drawing.Size(157, 22);
            this.NumberofleavetextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Employee ID";
            // 
            // employeeidtextBox
            // 
            this.employeeidtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeidtextBox.Location = new System.Drawing.Point(137, 108);
            this.employeeidtextBox.Name = "employeeidtextBox";
            this.employeeidtextBox.Size = new System.Drawing.Size(157, 22);
            this.employeeidtextBox.TabIndex = 1;
            // 
            // employeeVIEW
            // 
            this.employeeVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeVIEW.Location = new System.Drawing.Point(96, 346);
            this.employeeVIEW.Name = "employeeVIEW";
            this.employeeVIEW.RowHeadersWidth = 51;
            this.employeeVIEW.RowTemplate.Height = 24;
            this.employeeVIEW.Size = new System.Drawing.Size(504, 202);
            this.employeeVIEW.TabIndex = 13;
            this.employeeVIEW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeVIEW_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Leave From";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-8, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 10);
            this.panel1.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(252, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Leave Detalis";
            // 
            // Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(695, 585);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.employeeVIEW);
            this.Controls.Add(this.NumberofleavetextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reminingLeavetextBox);
            this.Controls.Add(this.employeeidtextBox);
            this.Controls.Add(this.leaveIDtextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leave";
            this.Text = "Leave";
            this.Load += new System.EventHandler(this.Leave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeVIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox leaveIDtextBox;
        private System.Windows.Forms.TextBox reminingLeavetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberofleavetextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox employeeidtextBox;
        private System.Windows.Forms.DataGridView employeeVIEW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}