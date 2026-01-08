using ProgramNew.LibaryCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew.LibraryCode
{
    internal class Requestclass
    {
        internal int RequstID { get; set; }
        internal int LeaveID { get; set; }
        internal string Leavetype { get; set; }
        internal int StartDate { get; set; }
        internal int EndDate { get; set; }
        internal string Reason { get; set; }

        internal string Status { get; set; }


        internal DataGridView Requestgtidview { get; set; }



        buttonfunction Buttonfunction = new buttonfunction();


        internal void Requstgtidviewfun()
        {
            Buttonfunction.LoadDataIngridview("SELECT * FROM Requst ", Requestgtidview);
        }

        internal bool Insert()
        {
            bool myRet = false;
            string sql = $"INSERT INTO Request  (Leave_ID,start_date,end_date,Leave_Reason,Status,[Leave Type]') VALUES ('{LeaveID}','{StartDate}','{EndDate}','{Reason}','{Status}','{Leavetype}')";



            if (buttonfunction.insert(sql))
            {
                Requstgtidviewfun();
                myRet = true;
            }
            return myRet;
        }
        internal bool Update()
        {
            bool myRet = false;
            string sql = $"UPDATE Request SET Leave_ID = {LeaveID},[Leave Type] = '{Leavetype}',start_date = '{StartDate}',end_date = '{EndDate}',Leave_Reason ='{Reason}',Status = '{Status}' WHERE Requs_ID = '{RequstID}'";



            if (buttonfunction.update(sql))
            {
                Requstgtidviewfun();
                myRet = true;
            }
            return myRet;
        }
        internal bool Delete()
        {
            bool myRet = false;
            string sql = $"DELETE FROM Requst WHERE Requs_ID = '{RequstID}'";
            if (buttonfunction.delete(sql))
            {
                Requstgtidviewfun();
                myRet = true;
            }
            return myRet;
        }
        internal void Clear()
        {
            RequstID = 0;
            LeaveID = 0;
            StartDate = 0;
            EndDate = 0;
            Reason = string.Empty;
            Leavetype = string.Empty;

            
            


            if (Requestgtidview != null)
            {
                Requestgtidview.DataSource = null;
            }



        }
    }
}
