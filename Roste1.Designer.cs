namespace ProgramNew
{
    partial class Roste
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
            this.endtimetextbox = new System.Windows.Forms.TextBox();
            this.starttimetextbox = new System.Windows.Forms.TextBox();
            this.roastID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deletero = new System.Windows.Forms.Button();
            this.updatero = new System.Windows.Forms.Button();
            this.insertroast = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.halfdaytextbox = new System.Windows.Forms.TextBox();
            this.offdaytextbox = new System.Windows.Forms.TextBox();
            this.roasterdataview = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Leavetype = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.roasterdataview)).BeginInit();
            this.SuspendLayout();
            // 
            // endtimetextbox
            // 
            this.endtimetextbox.Location = new System.Drawing.Point(114, 136);
            this.endtimetextbox.Name = "endtimetextbox";
            this.endtimetextbox.Size = new System.Drawing.Size(193, 22);
            this.endtimetextbox.TabIndex = 28;
            this.endtimetextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // starttimetextbox
            // 
            this.starttimetextbox.Location = new System.Drawing.Point(114, 93);
            this.starttimetextbox.Name = "starttimetextbox";
            this.starttimetextbox.Size = new System.Drawing.Size(193, 22);
            this.starttimetextbox.TabIndex = 29;
            this.starttimetextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // roastID
            // 
            this.roastID.Location = new System.Drawing.Point(114, 49);
            this.roastID.Name = "roastID";
            this.roastID.Size = new System.Drawing.Size(193, 22);
            this.roastID.TabIndex = 27;
            this.roastID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "End time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Start time ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Roaste ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // deletero
            // 
            this.deletero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletero.Location = new System.Drawing.Point(356, 229);
            this.deletero.Name = "deletero";
            this.deletero.Size = new System.Drawing.Size(75, 36);
            this.deletero.TabIndex = 23;
            this.deletero.Text = "Delete";
            this.deletero.UseVisualStyleBackColor = true;
            this.deletero.Click += new System.EventHandler(this.deletero_Click);
            // 
            // updatero
            // 
            this.updatero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatero.Location = new System.Drawing.Point(186, 229);
            this.updatero.Name = "updatero";
            this.updatero.Size = new System.Drawing.Size(85, 36);
            this.updatero.TabIndex = 22;
            this.updatero.Text = "Update";
            this.updatero.UseVisualStyleBackColor = true;
            this.updatero.Click += new System.EventHandler(this.updatero_Click);
            // 
            // insertroast
            // 
            this.insertroast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertroast.Location = new System.Drawing.Point(14, 230);
            this.insertroast.Name = "insertroast";
            this.insertroast.Size = new System.Drawing.Size(75, 36);
            this.insertroast.TabIndex = 21;
            this.insertroast.Text = "Insert";
            this.insertroast.UseVisualStyleBackColor = true;
            this.insertroast.Click += new System.EventHandler(this.insertroast_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Half day";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Off day";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // halfdaytextbox
            // 
            this.halfdaytextbox.Location = new System.Drawing.Point(472, 52);
            this.halfdaytextbox.Name = "halfdaytextbox";
            this.halfdaytextbox.Size = new System.Drawing.Size(193, 22);
            this.halfdaytextbox.TabIndex = 28;
            this.halfdaytextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // offdaytextbox
            // 
            this.offdaytextbox.Location = new System.Drawing.Point(472, 99);
            this.offdaytextbox.Name = "offdaytextbox";
            this.offdaytextbox.Size = new System.Drawing.Size(193, 22);
            this.offdaytextbox.TabIndex = 28;
            this.offdaytextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // roasterdataview
            // 
            this.roasterdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roasterdataview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roasterdataview.Location = new System.Drawing.Point(0, 329);
            this.roasterdataview.Name = "roasterdataview";
            this.roasterdataview.RowHeadersWidth = 51;
            this.roasterdataview.RowTemplate.Height = 24;
            this.roasterdataview.Size = new System.Drawing.Size(695, 256);
            this.roasterdataview.TabIndex = 30;
            this.roasterdataview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roasterdataview_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(263, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Roaste From";
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(530, 229);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 37);
            this.clear.TabIndex = 32;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-8, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 12);
            this.panel1.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(263, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Roaste Detalis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(352, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Leave Type";
            // 
            // Leavetype
            // 
            this.Leavetype.Location = new System.Drawing.Point(472, 150);
            this.Leavetype.Name = "Leavetype";
            this.Leavetype.Size = new System.Drawing.Size(193, 22);
            this.Leavetype.TabIndex = 51;
            this.Leavetype.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Roste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(695, 585);
            this.Controls.Add(this.Leavetype);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.roasterdataview);
            this.Controls.Add(this.offdaytextbox);
            this.Controls.Add(this.halfdaytextbox);
            this.Controls.Add(this.endtimetextbox);
            this.Controls.Add(this.starttimetextbox);
            this.Controls.Add(this.roastID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletero);
            this.Controls.Add(this.updatero);
            this.Controls.Add(this.insertroast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Roste";
            this.Text = "Roste";
            this.Load += new System.EventHandler(this.Roste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roasterdataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox endtimetextbox;
        private System.Windows.Forms.TextBox starttimetextbox;
        private System.Windows.Forms.TextBox roastID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deletero;
        private System.Windows.Forms.Button updatero;
        private System.Windows.Forms.Button insertroast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox halfdaytextbox;
        private System.Windows.Forms.TextBox offdaytextbox;
        private System.Windows.Forms.DataGridView roasterdataview;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Leavetype;
    }
}