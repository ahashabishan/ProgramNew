using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramNew.LibaryCode
{
    internal class buttonfunction
    {
        static SqlConnection dep = new SqlConnection("Data Source=AHASHABISHAN\\SQLEXPRESS;Initial Catalog=HND_SE;Integrated Security=True;Encrypt=False");
        // bool - true false

        internal static bool insert(string sql)

        {
            bool myret = false;
            try
            {
                dep.Open();
                SqlCommand cmd = new SqlCommand(sql, dep);
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    myret = true;
                    MessageBox.Show("Data successfully inserted");

                }
                else
                {
                    MessageBox.Show("Contact IT Department");

                }
                dep.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return myret;

        }

        internal static bool update(string sql)

        {
            bool myret = false;
            try
            {
                if (MessageBox.Show("if you want to update ? ", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dep.Open();
                    SqlCommand cmd = new SqlCommand(sql, dep);
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        myret = true;
                        MessageBox.Show("update successfully ");

                    }
                    else
                    {
                        MessageBox.Show("Contact IT Department");

                    }
                    dep.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return myret;

        }

        internal static bool delete(string sql)

        {
            bool myret = false;
            try
            {
                dep.Open();
                SqlCommand cmd = new SqlCommand(sql, dep);
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    myret = true;
                    MessageBox.Show("delete successfully ");

                }
                else
                {
                    MessageBox.Show("Contact IT Department");

                }
                dep.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return myret;

        }




       
        internal DataTable GetDataTablefromDB(string sql)
        { 
        

            SqlDataAdapter da = new SqlDataAdapter(sql,dep);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            return dataTable;

        }
        



        internal void LoadDataIngridview(string sql,DataGridView dataGridView)
        {
            dataGridView.DataSource = GetDataTablefromDB(sql);

        }


        internal void LodefkcomboBox(string sql,ComboBox fkcomboBox, string Displaycolumname,string valuecolumname)
        {
            DataTable Dt = GetDataTablefromDB(sql);
            fkcomboBox.DataSource = Dt;
            fkcomboBox.DisplayMember = Displaycolumname;
            fkcomboBox.ValueMember = valuecolumname;
        }







    }

       

        
}
