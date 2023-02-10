using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
// 'Eng.Rasheed Adnan Al-Wahbany ^_^'
namespace H_Travels
{
   
    class Company
    {
        SqlConnection conn = new SqlConnection(@"Data source=DESKTOP-A95G02A;Initial Catalog=H_project;integrated Security=true;");
        SqlCommand cmd;
        public string Name { get; set; }
        public string Address { get; set; }
        public string M_id { get; set; }
        public string M_fname { get; set; }
        public string M_lname { get; set; }
        public int M_phone { get; set; }
        public string Desc { get; set; }
        public Company(string nm,string add,string mid,string mfn,string mln,int mph,string des)
        {
            Name = nm;
            Address = add;
            M_id = mid;
            M_fname = mfn;
            M_lname = mln;
            M_phone = mph;
            Desc = des;
        }
        public void add()
        {
            try
            {
                cmd = new SqlCommand("insert into company values('" + Name + "','" + M_id + "','" + M_fname + "','" + M_lname +"',"+M_phone+",'"+Desc+"',getdate(),'"+Address+"')",conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add succesfully.");
            }
            catch (Exception d)
            {
                MessageBox.Show(""+d.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void update()
        {
            try
            {
                cmd = new SqlCommand("update company set m_id='" + M_id + "',m_fname='" + M_fname + "',m_lname='" + M_lname + "',m_phnumber=" + M_phone + ",description='" + Desc + "',Address='"+Address+"' where name='"+Name+"'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated succesfully.");
            }
            catch (Exception d)
            {
                MessageBox.Show("" + d.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
