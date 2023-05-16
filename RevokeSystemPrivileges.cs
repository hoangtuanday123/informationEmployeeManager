using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace RevokeSystemPrivileges
{
    public partial class frmRevoke : Form
    {
        String strCon = "";
        string id = "";
        public frmRevoke()
        {
            InitializeComponent();
        }
        public frmRevoke(string _connect, string id)
        {
            InitializeComponent();
            
            this.id = id;
            this.strCon = _connect;
        }
        private void frmRevoke_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(strCon);
            conn.Open();

            OracleDataAdapter odt = new OracleDataAdapter("SELECT DISTINCT GRANTEE FROM DBA_SYS_PRIVS",conn);
            DataTable usernameTable = new DataTable();
            odt.Fill(usernameTable);

            cbbUserName.ValueMember = "GRANTEE";
            cbbUserName.DataSource = usernameTable;
            cbbUserName.SelectedIndex = -1;

            DataTable tablePrivs = new DataTable();
            odt.SelectCommand.CommandText = "SELECT * FROM DBA_SYS_PRIVS";
            odt.Fill(tablePrivs);
            dgvPrivs.DataSource = tablePrivs;

            conn.Close();
        }

        private void cbbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnViewPrivs_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(strCon);
            OracleDataAdapter odt = new OracleDataAdapter();
            DataTable tableUserName = new DataTable();
            DataRowView row = (DataRowView)cbbUserName.SelectedItem;

            string userName = (string)row.Row["GRANTEE"];
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE = \'" + userName.ToString() + "\'";
            command.Connection = conn;
            odt.SelectCommand = command;
            odt.Fill(tableUserName);
            dgvPrivs.DataSource = tableUserName;
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(strCon);
            conn.Open();

            String sqlStr = "REVOKE " + txtPrivs.Text + " FROM " + cbbUserName.SelectedValue.ToString();

            OracleCommand command = new OracleCommand();
            command = new OracleCommand(sqlStr);
            command.Connection = conn;

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Revoke sucessfully !");
            }
            catch
            {
                MessageBox.Show("Revoke fail !");
            }

            conn.Close();
        }
    }
}
