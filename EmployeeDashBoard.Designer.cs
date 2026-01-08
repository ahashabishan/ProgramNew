namespace ProgramNew
{
    partial class EmployeeDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.signout = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btstatus = new System.Windows.Forms.Button();
            this.btleave = new System.Windows.Forms.Button();
            this.btemployee = new System.Windows.Forms.Button();
            this.btdashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btstatus);
            this.panel1.Controls.Add(this.btleave);
            this.panel1.Controls.Add(this.btemployee);
            this.panel1.Controls.Add(this.btdashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 596);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 443);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 153);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.signout);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 66);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 87);
            this.panel6.TabIndex = 5;
            // 
            // signout
            // 
            this.signout.Dock = System.Windows.Forms.DockStyle.Top;
            this.signout.FlatAppearance.BorderSize = 0;
            this.signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signout.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signout.Image = global::ProgramNew.Properties.Resources.log_out_solid_24;
            this.signout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signout.Location = new System.Drawing.Point(0, 20);
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(175, 55);
            this.signout.TabIndex = 3;
            this.signout.Text = "           Sign out";
            this.signout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signout.UseVisualStyleBackColor = true;
            this.signout.Click += new System.EventHandler(this.signout_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "       ACCOUNT PAGES";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "         Roster";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btstatus
            // 
            this.btstatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btstatus.BackgroundImage")));
            this.btstatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btstatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btstatus.FlatAppearance.BorderSize = 0;
            this.btstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btstatus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btstatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btstatus.Location = new System.Drawing.Point(0, 279);
            this.btstatus.Name = "btstatus";
            this.btstatus.Size = new System.Drawing.Size(175, 43);
            this.btstatus.TabIndex = 10;
            this.btstatus.Text = "         Status";
            this.btstatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btstatus.UseVisualStyleBackColor = true;
            // 
            // btleave
            // 
            this.btleave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btleave.BackgroundImage")));
            this.btleave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btleave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btleave.FlatAppearance.BorderSize = 0;
            this.btleave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btleave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btleave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btleave.Location = new System.Drawing.Point(0, 240);
            this.btleave.Name = "btleave";
            this.btleave.Size = new System.Drawing.Size(175, 39);
            this.btleave.TabIndex = 9;
            this.btleave.Text = "         Leave apply";
            this.btleave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btleave.UseVisualStyleBackColor = true;
            this.btleave.Click += new System.EventHandler(this.btleave_Click);
            // 
            // btemployee
            // 
            this.btemployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btemployee.FlatAppearance.BorderSize = 0;
            this.btemployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btemployee.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btemployee.Image = global::ProgramNew.Properties.Resources.user_regular_24;
            this.btemployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btemployee.Location = new System.Drawing.Point(0, 184);
            this.btemployee.Name = "btemployee";
            this.btemployee.Size = new System.Drawing.Size(175, 56);
            this.btemployee.TabIndex = 8;
            this.btemployee.Text = "         Employee";
            this.btemployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btemployee.UseVisualStyleBackColor = true;
            this.btemployee.Click += new System.EventHandler(this.btemployee_Click);
            // 
            // btdashboard
            // 
            this.btdashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.btdashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btdashboard.BackgroundImage")));
            this.btdashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btdashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btdashboard.FlatAppearance.BorderSize = 0;
            this.btdashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdashboard.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdashboard.Location = new System.Drawing.Point(0, 144);
            this.btdashboard.Name = "btdashboard";
            this.btdashboard.Size = new System.Drawing.Size(175, 40);
            this.btdashboard.TabIndex = 7;
            this.btdashboard.Text = "         Dashboard";
            this.btdashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdashboard.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 144);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toys";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "GF";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(175, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 596);
            this.panel3.TabIndex = 1;
            // 
            // EmployeeDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 596);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDashBoard";
            this.Text = "EmployeeDashBoard";
            this.Load += new System.EventHandler(this.EmployeeDashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btstatus;
        private System.Windows.Forms.Button btleave;
        private System.Windows.Forms.Button btemployee;
        private System.Windows.Forms.Button btdashboard;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button signout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}