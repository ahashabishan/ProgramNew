using ProgramNew.LibaryCode;
using ProgramNew.LibraryCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew
{
    public partial class Roste : Form
    {

         Roaster ro = new Roaster();
        buttonfunction bt = new buttonfunction();
        public Roste()
        {
            InitializeComponent();
            ro.Roasterview = roasterdataview;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       




        private void Roste_Load(object sender, EventArgs e)
        {

        }

        private void insertroast_Click(object sender, EventArgs e)
        {
            ro.starttime = int.Parse(starttimetextbox.Text);
            ro.endtime = int.Parse(endtimetextbox.Text);
            ro.halfday = int.Parse(halfdaytextbox.Text);
            ro.offday = int.Parse(offdaytextbox.Text);
            ro.leavetype = Leavetype.Text;
            ro.Insert();
        }

        private void roasterdataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = roasterdataview.Rows[e.RowIndex];
                roastID.Text = row.Cells["Roast_ID_PK"].Value.ToString();
                starttimetextbox.Text = row.Cells["start_time"].Value.ToString();
                endtimetextbox.Text = row.Cells["End_time"].Value.ToString();
                halfdaytextbox.Text = row.Cells["Half_day"].Value.ToString();
                offdaytextbox.Text = row.Cells["Off_day"].Value.ToString();
                Leavetype.Text = row.Cells["Leavetype"].Value.ToString();

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void updatero_Click(object sender, EventArgs e)
        {
            ro.Roasteridnew = int.Parse(roastID.Text);
            ro.starttime = int.Parse(starttimetextbox.Text);
            ro.endtime = int.Parse(endtimetextbox.Text);
            ro.halfday = int.Parse(halfdaytextbox.Text);
            ro.offday = int.Parse(offdaytextbox.Text);
            ro.leavetype = Leavetype.Text;
            ro.Update();
        }

        private void deletero_Click(object sender, EventArgs e)
        {
            ro.Roasteridnew = int.Parse(roasterdataview.Text);
            ro.Delete();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            roastID.Clear();
            starttimetextbox.Clear();
            endtimetextbox.Clear();
            halfdaytextbox.Clear();
            offdaytextbox.Clear();
            Leavetype.Clear();

        }
    }
}
