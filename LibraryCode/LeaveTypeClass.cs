using ProgramNew.LibaryCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew.LibraryCode
{
    internal class LeaveTypeClass
    {
        internal int LeaveID { get; set; }

        internal string LeaveName { get; set; }

        internal int Leavetypeid { get; set; }




        buttonfunction Buttonfunction = new buttonfunction();
        internal DataGridView Leavegridviewbox { get; set; }

        buttonfunction buttonfunction = new buttonfunction();

        internal void Leavegridviewboxfun()
        {

            buttonfunction.LoadDataIngridview("SELECT * FROM  Leave_type ", Leavegridviewbox);
        }

        internal bool insert()
        {
            bool myRet = false;
            string sql = $"INSERT into  Leave_type  (Leave_ID_FK,Leave_type_name) VALUES ('{LeaveID}','{LeaveName}')";




            if (buttonfunction.insert(sql))
            {
                Leavegridviewboxfun();
                myRet = true;
            }
            return myRet;
        }

        internal bool Update()
        {
            bool myRet = false;
            string sql = $"UPDATE Leave_type SET Leave_type_name = '{LeaveName}',Leave_ID_FK = '{LeaveID}'  WHERE Leave_type_ID_PK = '{LeaveID}'";




            if (buttonfunction.update(sql))
            {
                Leavegridviewboxfun();
                myRet = true;
            }
            return myRet;
        }
        internal bool Delete()
        {
            bool myRet = false;
            string sql = $"DELETE FROM Leave_type WHERE LeaveID = '{LeaveID}'";
            if (buttonfunction.delete(sql))
            {
                Leavegridviewboxfun();
                myRet = true;
            }
            return myRet;
        }
        internal void Clear()
        {
            LeaveID = 0;
            LeaveName = string.Empty;
            Leavetypeid = 0;
            
           






            if (Leavegridviewbox != null)
            {
                Leavegridviewbox.DataSource = null;
            }



        }
    }
}
