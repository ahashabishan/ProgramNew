using ProgramNew.ProjectCode;
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
    public partial class EmployeeDashBoard : Form
    {
        commenCode design = new commenCode();
        public EmployeeDashBoard()
        {
            InitializeComponent();
        }

        private void EmployeeDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btleave_Click(object sender, EventArgs e)
        {
            Request requestpage = new Request();
            design.loadinside(requestpage, panel3);
        }

        private void btemployee_Click(object sender, EventArgs e)
        {
            EM employee = new EM();
            design.loadinside(employee, panel3);
        }

        private void signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginfrom loginform = new Loginfrom();
            loginform.Show();
        }
    }
    
}
