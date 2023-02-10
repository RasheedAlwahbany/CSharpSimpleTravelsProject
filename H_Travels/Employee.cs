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
    class Employee:Parent
    {
        SqlConnection conn = new SqlConnection(@"Data source=DESKTOP-A95G02A;Initial Catalog=H_project;integrated Security=true;");
        SqlCommand cmd;
        public string J_type { get; set; }
        public decimal Salary { get; set; }
        public decimal Bouns { get; set; }
        public decimal Minus { get; set; }
        public string Address { get; set; }
        public string M_id { get; set; }
        public Employee(string i,string fn,string ln,int ph,string des,string jt,decimal sal,decimal bo,decimal mi,string add,string mid):base(i,fn,ln,ph,des)

        {
            J_type = jt;
            Salary = sal;
            Bouns = bo;
            Minus = mi;
            Address = add;
            M_id = mid;
        }
        public void Add()
        {
            try
            {
                cmd = new SqlCommand("insert into employee values ('"+base.Id+"','"+base.Fname+"','"+base.Lname+"','"+J_type+"',"+Phone+","+Salary+","+Bouns+","+Minus+",'"+Address+"','"+M_id+"','"+Desc+"',getdate())",conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add successfully");
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
        public void Update()
        {
            try
            {
                cmd = new SqlCommand("update employee set fname='" + base.Fname + "',lname='" + base.Lname + "',jtype='" + J_type + "',phone=" + Phone + ",salary=" + Salary + ",bouns=" + Bouns + ",minus=" + Minus + ",address='" + Address + "',m_id='" + M_id + "',description='" + Desc + "' where id='"+base.Id+"'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully");
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
