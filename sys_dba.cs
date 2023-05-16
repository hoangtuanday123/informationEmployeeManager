using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using project_PTTK;
using GRANT_PRIVILEGES;
using RevokeObjectPrivileges;
using RevokeSystemPrivileges;
using PH1_5;
namespace PHANHE1
{
    public partial class sys_dba : Form
    {
        OracleConnection connect = null;
        public string _connect = "";
        string id="";
        public sys_dba()
        {
            InitializeComponent();
        }
        public sys_dba(string _connect, string id)
        {
            InitializeComponent();
            connect = new OracleConnection(_connect);
            this.id = id;
            this._connect = _connect;
        }

        private void sys_dba_Load(object sender, EventArgs e)
        {
            lbluser.Text = this.id;
            btnlistuser_Click(sender,e);



        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }
        //BUTTON LISTUSER
        private void btnlistuser_Click(object sender, EventArgs e)
        {
            gblistuser.Visible = true;
            gbprivileges.Visible = false;
            connect.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connect;
            cmd.CommandText = "select username from all_users";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
           DataTable table= new DataTable();
            table.Load(dr);
            dgvlistuser.DataSource = table;
            connect.Close();

        }
        //BUTTON PRIVILEGES
        private void btnprivileges_Click(object sender, EventArgs e)
        {
            gbprivileges.Visible = true;
            gblistuser.Visible = false;
        }
        //tim tat ca username cua he thong
        private void fillUsername()
        {
            connect.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connect;
            cmd.CommandText = "select username from all_users";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            List<string> list = new List<string>();
            int i = 0;
            while (dr.Read())
            {
                list.Add(dr.GetString(0));

                ++i;
            }
            object[] listSearch = null;
            listSearch = list.ToArray();
            cbseach.Items.Clear();
            cbseach.Items.AddRange(listSearch);
            connect.Close();
        }
        //BUTTON XEM PRIVILEGES USER
        private void btnpriuser_Click(object sender, EventArgs e)
        {
            cbseach.Text = "search user/role";
            gbpriuser.Visible = true;
            gbprirole.Visible = false;
            fillUsername();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            String username = cbseach.Text;
            connect.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connect;
            //XEM THONG TIN QUYEN DOI TUONGCUA USER TREN TABLE
            String sql = string.Format("SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE='{0}'", username);
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dgvusertable.DataSource = table;
            //XEM THONG TIN QUYEN DOI TUONG CUA USER TREN COLUMN
            sql = string.Format("SELECT * FROM DBA_COL_PRIVS WHERE GRANTEE='{0}'", username);
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            dr = cmd.ExecuteReader();
            DataTable column = new DataTable();
            column.Load(dr);
            dgvusercolumn.DataSource = column;
            connect.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //tim tat ca role cua he thong
        private void fillRole()
        {
            connect.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connect;
            //SELECT TEN ROLE CUA HE THONG
            cmd.CommandText = "SELECT DISTINCT(ROLE) FROM ROLE_TAB_PRIVS";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();

            List<string> list = new List<string>();
            int i = 0;
            while (dr.Read())
            {
                list.Add(dr.GetString(0));

                ++i;
            }
            object[] listSearch = null;
            listSearch = list.ToArray();
            cbseach.Items.Clear();
            cbseach.Items.AddRange(listSearch);
            connect.Close();
        }
        private void btnprirole_Click(object sender, EventArgs e)
        {
            cbseach.Text = "search user/role";
            gbpriuser.Visible = false;
            gbprirole.Visible = true;
            fillRole();

        }

        private void btnrolesearch_Click(object sender, EventArgs e)
        {
            String role = cbseach.Text;
            connect.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connect;
            //XEM QUYEN CUA ROLE TRÊN TABLE
            String sql = string.Format("SELECT * FROM ROLE_TAB_PRIVS WHERE ROLE ='{0}'", role);
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(dr);
            dgvprirole.DataSource = table;
            connect.Close();
        }

        private void btnupdateuserrole_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(_connect, id);
            form2.ShowDialog();
            form2 = null;
            this.Show();
        }

        private void btnGrantPrivileges_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            GrantPrivileges grantpri = new GrantPrivileges(_connect, id);
            grantpri.ShowDialog();
            grantpri = null;
            this.Show();
        }

        private void btncreatealterdrop_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAlterDrop createalterdrop = new CreateAlterDrop(_connect, id);
            createalterdrop.ShowDialog();
            createalterdrop = null;
            this.Show();

        }

        private void btnRevokeObjectPrivileges_Click(object sender, EventArgs e)
        {
            
             this.Hide();
            frmRevokeObjectPrivs revokeobject = new frmRevokeObjectPrivs(_connect, id);
            revokeobject.ShowDialog();
            revokeobject = null;
            this.Show();
        }

        private void btnRevokeSystemPrivileges_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRevoke revokesystem = new frmRevoke(_connect, id);
            revokesystem.ShowDialog();
            revokesystem = null;
            this.Show();
        }

       



    }
}
