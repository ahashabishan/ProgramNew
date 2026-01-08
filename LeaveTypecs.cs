using ProgramNew.LibaryCode;
using ProgramNew.LibraryCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew
{
    public partial class LeaveTypecs : Form
    {
        LeaveTypeClass type = new LeaveTypeClass();

        buttonfunction bt = new buttonfunction();
        public LeaveTypecs()
        {
            InitializeComponent();
            type.Leavegridviewbox = leavedataview;
        }

        private void LeaveTypecs_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            type.LeaveID =int.Parse( LeaveIDtextBox.Text);
            type.LeaveName= leavename.Text;
            type.insert();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            type.LeaveID = int.Parse(LeaveIDtextBox.Text);
            type.Leavetypeid = int.Parse(leavetypeid.Text);
            type.LeaveName = leavename.Text;
            type.Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            type.Leavetypeid = int.Parse(leavetypeid.Text);
            type.Delete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leavename.Clear();
            leavetypeid.Clear();
            LeaveIDtextBox.Clear();
        }
    }
    
}
