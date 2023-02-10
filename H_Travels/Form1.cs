using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
// 'Eng.Rasheed Adnan Al-Wahbany ^_^'
namespace H_Travels
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data source=DESKTOP-A95G02A;Initial Catalog=H_project;integrated Security=true;");
        SqlCommand cmd;
        SqlDataReader red;
        SqlDataAdapter sda;
        DataTable dt=new DataTable();
        bool snotcheck = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*if (tabControl1.SelectedIndex == 0)
                delete.Enabled = false;*/
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(in_gtime.Text);
            Invoice g = new Invoice(in_id.Text,in_fname.Text,in_lname.Text,int.Parse(in_phone.Text),in_desc.Text,in_tdir.Text,decimal.Parse(in_total.Text),in_trid.Text,in_tdate.Text, in_cname.Text, T_snumber.Text,in_gtime.Text);
            g.add();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                
                cmd = new SqlCommand("delete from travels where id='"+T_id.Text+"'",conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully.");
            }catch(Exception d)
            {
                MessageBox.Show(""+d.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(""+T_date.Text);
            Travels g = new Travels(T_id.Text,T_name.Text, T_dir.Text,int.Parse(T_gtime.Value.ToString()),int.Parse(T_dtime.Value.ToString()), int.Parse(T_tsaits.Text),int.Parse(T_asaits.Text),int.Parse(T_bsaits.Text),T_desc.Text,decimal.Parse(T_acost.Text),decimal.Parse(T_bcost.Text),T_date.Text, T_c_name.Text);
            g.add();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Invoice g = new Invoice(in_id.Text, in_fname.Text, in_lname.Text, int.Parse(in_phone.Text), in_desc.Text, in_tdir.Text, decimal.Parse(in_total.Text), in_trid.Text, in_tdate.Text, in_cname.Text, T_snumber.Text, in_gtime.Text);
            g.update();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select * from travels where id='"+T_id.Text+"'",conn);
                conn.Open();
                red = cmd.ExecuteReader();
                red.Read();
                T_id.Text = red[0].ToString();
                T_name.Text = red[1].ToString();
                T_dir.Text = red[2].ToString();
                T_gtime.Text = red[3].ToString();
                T_dtime.Text = red[4].ToString();
                T_tsaits.Text = red[5].ToString();
                T_asaits.Text = red[6].ToString();
                T_bsaits.Text = red[7].ToString();
                T_desc.Text = red[8].ToString();
                T_date.Text = red[9].ToString();
                T_acost.Text = red[10].ToString();
                T_bcost.Text = red[11].ToString();
                T_c_name.Text = red[12].ToString();
            }
            catch(Exception d)
            {
                MessageBox.Show(""+d.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Travels g = new Travels(T_id.Text, T_name.Text, T_dir.Text, int.Parse(T_gtime.Text), int.Parse(T_dtime.Text), int.Parse(T_tsaits.Text), int.Parse(T_asaits.Text), int.Parse(T_bsaits.Text), T_desc.Text, decimal.Parse(T_acost.Text), decimal.Parse(T_bcost.Text), T_date.Text, T_c_name.Text);
            g.update();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Company g = new Company(C_name.Text, C_address.Text,C_mid.Text, C_mfname.Text,C_mlname.Text, int.Parse(C_mphnumber.Text),C_desc.Text);
            g.add();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Company g = new Company(C_name.Text, C_address.Text, C_mid.Text, C_mfname.Text, C_mlname.Text, int.Parse(C_mphnumber.Text), C_desc.Text);
            g.update();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Employee g = new Employee(E_id.Text,E_fname.Text,E_lname.Text,int.Parse(E_phnumber.Text),E_desc.Text,E_jtype.Text,decimal.Parse(E_salary.Text),decimal.Parse(E_bouns.Text),decimal.Parse(E_minus.Text),E_address.Text,E_mid.Text);
            g.Add();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Employee g = new Employee(E_id.Text, E_fname.Text, E_lname.Text, int.Parse(E_phnumber.Text), E_desc.Text, E_jtype.Text, decimal.Parse(E_salary.Text), decimal.Parse(E_bouns.Text), decimal.Parse(E_minus.Text), E_address.Text, E_mid.Text);
            g.Update();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                dt.Columns.Clear();
                cmd = new SqlCommand("select * from company where name='"+C_name.Text+"'",conn);
                conn.Open();
                red = cmd.ExecuteReader();
                if (red.Read())
                {
                    C_name.Text = red[0].ToString();
                    C_mid.Text = red[1].ToString();
                    C_mfname.Text = red[2].ToString();
                    C_mlname.Text = red[3].ToString();
                    C_mphnumber.Text = red[4].ToString();
                    C_desc.Text = red[5].ToString();
                    C_cdate.Text = red[6].ToString();
                    C_address.Text = red[7].ToString();
                }
                else
                    MessageBox.Show("Error\nPlease write the company name correctily.");
            }
            catch (Exception d)
            {
                MessageBox.Show(""+d.Message);
            }
            finally
            {
                conn.Close();
                
            }
            conn.Close();
            sda = new SqlDataAdapter("select * from travels where c_name='" + C_name.Text + "'", conn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select * from employee where id='"+E_id.Text+"'",conn);
                conn.Open();
                red = cmd.ExecuteReader();
                red.Read();
                E_id.Text = red[0].ToString();
                E_fname.Text = red[1].ToString();
                E_lname.Text = red[2].ToString();
                E_jtype.Text = red[3].ToString();
                E_phnumber.Text = red[4].ToString();
                E_salary.Text = red[5].ToString();
                E_bouns.Text = red[6].ToString();
                E_minus.Text = red[7].ToString();
                E_address.Text = red[8].ToString();
                E_mid.Text = red[9].ToString();
                E_desc.Text = red[10].ToString();
                E_hdate.Text = red[11].ToString();
            }catch(Exception d)
            {
                MessageBox.Show(""+d.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
               
                cmd = new SqlCommand("delete from company where name='" + C_name.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully.");
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

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from employee where id='" + E_id.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully.");
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

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                cmd = new SqlCommand("delete from invoice where id='" + in_id.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            snotcheck = false;
            try
            {
                conn.Close();
                cmd = new SqlCommand("select * from invoice where id='"+in_id.Text+"'",conn);
                conn.Open();
                red=cmd.ExecuteReader();
                red.Read();
                in_id.Text = red[0].ToString();
                in_fname.Text = red[1].ToString();
                in_lname.Text = red[2].ToString();
                in_phone.Text = red[3].ToString();
                in_cname.Text = red[4].ToString();
                in_trid.Text = red[5].ToString();
                in_tdir.Text = red[6].ToString();
                T_snumber.Text = red[7].ToString();
                in_total.Text = red[8].ToString();
                in_desc.Text = red[9].ToString();
                in_tdate.Text = red[10].ToString();
                in_rdate.Text = red[11].ToString();
                in_gtime.Text = red[12].ToString();

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

        private void in_trid_Leave(object sender, EventArgs e)
        {
           
        }

        private void T_snumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void T_snumber_Leave(object sender, EventArgs e)
        {
            if (snotcheck)
            {
                if (in_trid.Text != "")
                {
                    try
                    {
                        string ac, bc;
                        cmd = new SqlCommand("select a_cost,b_cost from travels where id='" + in_trid.Text + "'", conn);
                        conn.Open();
                        red = cmd.ExecuteReader();
                        if (red.Read())
                        {
                            ac = red[0].ToString();
                            bc = red[1].ToString();
                            
                            if (int.Parse(T_snumber.Text) < 20 && int.Parse(T_snumber.Text) > 0)
                                in_total.Text = ac;
                            else if (int.Parse(T_snumber.Text) > 20)
                                in_total.Text = bc;
                            
                        }
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

        private void in_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void T_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void C_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void E_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void E_id_Enter(object sender, EventArgs e)
        {
            E_id.Items.Clear();
            try
            {
                cmd = new SqlCommand("select id from employee", conn);
                conn.Open();
                red = cmd.ExecuteReader();
                while (red.Read())
                    E_id.Items.Add(red[0].ToString());
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

        private void C_name_Enter(object sender, EventArgs e)
        {
            C_name.Items.Clear();
            try
            {
                cmd = new SqlCommand("select name from company", conn);
                conn.Open();
                red = cmd.ExecuteReader();
                while (red.Read())
                    C_name.Items.Add(red[0].ToString());
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

        private void T_id_Enter(object sender, EventArgs e)
        {
            T_id.Items.Clear();
            try
            {
                cmd = new SqlCommand("select id from travels", conn);
                conn.Open();
                red = cmd.ExecuteReader();
                while (red.Read())
                    T_id.Items.Add(red[0].ToString());
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

        private void in_id_FontChanged(object sender, EventArgs e)
        {

        }

        private void in_id_Enter(object sender, EventArgs e)
        {
            in_id.Items.Clear();
            try
            {
                cmd = new SqlCommand("select id from invoice", conn);
                conn.Open();
                red = cmd.ExecuteReader();
                while (red.Read())
                    in_id.Items.Add(red[0].ToString());
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

        private void in_trid_Leave_1(object sender, EventArgs e)
        {
            if (snotcheck)
            {
                try
                {

                    cmd = new SqlCommand("select dir,gtime,description,t_date,c_name from travels where id='" + in_trid.Text + "'", conn);
                    conn.Open();
                    red = cmd.ExecuteReader();
                    if (red.Read())
                    {
                        in_tdir.Text = red[0].ToString();
                        in_gtime.Text = red[1].ToString();
                        in_desc.Text = red[2].ToString();
                        in_tdate.Text = red[3].ToString();
                        in_cname.Text = red[4].ToString();
                    }
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

        private void in_trid_Enter(object sender, EventArgs e)
        {
            if (snotcheck)
            {
                in_trid.Items.Clear();
                try
                {
                    cmd = new SqlCommand("select id from travels",conn);
                    conn.Open();
                    red = cmd.ExecuteReader();
                    while (red.Read())
                    {
                        in_trid.Items.Add(red[0].ToString());
                    }
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

        private void in_trid_LocationChanged(object sender, EventArgs e)
        {

        }

        private void T_dtime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
