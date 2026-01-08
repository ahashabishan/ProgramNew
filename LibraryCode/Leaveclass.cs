using ProgramNew.LibaryCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew.LibraryCode
{
    internal class Leaveclass
    {
        internal int LeaveID { get; set; }
        internal int ReminingLeavenew { get; set; }
        internal int EmployeeID { get; set; }
        internal int NumberOfLeavenew { get; set; }

        internal string leavetype { get; set; }



        buttonfunction Buttonfunction = new buttonfunction();
        internal DataGridView Leavegridviewbox { get; set; }

        buttonfunction buttonfunction = new buttonfunction();

        internal void Leavegridviewboxfun()
        {

            buttonfunction.LoadDataIngridview("SELECT * FROM  Department ", Leavegridviewbox);
        }

       
    }
}
