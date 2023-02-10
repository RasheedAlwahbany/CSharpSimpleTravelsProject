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
    class Travels
    {
        SqlConnection conn = new SqlConnection(@"Data source=DESKTOP-A95G02A;Initial Catalog=H_project;integrated Security=true;");
        SqlCommand cmd;
        
        public string T_id { get; set; }
        public string T_name { get; set; }
        public string Dir { get; set; }
        public int Go_time { get; set; }
        public int T_time { get; set; }
        public int Total_saits { get; set; }
        public int A_saits { get; set; }
        public int B_saits { get; set; }
        public string Desc { get; set; }
        public decimal A_cost { get; set; }
        public decimal B_cost { get; set; }
        public string T_date { get; set; }
        public string C_name { get; set; }
        public Travels(string tid,string tname,string dr,int gtime,int ttime,int totsaits,int asaits,int bsaits,string des,decimal ac,decimal bc,string tdate,string cn)
        {
            T_id = tid;
            T_name = tname;
            Dir = dr;
            Go_time = gtime;
            T_time = ttime;
            Total_saits = totsaits;
            A_saits = asaits;
            B_saits = bsaits;
            Desc= des;
            A_cost = ac;
            B_cost = bc;
            T_date = tdate;
            C_name = cn;
        }
        public void add()
        {
            try
            {
                cmd = new SqlCommand("insert into travels values('"+T_id+"','"+T_name+"','"+Dir+"',"+Go_time+","+T_time+","+Total_saits+","+A_saits+","+B_saits+ "," + A_cost + "," + B_cost + ",'" + C_name + "','" + Desc+"','"+T_date+"')",conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add successfully");
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
                cmd = new SqlCommand("update travels set name='" + T_name + "',dir='" + Dir + "',gtime='" + Go_time + "',dtime='" + T_time + "',t_saits=" + Total_saits + ",a_saits=" + A_saits + ",b_saits=" + B_saits + ",description='" + Desc + "',t_date='"+T_date+"',a_cost="+A_cost+",b_cost= "+B_cost+",c_name='"+C_name+"' where id='" + T_id+"'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("update successfully");
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
