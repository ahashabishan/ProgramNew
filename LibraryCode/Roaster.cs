using ProgramNew.LibaryCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew.LibraryCode
{
    internal class Roaster
    {
        internal int Roasteridnew { get; set; }
        internal int starttime{ get; set; }
        internal int endtime { get; set; }
        internal int halfday { get; set; }
        internal int offday { get; set; }
        internal string leavetype { get; set; }

       


        internal DataGridView Roasterview { get; set; }



        buttonfunction Buttonfunction = new buttonfunction();


        internal void Requstgtidviewfun()
        {
            Buttonfunction.LoadDataIngridview("SELECT * FROM Roast ", Roasterview);
        }

        internal bool Insert()
        {
            bool myRet = false;
            string sql = $"INSERT INTO Roast (start_time,End_time,Half_day,Off_day,Leavetype) VALUES ('{starttime}','{endtime}','{halfday}','{offday}','{leavetype}')";



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
            string sql = $"UPDATE Roast SET start_time = '{starttime}',End_time = '{endtime}',Half_day ='{halfday}',Off_day = '{offday}',Leavetype = '{leavetype}'  WHERE  Roast_ID_PK = '{Roasteridnew}' ";



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
            string sql = $"DELETE FROM Roast WHERE Roast_ID_PK = '{Roasteridnew}'";
            if (buttonfunction.delete(sql))
            {
                Requstgtidviewfun();
                myRet = true;
            }
            return myRet;
        }
        internal void Clear()
        {
            Roasteridnew = 0;
            starttime = 0;
            endtime = 0;
            halfday = 0;
            offday = 0;
            leavetype = string.Empty;





            if (Roasterview != null)
            {
                Roasterview.DataSource = null;
            }



        }
    }
}
