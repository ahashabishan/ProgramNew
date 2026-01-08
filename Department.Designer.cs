namespace ProgramNew
{
    partial class Department
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
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentID = new System.Windows.Forms.TextBox();
            this.departmentname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deletebuttonde = new System.Windows.Forms.Button();
            this.updatebuttonde = new System.Windows.Forms.Button();
            this.insertde = new System.Windows.Forms.Button();
            this.DEDATEGRIDVIEW = new System.Windows.Forms.DataGridView();
            this.Depa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DEDATEGRIDVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(192, 125);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(157, 22);
            this.EmployeeID.TabIndex = 10;
            this.EmployeeID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Employee ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Department ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // departmentID
            // 
            this.departmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentID.Location = new System.Drawing.Point(192, 80);
            this.departmentID.Name = "departmentID";
            this.departmentID.Size = new System.Drawing.Size(157, 22);
            this.departmentID.TabIndex = 6;
            // 
            // departmentname
            // 
            this.departmentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentname.Location = new System.Drawing.Point(192, 43);
            this.departmentname.Name = "departmentname";
            this.departmentname.Size = new System.Drawing.Size(157, 22);
            this.departmentname.TabIndex = 7;
            this.departmentname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Department Name";
            // 
            // deletebuttonde
            // 
            this.deletebuttonde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebuttonde.Location = new System.Drawing.Point(364, 200);
            this.deletebuttonde.Name = "deletebuttonde";
            this.deletebuttonde.Size = new System.Drawing.Size(80, 35);
            this.deletebuttonde.TabIndex = 13;
            this.deletebuttonde.Text = "Delete";
            this.deletebuttonde.UseVisualStyleBackColor = true;
            this.deletebuttonde.Click += new System.EventHandler(this.deletebuttonde_Click);
            // 
            // updatebuttonde
            // 
            this.updatebuttonde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebuttonde.Location = new System.Drawing.Point(203, 200);
            this.updatebuttonde.Name = "updatebuttonde";
            this.updatebuttonde.Size = new System.Drawing.Size(80, 35);
            this.updatebuttonde.TabIndex = 12;
            this.updatebuttonde.Text = "Update";
            this.updatebuttonde.UseVisualStyleBackColor = true;
            this.updatebuttonde.Click += new System.EventHandler(this.updatebuttonde_Click);
            // 
            // insertde
            // 
            this.insertde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertde.Location = new System.Drawing.Point(53, 200);
            this.insertde.Name = "insertde";
            this.insertde.Size = new System.Drawing.Size(80, 35);
            this.insertde.TabIndex = 11;
            this.insertde.Text = "Insert";
            this.insertde.UseVisualStyleBackColor = true;
            this.insertde.Click += new System.EventHandler(this.insertde_Click);
            // 
            // DEDATEGRIDVIEW
            // 
            this.DEDATEGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DEDATEGRIDVIEW.Location = new System.Drawing.Point(130, 344);
            this.DEDATEGRIDVIEW.Name = "DEDATEGRIDVIEW";
            this.DEDATEGRIDVIEW.RowHeadersWidth = 51;
            this.DEDATEGRIDVIEW.RowTemplate.Height = 24;
            this.DEDATEGRIDVIEW.Size = new System.Drawing.Size(433, 205);
            this.DEDATEGRIDVIEW.TabIndex = 15;
            this.DEDATEGRIDVIEW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DEDATEGRIDVIEW_CellContentClick);
            // 
            // Depa
            // 
            this.Depa.AutoSize = true;
            this.Depa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depa.Location = new System.Drawing.Point(241, 9);
            this.Depa.Name = "Depa";
            this.Depa.Size = new System.Drawing.Size(195, 25);
            this.Depa.TabIndex = 16;
            this.Depa.Text = "Department Details";
            this.Depa.Click += new System.EventHandler(this.Depa_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(687, 42);
            this.label4.TabIndex = 17;
            this.label4.Text = "Department Record";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(6, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 11);
            this.panel1.TabIndex = 18;
            // 
            // clearde
            // 
            this.clearde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearde.Location = new System.Drawing.Point(545, 200);
            this.clearde.Name = "clearde";
            this.clearde.Size = new System.Drawing.Size(80, 35);
            this.clearde.TabIndex = 19;
            this.clearde.Text = "Clear";
            this.clearde.UseVisualStyleBackColor = true;
            this.clearde.Click += new System.EventHandler(this.clearde_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(695, 585);
            this.Controls.Add(this.clearde);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Depa);
            this.Controls.Add(this.DEDATEGRIDVIEW);
            this.Controls.Add(this.deletebuttonde);
            this.Controls.Add(this.updatebuttonde);
            this.Controls.Add(this.insertde);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departmentID);
            this.Controls.Add(this.departmentname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DEDATEGRIDVIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox departmentID;
        private System.Windows.Forms.TextBox departmentname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletebuttonde;
        private System.Windows.Forms.Button updatebuttonde;
        private System.Windows.Forms.Button insertde;
        private System.Windows.Forms.DataGridView DEDATEGRIDVIEW;
        private System.Windows.Forms.Label Depa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearde;
    }
}