namespace ProgramNew
{
    partial class Role
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
            this.DELETEROLE = new System.Windows.Forms.Button();
            this.UPDATEROLE = new System.Windows.Forms.Button();
            this.INSERTROLE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rolenametextbox = new System.Windows.Forms.TextBox();
            this.roleidtextbox = new System.Windows.Forms.TextBox();
            this.roleview = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.CLEAR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.roleview)).BeginInit();
            this.SuspendLayout();
            // 
            // DELETEROLE
            // 
            this.DELETEROLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETEROLE.Location = new System.Drawing.Point(363, 217);
            this.DELETEROLE.Name = "DELETEROLE";
            this.DELETEROLE.Size = new System.Drawing.Size(75, 36);
            this.DELETEROLE.TabIndex = 15;
            this.DELETEROLE.Text = "Delete";
            this.DELETEROLE.UseVisualStyleBackColor = true;
            this.DELETEROLE.Click += new System.EventHandler(this.DELETEROLE_Click);
            // 
            // UPDATEROLE
            // 
            this.UPDATEROLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATEROLE.Location = new System.Drawing.Point(193, 217);
            this.UPDATEROLE.Name = "UPDATEROLE";
            this.UPDATEROLE.Size = new System.Drawing.Size(81, 36);
            this.UPDATEROLE.TabIndex = 14;
            this.UPDATEROLE.Text = "Update";
            this.UPDATEROLE.UseVisualStyleBackColor = true;
            this.UPDATEROLE.Click += new System.EventHandler(this.UPDATEROLE_Click);
            // 
            // INSERTROLE
            // 
            this.INSERTROLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSERTROLE.Location = new System.Drawing.Point(33, 217);
            this.INSERTROLE.Name = "INSERTROLE";
            this.INSERTROLE.Size = new System.Drawing.Size(75, 36);
            this.INSERTROLE.TabIndex = 13;
            this.INSERTROLE.Text = "Insert";
            this.INSERTROLE.UseVisualStyleBackColor = true;
            this.INSERTROLE.Click += new System.EventHandler(this.INSERTROLE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Role Name ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Role ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rolenametextbox
            // 
            this.rolenametextbox.Location = new System.Drawing.Point(136, 55);
            this.rolenametextbox.Name = "rolenametextbox";
            this.rolenametextbox.Size = new System.Drawing.Size(193, 22);
            this.rolenametextbox.TabIndex = 18;
            // 
            // roleidtextbox
            // 
            this.roleidtextbox.Location = new System.Drawing.Point(136, 101);
            this.roleidtextbox.Name = "roleidtextbox";
            this.roleidtextbox.Size = new System.Drawing.Size(193, 22);
            this.roleidtextbox.TabIndex = 19;
            this.roleidtextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // roleview
            // 
            this.roleview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roleview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roleview.Location = new System.Drawing.Point(0, 329);
            this.roleview.Name = "roleview";
            this.roleview.RowHeadersWidth = 51;
            this.roleview.RowTemplate.Height = 24;
            this.roleview.Size = new System.Drawing.Size(695, 256);
            this.roleview.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Role From";
            // 
            // CLEAR
            // 
            this.CLEAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLEAR.Location = new System.Drawing.Point(553, 217);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(75, 36);
            this.CLEAR.TabIndex = 22;
            this.CLEAR.Text = "Clear";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-8, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 12);
            this.panel1.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Role Details";
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(695, 585);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roleview);
            this.Controls.Add(this.roleidtextbox);
            this.Controls.Add(this.rolenametextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DELETEROLE);
            this.Controls.Add(this.UPDATEROLE);
            this.Controls.Add(this.INSERTROLE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Role";
            this.Text = "Role";
            this.Load += new System.EventHandler(this.Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roleview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DELETEROLE;
        private System.Windows.Forms.Button UPDATEROLE;
        private System.Windows.Forms.Button INSERTROLE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rolenametextbox;
        private System.Windows.Forms.TextBox roleidtextbox;
        private System.Windows.Forms.DataGridView roleview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}