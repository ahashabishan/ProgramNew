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

    public partial class Job : Form
    {
        buttonfunction buttonfunction = new buttonfunction();

        Jobclass job = new Jobclass();
        public Job()
        {
            InitializeComponent();
            job.Jobgridviewbox = JobView;
        }

        

      

        private void Job_Load(object sender, EventArgs e)
        {
            
        }

       

       





        private void label1_Click(object sender, EventArgs e)
        {

        }

       
      

        private void insertJOB_Click(object sender, EventArgs e)
        {
            job.JobName = jobnametextbox.Text;
            job.EmployeeIDnew = int.Parse(EmployeeIDtextBox.Text);
            job.insert();
        }

        private void UPDATEJOB_Click(object sender, EventArgs e)
        {
            job.JobName = jobnametextbox.Text;
            job.JobIDnew = int.Parse(jobIDtextBox.Text);
            job.EmployeeIDnew = int.Parse(EmployeeIDtextBox.Text);
            job.Update();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            
            job.JobIDnew = int.Parse(jobIDtextBox.Text);
            job.Delete();
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            jobIDtextBox.Clear();
            jobnametextbox.Clear();
            EmployeeIDtextBox.Clear();
        }

        private void JobView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rowindex = e.RowIndex;
            jobnametextbox.Text = JobView.Rows[Rowindex].Cells[0].Value.ToString();
            jobIDtextBox.Text = JobView.Rows[Rowindex].Cells[1].Value.ToString();
            EmployeeIDtextBox.Text = JobView.Rows[Rowindex].Cells[2].Value.ToString();

        }
    }
}
