using ProgramNew.LibaryCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew.LibraryCode
{
    internal class Jobclass
    {
        internal string JobName { get; set; }
        internal int JobIDnew { get; set; }
        internal int EmployeeIDnew { get; set; }

        buttonfunction Buttonfunction = new buttonfunction();
        internal DataGridView Jobgridviewbox { get; set; }

        buttonfunction buttonfunction = new buttonfunction();

        internal void Jobgridviewboxfun()
        {

            buttonfunction.LoadDataIngridview("SELECT * FROM  Job ", Jobgridviewbox);
        }

        internal bool insert()
        {
            bool myRet = false;
            string sql = $"INSERT INTO Job  (Job_name,Employeeid) VALUES ('{JobName}','{EmployeeIDnew}')";



            if (buttonfunction.insert(sql))
            {
                Jobgridviewboxfun();
                myRet = true;
            }
            return myRet;
        }

        internal bool Update()
        {
            bool myRet = false;
            string sql = $"UPDATE Job SET Job_name  = '{JobName}',Employeeid= '{EmployeeIDnew}'  WHERE Job_ID = '{JobIDnew}' ";



            if (buttonfunction.update(sql))
            {
                Jobgridviewboxfun();
                myRet = true;
            }
            return myRet;
        }
        internal bool Delete()
        {
            bool myRet = false;
            string sql = $"DELETE FROM Job WHERE Job_ID = '{JobIDnew}'";
            if (buttonfunction.delete(sql))
            {
                Jobgridviewboxfun();
                myRet = true;
            }
            return myRet;
        }
        internal void Clear()
        {
            JobIDnew = 0;
            JobName = string.Empty;
            EmployeeIDnew = 0;






            if (Jobgridviewbox != null)
            {
                Jobgridviewbox.DataSource = null;
            }



        }
    }
}
