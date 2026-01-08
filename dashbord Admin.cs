using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramNew.ProjectCode;

namespace ProgramNew
{
   
    public partial class dashbord : Form
    {
        commenCode design = new commenCode();
        public dashbord()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void board_Click(object sender, EventArgs e)
        {
            DashboardandsummaryForm2 dashbord = new DashboardandsummaryForm2();
            design.loadinside(dashbord, panel2);

        }

        private void employee_Click(object sender, EventArgs e)
        {
           Employeedetails loginForm = new Employeedetails();   
            design.loadinside(loginForm, panel2);
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void btleavetype_Click(object sender, EventArgs e)
        {
            LeaveTypecs leavetypepage = new LeaveTypecs();      
            design.loadinside(leavetypepage,panel2);

        }

        private void btrequest_Click(object sender, EventArgs e)
        {
            AdminRequset requestpage = new AdminRequset();
             design.loadinside(requestpage,panel2);
        }

        private void btstatus_Click(object sender, EventArgs e)
        {
            status statuspage = new status();
            design.loadinside(statuspage,panel2);

        }

        private void btjob_Click(object sender, EventArgs e)
        {
            Job jobpage = new Job();    
            design.loadinside(jobpage,panel2);

        }

        private void Rolebutton_Click(object sender, EventArgs e)
        {
            Role Rolepage = new Role();
            design.loadinside(Rolepage, panel2);

        }

        private void departmentbotton_Click(object sender, EventArgs e)
        {
            Department Depatmentpage = new Department();
            design.loadinside(Depatmentpage, panel2);
        }

        private void btleave_Click(object sender, EventArgs e)
        {
            Leave leavepage = new Leave();
            design.loadinside(leavepage, panel2);
        }

        private void rostebutton_Click(object sender, EventArgs e)
        {
            Roste Rostepage = new Roste();
            design.loadinside(Rostepage, panel2);
        }

       

        private void btsignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginfrom loginform = new Loginfrom();
            loginform.Show();       
        }

        private void Logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
