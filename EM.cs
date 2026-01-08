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
    public partial class EM : Form
    {
        emDETAILS emp = new emDETAILS();

        buttonfunction buttonfunction = new buttonfunction();
        public EM()
        {
            InitializeComponent();
            emp.employeedatagtidview = EmployeeDatagrdview;
        }

        private void Employeeinsert_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeDatagrdview_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
