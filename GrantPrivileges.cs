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
namespace GRANT_PRIVILEGES
{
    public partial class GrantPrivileges : Form
    {
        OracleConnection conn = null;
        string id = "";
        string stringConnection = "";
        public GrantPrivileges(string stringConnection, string id)
        {
            InitializeComponent();
            conn = new OracleConnection(stringConnection);
            
            this.id = id;
            grbGrantPrivilegesToUser.Visible = false;
            grbGrantPrivilegesToRole.Visible = false;
            grbGrantRoleToUser.Visible = false;
        }
        public GrantPrivileges()
        {
            InitializeComponent();
            grbGrantPrivilegesToUser.Visible = false;
            grbGrantPrivilegesToRole.Visible = false;
            grbGrantRoleToUser.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //public static string stringConnection = @"DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\Users\vohoa\Oracle\network\admin;USER ID=SYS; PASSWORD = giatin2002*;DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True";
        //OracleConnection conn = new OracleConnection(stringConnection);

        private void btnGrantPrivilegesToUser_Click(object sender, EventArgs e)
        {
            
            grbGrantPrivilegesToUser.Visible = true;
            grbGrantRoleToUser.Visible = false;
            grbGrantPrivilegesToRole.Visible = false;
            conn.Open();
            //upload user to comboBox
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT MANV,TENNV FROM DBA_MNG.NHANVIEN";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbUser.DataSource = dt;
            cbbUser.DisplayMember = dt.Columns[1].ColumnName;
            cbbUser.ValueMember = dt.Columns[0].ColumnName;
            cbbUser.SelectedIndex = -1;
            
            //upload table to comboBox
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "SELECT TABLE_NAME FROM ALL_TABLES WHERE owner = 'DBA_MNG'";
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
            OracleDataAdapter da1 = new OracleDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1); 
            cbbTable.DataSource = dt1;
            cbbTable.DisplayMember = dt1.Columns[0].ColumnName;
            cbbTable.ValueMember = dt1.Columns[0].ColumnName;
            cbbTable.SelectedIndex = -1;
            conn.Close();
            
        }

