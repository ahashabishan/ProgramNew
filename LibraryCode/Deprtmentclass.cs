using ProgramNew.LibaryCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew.LibraryCode
{
    internal class Deprtmentclass
    {
        internal string DepartmentName {get;set;}
        internal int DepartmentID { get; set; }
        internal int EmployeeID { get; set; }

       
        internal DataGridView Departmentgridviewbox { get; set; }

        buttonfunction buttonfunction = new buttonfunction();

        internal void Departmentgridviewboxfun()
        {

            buttonfunction.LoadDataIngridview("SELECT * FROM  Department ", Departmentgridviewbox);
        }

        internal bool insert()
        {
            bool myRet = false;
            string sql = $"INSERT INTO Department (DepartmentName,EmployeeID) VALUES ('{DepartmentName}','{EmployeeID}')";



            if (buttonfunction.insert(sql))
            {
                Departmentgridviewboxfun();
                myRet = true;
            }
            return myRet;
        }

        internal bool Update()
        {
            bool myRet = false;
            string sql = $"UPDATE Department SET DepartmentName  = '{DepartmentName}',Employee_ID_PK= '{EmployeeID} '  WHERE DepartmentID = '{DepartmentID}'";



            if (buttonfunction.update(sql))
            {
                Departmentgridviewboxfun();
                myRet = true;
            }
            return myRet;
        }
        internal bool Delete()
        {
            bool myRet = false;
            string sql = $"DELETE FROM Department WHERE DepartmentID = '{DepartmentID}'";
            if (buttonfunction.delete(sql))
            {
                Departmentgridviewboxfun();
                myRet = true;
            }
            return myRet;
        }
        internal void Clear()
        {
            DepartmentID = 0;
            DepartmentName = string.Empty;
            DepartmentID = 0;






            if (Departmentgridviewbox != null)
            {
                Departmentgridviewbox.DataSource = null;
            }



        }



    }
}




    

