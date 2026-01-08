using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProgramNew.LibaryCode;
using ProgramNew.LibraryCode;

namespace ProgramNew
{
    public partial class Employeedetails : Form
    {
        employeedetails emp = new employeedetails();

        buttonfunction buttonfunction = new buttonfunction();
        public Employeedetails()
        {
            InitializeComponent();
            emp.employeedatagtidview = EmployeeDatagrdview;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Employeeinsert_Click(object sender, EventArgs e)
        {
            
            emp.Employee_name = userNameInputBox.Text;
            emp.Em_Adderss = addressInputBox.Text;
            emp.Em_Password = int.Parse(passwordInputBox.Text);
            emp.Gender = Gendercombobox.Text;
            emp.Role = Rolebox.Text;
            emp.NIC = int.Parse(nicNumberInputBox.Text);
            emp.Phone_Number = int.Parse(phoneNoInputBox.Text);
            emp.INSERT();
        }

        private void UPDATEinsert_Click(object sender, EventArgs e)
        {
            emp.EmployeeID = int.Parse(EmployeeIdInputBox.Text);
            emp.Employee_name = userNameInputBox.Text;
            emp.Em_Adderss = addressInputBox.Text;
            emp.Em_Password = int.Parse(passwordInputBox.Text);
            emp.Gender = Gendercombobox.Text;
            emp.Role = Rolebox.Text;
            emp.NIC = int.Parse(nicNumberInputBox.Text.Trim());
            emp.Phone_Number = int.Parse(phoneNoInputBox.Text.Trim());
            emp.Update();
        }

        private void EMPLOYEEdelete_Click(object sender, EventArgs e)
        {
            emp.EmployeeID = int.Parse(EmployeeIdInputBox.Text);
            emp.Delete();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            EmployeeIdInputBox.Clear();
            userNameInputBox.Clear();
            addressInputBox.Clear();
            passwordInputBox.Clear();
            nicNumberInputBox.Clear();
            phoneNoInputBox.Clear();

        }


        private void EmployeeDatagrdview_Click(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == 0)
            {
                DataGridViewRow row = EmployeeDatagrdview.Rows[e.RowIndex];
                userNameInputBox.Text = row.Cells["Employee_name"].Value.ToString();
                Gendercombobox.Text = row.Cells["Gender"].Value.ToString();
                passwordInputBox.Text = row.Cells["Em_password"].Value.ToString();
                phoneNoInputBox.Text = row.Cells["Phone_number"].Value.ToString();
                nicNumberInputBox.Text = row.Cells["NIC"].Value.ToString();
                Rolebox.Text = row.Cells["Role"].Value.ToString();
                addressInputBox.Text = row.Cells["Em_Addrass"].Value.ToString();
                EmployeeIdInputBox.Text = row.Cells["Employee_ID_PK"].Value.ToString();

            }
        }
    }


}
