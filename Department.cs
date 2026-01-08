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
    public partial class Department : Form
    {
        Deprtmentclass dep = new Deprtmentclass();

        buttonfunction code = new buttonfunction();
        public Department()
        {
            InitializeComponent();
            dep.Departmentgridviewbox = DEDATEGRIDVIEW;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Department_Load(object sender, EventArgs e)
        {
            
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Depa_Click(object sender, EventArgs e)
        {

        }

       





       
       

       

        private void insertde_Click(object sender, EventArgs e)
        {
            
            dep.DepartmentName= departmentname.Text;
            dep.EmployeeID = int.Parse(EmployeeID.Text);
            dep.insert();
        }

        private void updatebuttonde_Click(object sender, EventArgs e)
        {
            dep.DepartmentID = int.Parse(departmentID.Text);
            dep.DepartmentName = departmentname.Text;
            dep.EmployeeID = int.Parse(EmployeeID.Text);
            dep.Update();
        }

        private void deletebuttonde_Click(object sender, EventArgs e)
        {
            dep.DepartmentID = int.Parse(departmentID.Text);
           
            dep.Delete();
        }

        private void clearde_Click(object sender, EventArgs e)
        {
            departmentID.Clear();
            departmentname.Clear();
            EmployeeID.Clear();
        }

        private void DEDATEGRIDVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rowindex = e.RowIndex;
            departmentname.Text = DEDATEGRIDVIEW.Rows[Rowindex].Cells[0].Value.ToString();
            departmentID.Text = DEDATEGRIDVIEW.Rows[Rowindex].Cells[1].Value.ToString();
            EmployeeID.Text = DEDATEGRIDVIEW.Rows[Rowindex].Cells[2].Value.ToString();
        }
    }
}
