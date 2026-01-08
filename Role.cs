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
    public partial class Role : Form
    {
        RoleClass role = new RoleClass();

        buttonfunction buttonfunction = new buttonfunction();

        public Role()
        {
            InitializeComponent();
            role.Rolegridviewbox = roleview;
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void Roleinsert_Click(object sender, EventArgs e)
        {

        }

        private void Roledelete_Click(object sender, EventArgs e)
        {

        }

        private void Roleupdate_Click(object sender, EventArgs e)
        {

        }

        private void Role_Load(object sender, EventArgs e)
        {

        }

        private void INSERTROLE_Click(object sender, EventArgs e)
        {
            role.RoleName = rolenametextbox.Text;
            role.insert();
        }

        private void UPDATEROLE_Click(object sender, EventArgs e)
        {
            role.RoleName = rolenametextbox.Text;
            role.RoleID = int.Parse(roleidtextbox.Text);
            role.Update();
        }

        private void DELETEROLE_Click(object sender, EventArgs e)
        {
            role.RoleID = int.Parse(roleidtextbox.Text);
            role.Delete();
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            roleidtextbox.Clear();
            rolenametextbox.Clear();
        }
    }
}
