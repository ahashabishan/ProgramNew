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
using System.Xml.Linq;

namespace ProgramNew
{
    public partial class Request : Form
    {
        Requestclass rq = new Requestclass();

        buttonfunction function = new buttonfunction(); 
        public Request()
        {
            InitializeComponent();
            rq.Requestgtidview = RQviwe;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Requestinsert_Click(object sender, EventArgs e)
        {
           
        }

       

        private void insertrq_Click(object sender, EventArgs e)
        {
            rq.LeaveID = int.Parse(LeaveIDtextbox.Text);
            rq.Leavetype = leavetextbox.Text;
            rq.Reason = reasontextbox.Text;
            rq.StartDate = int.Parse(startdatetextbox.Text);
            rq.EndDate= int.Parse(enddatetextbox.Text);
            rq.Insert();
        }

        private void updaterq_Click(object sender, EventArgs e)
        {
            rq.LeaveID = int.Parse(LeaveIDtextbox.Text);
            rq.Leavetype = leavetextbox.Text;
            rq.Reason = reasontextbox.Text;
            rq.StartDate = int.Parse(startdatetextbox.Text);
            rq.EndDate = int.Parse(enddatetextbox.Text);
            rq.RequstID = int.Parse(RequestIDtextbox.Text);
            rq.Update();
        }

        private void deleterq_Click(object sender, EventArgs e)
        {
            rq.RequstID = int.Parse(RequestIDtextbox.Text);
            rq.Delete();
        }

        private void clearrq_Click(object sender, EventArgs e)
        {
            leavetextbox.Clear();
            LeaveIDtextbox.Clear();
            reasontextbox.Clear(); 
            startdatetextbox.Clear();
            enddatetextbox.Clear();
            reasontextbox.Clear();
        }

        private void RQviwe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = RQviwe.Rows[e.RowIndex];
                reasontextbox.Text = row.Cells["Leave_Reason"].Value.ToString();
                leavetextbox.Text = row.Cells["[Leave Type]"].Value.ToString();
                LeaveIDtextbox.Text = row.Cells["Leave_ID"].Value.ToString();
                startdatetextbox.Text = row.Cells["start_date"].Value.ToString();
                enddatetextbox.Text = row.Cells["end_date"].Value.ToString();
                RequestIDtextbox.Text = row.Cells["Request_ID"].Value.ToString();

            }
        }
    }
}
