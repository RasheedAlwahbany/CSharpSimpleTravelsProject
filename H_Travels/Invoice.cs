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
    class Invoice:Parent
    {
        SqlConnection conn = new SqlConnection(@"Data source=DESKTOP-A95G02A;Initial Catalog=H_project;integrated Security=true;");
        SqlCommand cmd;
        public string Dir { get; set; }
        public decimal Total { get; set;}
        public string T_id { get; set; }
        public string T_date { get; set; }
        public string C_name { get; set; }
        public string S_number { get; set; }
        public string Gtime { get; set; }
        public Invoice(string i, string fn, string ln, int ph, string des,string dr,decimal tot,string tid,string tdate,string cname,string snum,string gt):base(i,fn,ln,ph,des)
        {
         
            Dir = dr;
            Total = tot;
            T_id = tid;
            T_date = tdate;
            C_name = cname;
            S_number = snum;
            Gtime = gt;
        }
        public void add()
        {
            try
            {
                cmd = new SqlCommand("insert into invoice values('"+base.Id+"','"+base.Fname+"','"+base.Lname+"',"+Phone+",'"+C_name+"','"+T_id+"','"+Dir+"','"+S_number+"',"+ Total + ",'"+Desc+"','"+T_date+"',getdate(),'"+Gtime+ "')",conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add successfully.");
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
                cmd = new SqlCommand("update invoice set fname='" + base.Fname + "',lname='" + base.Lname + "',phone=" + Phone + ",c_name='" + C_name + "',t_id='" + T_id + "',t_dir='" + Dir + "',S_number='"+S_number+ "',total_cost="+Total+ ",description='" + Desc + "',t_date='" + T_date + "',g_time='" + Gtime+"'  where id='"+base.Id+"'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully.");
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
