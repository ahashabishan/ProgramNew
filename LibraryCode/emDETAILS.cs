using ProgramNew.LibaryCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew.LibraryCode
{
    internal class emDETAILS
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
    }
}
