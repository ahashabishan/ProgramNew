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
    public partial class status : Form
    {
        Statusclass st = new Statusclass();

        buttonfunction bt = new buttonfunction();
        public status()
        {
            InitializeComponent();
            st.Statusgridviewbox = statusview;
        }

        private void status_Load(object sender, EventArgs e)
        {

        }



        private void insertstatus_Click(object sender, EventArgs e)
        {
            st.status = statusbox.Text;
            st.Insert();
        }

        private void updatestatus_Click(object sender, EventArgs e)
        {
            st.statusid = int.Parse(statusidbox.Text);
            st.status = statusbox.Text;
            st.Update();

        }

        private void statusview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Rowindex = e.RowIndex;
            statusbox.Text = statusview.Rows[Rowindex].Cells[0].Value.ToString();
            statusidbox.Text = statusview.Rows[Rowindex].Cells[1].Value.ToString();
            
        }

        private void deletestatus_Click(object sender, EventArgs e)
        {
            st.statusid = int.Parse(statusidbox.Text);
            st.Delete();
        }
    }
}