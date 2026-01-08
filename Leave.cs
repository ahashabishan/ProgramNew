using ProgramNew.LibaryCode;
using ProgramNew.LibraryCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew
{
    public partial class Leave : Form
    {
        Leaveclass lev = new Leaveclass();
        buttonfunction bep = new buttonfunction();
        public Leave()
        {
            InitializeComponent();
            lev.Leavegridviewbox = employeeVIEW;
        }

        

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Leave_Load(object sender, EventArgs e)
        {

        }

      

       

        private void employeeVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rowindex = e.RowIndex;
            leaveIDtextBox.Text = employeeVIEW.Rows[Rowindex].Cells[0].Value.ToString();
            employeeidtextBox.Text = employeeVIEW.Rows[Rowindex].Cells[1].Value.ToString();
            reminingLeavetextBox.Text = employeeVIEW.Rows[Rowindex].Cells[3].Value.ToString();
            NumberofleavetextBox.Text = employeeVIEW.Rows[Rowindex].Cells[4].Value.ToString();
        }
    }
}
