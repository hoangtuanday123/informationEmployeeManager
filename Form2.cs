using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace project_PTTK
{

    public partial class Form2 : Form
    {
        OracleConnection con=null;
        //string conStr = @"DATA SOURCE=localhost:1521/xe;USER ID=dba_mng;PASSWORD=dba_mng";
        string conStr = "";
        string id = "";
        public Form2(string conStr, string id)
        {
            InitializeComponent();
            //con = new OracleConnection(conStr);
            this.conStr = conStr;
            this.id = id;
        }
        public Form2()
        {
            InitializeComponent();
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string conStr = @"DATA SOURCE=localhost:1521/xe;USER ID=dba_mng;PASSWORD=dba_mng";
        //    con = new OracleConnection(conStr); 
        //    con.Open();
        //    OracleCommand cmd = con.CreateCommand();
        //    cmd.CommandText = "select MANV, PHAI from view_nhansu_khongthay_luongphucap where MANV in ('ID003','ID009','ID016')";
        //    cmd.CommandType = CommandType.Text;
        //    OracleDataReader dr = cmd.ExecuteReader();

        //    DataTable table = new DataTable();
        //    table.Columns.Add("MANV", typeof(String));
        //    table.Columns.Add("PHAI", typeof(String));
        //    DataRow row = null;
        //    while (dr.Read())
        //    {
        //        row = table.NewRow();
        //        row["MANV"] = dr["MANV"];
        //        row["PHAI"] = dr["PHAI"];
        //        table.Rows.Add(row);
        //    }
        //    dr.Close();
        //    dataGridView1.DataSource = table;


        //    /*String sql = String.Format("select OrderID, CustomerID, FoodID, Order_status from ORDERDETAIL o where OrderID in ('OR01', 'OR02', 'OR03')");             // FIX
        //    // Step 7: Build command
        //    _command = new SqlCommand(sql);
        //    _command.Connection = _connection;
        //    // Step 8: Execute and get result
        //    DataTable table = new DataTable();
        //    table.Columns.Add("OrderID", typeof(String));
        //    table.Columns.Add("CustomerID", typeof(String));
        //    table.Columns.Add("FoodID", typeof(String));
        //    table.Columns.Add("Status", typeof(String));
        //    SqlDataReader reader = _command.ExecuteReader();
        //    DataRow row = null;
        //    while (reader.Read())
        //    {
        //        row = table.NewRow();
        //        row["OrderID"] = reader["OrderID"];
        //        row["CustomerID"] = reader["CustomerID"];
        //        row["FoodID"] = reader["FoodID"];
        //        row["Status"] = reader["Order_status"];
        //        table.Rows.Add(row);
        //    }
        //    reader.Close();

        //    dataGridView1.DataSource = table;*/

        //    con.Close();
        //}



        // xem quyen cua user/role
        private void groupbox_xem_quyen_cua_user_role_Enter(object sender, EventArgs e)
        {

        }

        private void button_xem_quyen_cua_user_role_Click(object sender, EventArgs e)
        {
            groupbox_xem_quyen_cua_user_role.Visible = true;
            groupbox_cap_nhat_quyen_cua_user_role.Visible = false;
        }

        private void dataGridView_quyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_xem_role_cua_user_Click(object sender, EventArgs e)
        {
            con = new OracleConnection(conStr);
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select grantee, granted_role from dba_role_privs where grantee in (select MANV from DBA_MNG.NHANVIEN) and grantee not in ('EMPLOYEE', 'FINANCE','MANAGER','PERSONNEL','PROJECTLEADER','DIRECTMANAGER')";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("GRANTEE", typeof(String));
            table.Columns.Add("GRANTED_ROLE", typeof(String));
            DataRow row = null;
            while (dr.Read())
            {
                row = table.NewRow();
                row["GRANTEE"] = dr["GRANTEE"];
                row["GRANTED_ROLE"] = dr["GRANTED_ROLE"];
                table.Rows.Add(row);
            }
            dr.Close();
            con.Close();
            dataGridView_quyen.DataSource = table;
        }

        private void button_xem_quyen_cua_role_Click(object sender, EventArgs e)
        {
            con = new OracleConnection(conStr);
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select role, privilege, table_name, column_name from role_tab_privs";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("ROLE", typeof(String));
            table.Columns.Add("PRIVILEGE", typeof(String));
            table.Columns.Add("TABLE_NAME", typeof(String));
            table.Columns.Add("COLUMN_NAME", typeof(String));
            DataRow row = null;
            while (dr.Read())
            {
                row = table.NewRow();
                row["ROLE"] = dr["ROLE"];
                row["PRIVILEGE"] = dr["PRIVILEGE"];
                row["TABLE_NAME"] = dr["TABLE_NAME"];
                row["COLUMN_NAME"] = dr["COLUMN_NAME"];
                table.Rows.Add(row);
            }
            dr.Close();
            con.Close();
            dataGridView_quyen.DataSource = table;
        }





        // cap nhat quyen cua user/role
        private void button_cap_nhat_quyen_cua_user_role_Click(object sender, EventArgs e)
        {
            groupbox_xem_quyen_cua_user_role.Visible = false;
            groupbox_cap_nhat_quyen_cua_user_role.Visible = true;
        }

        private void groupbox_cap_nhat_quyen_cua_user_role_Enter(object sender, EventArgs e)
        {

        }

        private void groupbox_cap_nhat_role_cua_user_Enter(object sender, EventArgs e)
        {

        }

        private void button_cap_nhat_role_cua_user_Click(object sender, EventArgs e)
        {
            groupbox_cap_nhat_role_cua_user.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            con = new OracleConnection(conStr);
            con.Open();
            
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select grantee, granted_role from dba_role_privs where grantee = '" + text + "' and grantee not in ('EMPLOYEE', 'FINANCE','MANAGER','PERSONNEL','PROJECTLEADER','DIRECTMANAGER')";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            if (!dr.Read())
                MessageBox.Show("MA NHAN VIEN KHONG HOP LE");
            else
            {
                //uncheck all roles
                for (int i = 0; i < 6; i++)
                    checkedListBox1.SetItemChecked(i, false);

                //check the roles which are granted
                Stack<String> roles = new Stack<String>();
                roles.Push(dr.GetString(1));
                while (dr.Read())
                {
                    String temp = (String)dr["GRANTED_ROLE"];
                    roles.Push(temp);
                }
                foreach(String item in roles)
                {
                    if (item == "EMPLOYEE") checkedListBox1.SetItemChecked(0, true);
                    if (item == "DIRECTMANAGER") checkedListBox1.SetItemChecked(1, true);
                    if (item == "FINANCE") checkedListBox1.SetItemChecked(2, true);
                    if (item == "MANAGER") checkedListBox1.SetItemChecked(3, true);
                    if (item == "PERSONNEL") checkedListBox1.SetItemChecked(4, true);
                    if (item == "PROJECTLEADER") checkedListBox1.SetItemChecked(5, true);
                }
            }
            
            dr.Close();
            con.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            String currentItem = checkedListBox1.SelectedItem.ToString();
            currentItem = currentItem.Replace(" ", "");
            currentItem = currentItem.ToUpper();

            con = new OracleConnection(conStr);
            con.Open();
            OracleCommand cmd = con.CreateCommand();

            cmd.CommandText = "select GRANTEE from dba_role_privs where grantee = '" + text + "'";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            if (!dr.Read())
                MessageBox.Show("VUI LONG NHAP MA NHAN VIEN VA NHAN NUT [OK]");
            else {
                cmd.CommandText = "select count(*) from dba_role_privs where grantee = '" + text + "' and grantee not in ('EMPLOYEE', 'FINANCE','MANAGER','PERSONNEL','PROJECTLEADER','DIRECTMANAGER')";
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();

                dr.Read();
                int beforeUpdate = dr.GetInt16(0);
                int numOfChecked = checkedListBox1.CheckedItems.Count;

                if (beforeUpdate < numOfChecked)
                {
                    cmd.CommandText = "grant " +currentItem + " to " + text;

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("GRANT");
                }
                else
                {
                    cmd.CommandText = "revoke " + currentItem + " from " + text;
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("REVOKE");
                }
            }

            dr.Close();
            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
