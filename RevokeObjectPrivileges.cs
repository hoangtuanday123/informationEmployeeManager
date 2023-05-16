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

namespace RevokeObjectPrivileges
{
    public partial class frmRevokeObjectPrivs : Form
    {
        String connStr = "";
        string id = "";
        public frmRevokeObjectPrivs()
        {
            InitializeComponent();
        }
        public frmRevokeObjectPrivs(string _connect, string id)
        {
            InitializeComponent();
            this.id = id;
            this.connStr = _connect;
        }

        private void frmRevokeObjectPrivs_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);
            conn.Open();

            OracleDataAdapter odt = new OracleDataAdapter("SELECT DISTINCT GRANTEE FROM DBA_TAB_PRIVS", conn);
            DataTable usernameTable = new DataTable();
            odt.Fill(usernameTable);

            cbbUserName.ValueMember = "GRANTEE";
            cbbUserName.DataSource = usernameTable;
            cbbUserName.SelectedIndex = -1;

            DataTable tablePrivs = new DataTable();
            odt.SelectCommand.CommandText = "SELECT * FROM DBA_TAB_PRIVS";
            odt.Fill(tablePrivs);
            dgvRevoke.DataSource = tablePrivs;

            conn.Close();
        }

        private void btnViewPrivs_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);
            OracleDataAdapter odt = new OracleDataAdapter();
            DataTable tableUserName = new DataTable();
            DataRowView row = (DataRowView)cbbUserName.SelectedItem;

            string userName = (string)row.Row["GRANTEE"];
            OracleCommand command = new OracleCommand();
            command.CommandText = "SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE = \'" + userName.ToString() + "\'";
            command.Connection = conn;
            odt.SelectCommand = command;
            odt.Fill(tableUserName);
            dgvRevoke.DataSource = tableUserName;

            conn.Close();
        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);
            conn.Open();

            String sqlStr = "REVOKE " + txtPrivs.Text + " ON " + txtObject.Text + " FROM " + cbbUserName.SelectedValue.ToString();
            OracleCommand command = new OracleCommand(sqlStr,conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Revoke successfully !");

            }
            catch
            {
                MessageBox.Show("Revoke fail !");
            }

            conn.Close();

        }
    }
}
