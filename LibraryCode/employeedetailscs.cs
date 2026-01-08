using ProgramNew.LibaryCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgramNew.LibraryCode
{
    internal class employeedetails
    {
        internal int EmployeeID { get; set; }
        internal string Employee_name { get; set; }
        internal int NIC { get; set; }
        internal string Em_Adderss { get; set; }
        internal int Phone_Number { get; set; }
        internal int Em_Password { get; set; }
        internal string Gender { get; set; }
        internal string Role { get; set; }


        internal DataGridView employeedatagtidview { get; set; }



        buttonfunction Buttonfunction = new buttonfunction();


        internal void employeedatagtidviewfun()
        {
            Buttonfunction.LoadDataIngridview("SELECT * FROM Empoloyee ", employeedatagtidview);
        }

        internal bool INSERT()
        {
            bool myRet = false;
            string sql = $"INSERT INTO Employee (Employee_name,NIC,Gender,Phone_number,Em_Addrass,Em_password) VALUES ('{Employee_name}','{NIC}','{Gender}','{Phone_Number}','{Em_Adderss}','{Em_Password}')";


            if (buttonfunction.insert(sql))
            {
                employeedatagtidviewfun();
                myRet = true;
            }
            return myRet;
        }

        internal bool Update()
        {
            bool myRet = false;
            string sql = $"UPDATE Employee SET Employeename  = '{Employee_name}',NIC = '{NIC}'1,Em_Addrass = '{Em_Adderss}',Phone_number = '{Phone_Number}',Em_password = '{Em_Password}',Gender ='{Gender} ' where EmpoloyeeID = '{EmployeeID}'";
                


            if (buttonfunction.update(sql))
            {
                employeedatagtidviewfun();
                myRet = true;
            }
            return myRet;
        }
        internal bool Delete()
        {
            bool myRet = false;
            string sql = $"DELETE FROM Employee WHERE Employee_ID = '{EmployeeID}'";
            if (buttonfunction.delete(sql))
            {
                employeedatagtidviewfun();
                myRet = true;
            }
            return myRet;
        }
        internal void Clear()
        {
            EmployeeID = 0;
            Employee_name = string.Empty;
            Phone_Number = 0;
            Em_Adderss = string.Empty;
            NIC = 0;
            Em_Password = 0;
            Gender = string.Empty;
            

            if (employeedatagtidview != null)
            {
                employeedatagtidview.DataSource = null;
            }



        }



    } 
}