        // process string grant
        private void btnApply_Click_1(object sender, EventArgs e)
        {
            string _grant = "";
            string[] arr = new string[4];
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            if (!cbSelect.Checked && !cbUpdate.Checked && !cbInsert.Checked && !cbDelete.Checked)
            {
                MessageBox.Show("Not Privileges To Grant");
            }

            else if (cbbColumn.SelectedValue != null && cbInsert.Checked || cbbColumn.SelectedValue != null && cbDelete.Checked)
            {
                MessageBox.Show("Insert or Delete can't apply on columns, please choose again!!!");
            }

            else
            {
                if (cbSelect.Checked)
                {
                    arr[0] = "select";
                }
                if (cbUpdate.Checked)
                {
                    arr[1] = "update";
                }
                if (cbInsert.Checked)
                {
                    arr[2] = "insert";

                }
                if (cbDelete.Checked)
                {
                    arr[3] = "delete";
                }

                if (cbbColumn.SelectedValue != null && cbSelect.Checked)
                {
                    string view_table = "create or replace view DBA_MNG.view_select_column_" + cbbTable.SelectedValue.ToString() +
                                        " as " +
                                        "select " + cbbColumn.SelectedValue.ToString() + " from DBA_MNG." + cbbTable.SelectedValue.ToString();
                    cmd.CommandText = view_table;
                    //MessageBox.Show(view_table);
                    cmd.ExecuteNonQuery();

                    string grant_view = "";
                    if (cbWithGrantOption.Checked)
                    {
                        grant_view = "grant select on DBA_MNG.view_select_column_" + cbbTable.SelectedValue.ToString() + " to " + cbbUser.SelectedValue.ToString() + " with grant option";
                    }
                    else
                    {
                        grant_view = "grant select on DBA_MNG.view_select_column_" + cbbTable.SelectedValue.ToString() + " to " + cbbUser.SelectedValue.ToString();
                    }
                    cmd.CommandText = grant_view;
                    //MessageBox.Show(grant_view);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("GRANT SUCCESFULLY!");
                    arr[0] = null;
                }

                if (cbbColumn.SelectedValue != null)
                {
                    if (arr[1] != null) arr[1] += "(" + cbbColumn.SelectedValue + ")";
                }

                for (int i = 0; i < 4; i++)
                {
                    //MessageBox.Show(_grant);
                    if (arr[i] != null && _grant == "")
                    {
                        _grant += arr[i];
                    }
                    else if (arr[i] != null)
                    {
                        _grant = _grant + "," + arr[i];
                    }
                }
                //MessageBox.Show(_grant);
                if (_grant != "")
                {
                    if (cbWithGrantOption.Checked)
                    {
                        _grant = "grant " + _grant + " on DBA_MNG." + cbbTable.SelectedValue + " to " + cbbUser.SelectedValue + " with grant option";
                    }
                    else
                    {
                        _grant = "grant " + _grant + " on DBA_MNG." + cbbTable.SelectedValue + " to " + cbbUser.SelectedValue;
                    }
                }
                if (_grant != "")
                {
                    cmd.CommandText = _grant;
                    cmd.CommandType = CommandType.Text;
                    //MessageBox.Show(_grant);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        // MessageBox.Show("GRANT SUCCESFULLY!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            MessageBox.Show("GRANT SUCCESFULLY!");
            conn.Close();
        }

        private void btnLoadColumn_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "SELECT column_name " +
                "FROM ALL_TAB_COLUMNS " +
                "WHERE table_name = '" + cbbTable.SelectedValue + "'";

            cmd2.CommandType = CommandType.Text;
            cmd2.ExecuteNonQuery();
            OracleDataAdapter da2 = new OracleDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cbbColumn.DataSource = dt2;
            cbbColumn.DisplayMember = dt2.Columns[0].ColumnName;
            cbbColumn.ValueMember = dt2.Columns[0].ColumnName;
            cbbColumn.SelectedIndex = -1;
            conn.Close();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
           
                
        }
        

        private void cbbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        // upload coulmn to comboBox
        private void btnLoadColumn_Click(object sender, EventArgs e)
        {
           
        }


        //grant privilesges to role
        private void btnGrantPrivilegesToRole_Click(object sender, EventArgs e)
        {
            grbGrantPrivilegesToRole.Visible = true;
            grbGrantRoleToUser.Visible = false;
            grbGrantPrivilegesToUser.Visible = false;
            conn.Open();
            //upload role to comboBox
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT role FROM dba_roles WHERE password_required = 'YES'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbRole.DataSource = dt;
            cbbRole.DisplayMember = dt.Columns[0].ColumnName;
            cbbRole.ValueMember = dt.Columns[0].ColumnName;
            cbbRole.SelectedIndex = -1;

            //upload table to comboBox
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "SELECT TABLE_NAME FROM ALL_TABLES WHERE owner = 'DBA_MNG'";
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
            OracleDataAdapter da1 = new OracleDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbbTableRole.DataSource = dt1;
            cbbTableRole.DisplayMember = dt1.Columns[0].ColumnName;
            cbbTableRole.ValueMember = dt1.Columns[0].ColumnName;
            cbbTableRole.SelectedIndex = -1;
            conn.Close();
        }

        private void btnLoadColumnRole_Click(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "SELECT column_name " +
                "FROM ALL_TAB_COLUMNS " +
                "WHERE table_name = '" + cbbTableRole.SelectedValue + "'";

            cmd2.CommandType = CommandType.Text;
            cmd2.ExecuteNonQuery();
            OracleDataAdapter da2 = new OracleDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cbbColumnRole.DataSource = dt2;
            cbbColumnRole.DisplayMember = dt2.Columns[0].ColumnName;
            cbbColumnRole.ValueMember = dt2.Columns[0].ColumnName;
            cbbColumnRole.SelectedIndex = -1;
            conn.Close();
        }

        private void btnApplyRole_Click(object sender, EventArgs e)
        {
            
            string _grant = "";
            string[] arr = new string[4];
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;
            if (!cbSelectRole.Checked && !cbUpdateRole.Checked && !cbInsertRole.Checked && !cbDeleteRole.Checked)
            {
                MessageBox.Show("Not Privileges To Grant");
            }

            else if (cbbColumnRole.SelectedValue != null && cbInsertRole.Checked || cbbColumnRole.SelectedValue != null && cbDeleteRole.Checked)
            {
                MessageBox.Show("Insert or Delete can't apply on columns, please choose again!!!");
            }

            else
            {
                if (cbSelectRole.Checked)
                {
                    arr[0] = "select";
                }
                if (cbUpdateRole.Checked)
                {
                    arr[1] = "update";
                }
                if (cbInsertRole.Checked)
                {
                    arr[2] = "insert";

                }
                if (cbDeleteRole.Checked)
                {
                    arr[3] = "delete";
                }


                if (cbbColumnRole.SelectedValue != null && cbSelectRole.Checked)
                {
                    string view_table = "create or replace view DBA_MNG.view_select_column_" + cbbTableRole.SelectedValue.ToString() +
                                        " as " +
                                        "select " + cbbColumnRole.SelectedValue.ToString() + " from DBA_MNG." + cbbTableRole.SelectedValue.ToString();
                    cmd.CommandText = view_table;
                    //MessageBox.Show(view_table);
                    cmd.ExecuteNonQuery();

                    string  grant_view = "grant select on DBA_MNG.view_select_column_" + cbbTableRole.SelectedValue.ToString() + " to " + cbbRole.SelectedValue.ToString();
                    
                    cmd.CommandText = grant_view;
                    //MessageBox.Show(grant_view);
                    cmd.ExecuteNonQuery();
                   // MessageBox.Show("GRANT SUCCESFULLY!");
                    arr[0] = null;
                }

                if (cbbColumnRole.SelectedValue != null)
                {
                    if (arr[1] != null) arr[1] += "(" + cbbColumnRole.SelectedValue + ")";
                }

                for (int i = 0; i < 4; i++)
                {
                    //MessageBox.Show(_grant);
                    if (arr[i] != null && _grant == "")
                    {
                        _grant += arr[i];
                    }
                    else if (arr[i] != null)
                    {
                        _grant = _grant + "," + arr[i];
                    }
                }

                if (_grant != "")
                {
                    _grant = "grant " + _grant + " on DBA_MNG." + cbbTableRole.SelectedValue + " to " + cbbRole.SelectedValue;
                    cmd.CommandText = _grant;
                    cmd.CommandType = CommandType.Text;
                    //MessageBox.Show(_grant);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show("GRANT SUCCESFULLY!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            MessageBox.Show("GRANT SUCCESFULLY!");
            conn.Close();
        }

        private void grbGrantPrivilegesToRole_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnGrantRoleToUser_Click(object sender, EventArgs e)
        {
            grbGrantPrivilegesToRole.Visible = false;
            grbGrantPrivilegesToUser.Visible = false;
            grbGrantRoleToUser.Visible = true;
            
            conn.Open();
            //upload role to comboBox
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT role FROM dba_roles WHERE password_required = 'YES'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbRoleRoleToUser.DataSource = dt;
            cbbRoleRoleToUser.DisplayMember = dt.Columns[0].ColumnName;
            cbbRoleRoleToUser.ValueMember = dt.Columns[0].ColumnName;
            cbbRoleRoleToUser.SelectedIndex = -1;

            //upload user to comboBox
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "SELECT MANV,TENNV FROM DBA_MNG.NHANVIEN";
            cmd1.CommandType = CommandType.Text;
            cmd1.ExecuteNonQuery();
            OracleDataAdapter da1 = new OracleDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            cbbUserRoleToUser.DataSource = dt1;
            cbbUserRoleToUser.DisplayMember = dt1.Columns[1].ColumnName;
            cbbUserRoleToUser.ValueMember = dt1.Columns[0].ColumnName;
            cbbUserRoleToUser.SelectedIndex = -1;
            conn.Close();
        }

        private void btnApplyRoleToUser_Click(object sender, EventArgs e)
        {
            string _grant = "";
            OracleCommand cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;

            if (cbWithAdminOption.Checked)
            {
                _grant = "grant "  + cbbRoleRoleToUser.SelectedValue + " to " + cbbUserRoleToUser.SelectedValue + " with admin option";
            }
            else
            {
                _grant = "grant " + cbbRoleRoleToUser.SelectedValue + " to " + cbbUserRoleToUser.SelectedValue;
            }
            cmd.CommandText = _grant;
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("GRANT SUCCESFULLY!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void GrantPrivileges_Load(object sender, EventArgs e)
        {

        }
    }
}
