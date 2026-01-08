using ProgramNew.LibaryCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew.LibraryCode
{
    internal class Statusclass
    {
        internal int statusid  { get; set; }
        internal string status { get; set; }
        

        buttonfunction Buttonfunction = new buttonfunction();
        internal DataGridView Statusgridviewbox { get; set; }

        buttonfunction buttonfunction = new buttonfunction();

        internal void Statusgridviewboxfun()
        {

            buttonfunction.LoadDataIngridview("SELECT * FROM  Status ", Statusgridviewbox);
        }

        internal bool Insert()
        {
            bool myRet = false;
            string sql = $"insert into Status (Status) values ('{status}')";



            if (buttonfunction.insert(sql))
            {
                Statusgridviewboxfun();
                myRet = true;
            }
            return myRet;
        }

        internal bool Update()
        {   
            bool myRet = false;
            string sql = $"UPDATE Staus SET Status = '{status}' WHERE StatusID = '{statusid}'";



            if (buttonfunction.update(sql))
            {
                Statusgridviewboxfun();
                myRet = true;
            }
            return myRet;
        }
        internal bool Delete()
        {
            bool myRet = false;
            string sql = $"DELETE FROM Status WHERE StatusID = '{status}'";
            if (buttonfunction.delete(sql))
            {
                Statusgridviewboxfun();
                myRet = true;
            }
            return myRet;
        }
        internal void Clear()
        {
            statusid = 0;
            status = string.Empty;
            






            if (Statusgridviewbox != null)
            {
                Statusgridviewbox.DataSource = null;
            }



        }

    }
}
