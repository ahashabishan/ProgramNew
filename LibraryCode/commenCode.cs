using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew.ProjectCode
{
    internal class commenCode
    {
        public void loginfun()
        {

            Application.Exit();
        
        }

        public void minimized(Form formname)
        {
            formname.WindowState = FormWindowState.Minimized;
        }

        public void loadinside(Form formName, Panel panelName)
        {
            //cleare constrols first
            panelName.Controls.Clear();

            //add controls
            formName.TopLevel = false;
            formName.AutoScroll = true;
            panelName.Controls.Add(formName);
            formName.Dock=DockStyle.Fill;
            formName.Show();

        }
            

    }
}
