namespace ProgramNew
{
    partial class status
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
            this.statusbox = new System.Windows.Forms.TextBox();
            this.statusidbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusview = new System.Windows.Forms.DataGridView();
            this.deletestatus = new System.Windows.Forms.Button();
            this.updatestatus = new System.Windows.Forms.Button();
            this.insertstatus = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusview)).BeginInit();
            this.SuspendLayout();
            // 
            // statusbox
            // 
            this.statusbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusbox.Location = new System.Drawing.Point(143, 97);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(193, 22);
            this.statusbox.TabIndex = 50;
            // 
            // statusidbox
            // 
            this.statusidbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusidbox.Location = new System.Drawing.Point(143, 54);
            this.statusidbox.Name = "statusidbox";
            this.statusidbox.Size = new System.Drawing.Size(193, 22);
            this.statusidbox.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Status ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 44;
            // 
            // statusview
            // 
            this.statusview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusview.Location = new System.Drawing.Point(0, 329);
            this.statusview.Name = "statusview";
            this.statusview.RowHeadersWidth = 51;
            this.statusview.RowTemplate.Height = 24;
            this.statusview.Size = new System.Drawing.Size(695, 256);
            this.statusview.TabIndex = 52;
            this.statusview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.statusview_CellContentClick);
            // 
            // deletestatus
            // 
            this.deletestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletestatus.Location = new System.Drawing.Point(379, 216);
            this.deletestatus.Name = "deletestatus";
            this.deletestatus.Size = new System.Drawing.Size(75, 36);
            this.deletestatus.TabIndex = 55;
            this.deletestatus.Text = "Delete";
            this.deletestatus.UseVisualStyleBackColor = true;
            this.deletestatus.Click += new System.EventHandler(this.deletestatus_Click);
            // 
            // updatestatus
            // 
            this.updatestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatestatus.Location = new System.Drawing.Point(196, 216);
            this.updatestatus.Name = "updatestatus";
            this.updatestatus.Size = new System.Drawing.Size(80, 36);
            this.updatestatus.TabIndex = 54;
            this.updatestatus.Text = "Update";
            this.updatestatus.UseVisualStyleBackColor = true;
            this.updatestatus.Click += new System.EventHandler(this.updatestatus_Click);
            // 
            // insertstatus
            // 
            this.insertstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertstatus.Location = new System.Drawing.Point(25, 216);
            this.insertstatus.Name = "insertstatus";
            this.insertstatus.Size = new System.Drawing.Size(75, 36);
            this.insertstatus.TabIndex = 53;
            this.insertstatus.Text = "Insert";
            this.insertstatus.UseVisualStyleBackColor = true;
            this.insertstatus.Click += new System.EventHandler(this.insertstatus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 56;
            this.label5.Text = "Status From";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(568, 216);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 36);
            this.clear.TabIndex = 57;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-8, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 12);
            this.panel1.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 25);
            this.label6.TabIndex = 59;
            this.label6.Text = "Status Detalis";
            // 
            // status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(695, 585);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deletestatus);
            this.Controls.Add(this.updatestatus);
            this.Controls.Add(this.insertstatus);
            this.Controls.Add(this.statusview);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.statusidbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "status";
            this.Text = "status";
            this.Load += new System.EventHandler(this.status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox statusbox;
        private System.Windows.Forms.TextBox statusidbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView statusview;
        private System.Windows.Forms.Button deletestatus;
        private System.Windows.Forms.Button updatestatus;
        private System.Windows.Forms.Button insertstatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}