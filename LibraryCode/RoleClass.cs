using ProgramNew.LibaryCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew.LibraryCode
{
    internal class RoleClass
    {
        internal string RoleName { get; set; }
        internal int RoleID { get; set; }
        

        buttonfunction Buttonfunction = new buttonfunction();
        internal DataGridView Rolegridviewbox { get; set; }

        buttonfunction buttonfunction = new buttonfunction();

        internal void Rolegridviewboxfun()
        {

            buttonfunction.LoadDataIngridview("SELECT * FROM  Role ", Rolegridviewbox);
        }

        internal bool insert()
        {
            bool myRet = false;
            string sql = $"insert INTO Role RoleName VALUES '{RoleName}'";



            if (buttonfunction.insert(sql))
            {
                Rolegridviewboxfun();
                myRet = true;
            }
            return myRet;
        }

        internal bool Update()
        {
            bool myRet = false;
            string sql = $"UPDATE Role SET RoleName  = '{RoleName}',RoleID = '{RoleID}'   WHERE RoleID = '{RoleID}'";



            if (buttonfunction.update(sql))
            {
                Rolegridviewboxfun();
                myRet = true;
            }
            return myRet;
        }
        internal bool Delete()
        {
            bool myRet = false;
            string sql = $"DELETE FROM Role WHERE RoleID = '{RoleID}'";
            if (buttonfunction.delete(sql))
            {
                Rolegridviewboxfun();
                myRet = true;
            }
            return myRet;
        }
        internal void Clear()
        {
            RoleID = 0;
            RoleName = string.Empty;
           






            if (Rolegridviewbox != null)
            {
                Rolegridviewbox.DataSource = null;
            }



        }
    }
}
