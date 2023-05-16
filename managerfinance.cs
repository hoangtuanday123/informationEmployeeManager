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
namespace PHANHE1
{
    public partial class managerfinance : Form
    {
        OracleConnection connect = null;
        public string _connect = "";
        string id = "";
        public managerfinance()
        {
            InitializeComponent();
        }
        public managerfinance(string _connect, string id)
        {
            InitializeComponent();
            OracleConnection connect_temp = new OracleConnection(_connect);
            this.connect = connect_temp;
            this.id = id;
            this._connect = _connect;
        }

        private void managerfinance_Load(object sender, EventArgs e)
        {

        }

        private void btn_key_Click(object sender, EventArgs e)
        {
            gbkey.Visible = true;
            gbauditlog.Visible = false;
            connect.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connect;
            command.CommandText = "DBA_MNG.PROC_TABLEKEY";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("CUR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            dgvkey.DataSource = table;
            connect.Close();
        }

        private void btn_auditlogkey_Click(object sender, EventArgs e)
        {
            gbkey.Visible = false;
            gbauditlog.Visible = true;
            connect.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connect;
            command.CommandText = "DBA_MNG.PROC_AUDITLOG";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("CUR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            dgvauditlog.DataSource = table;
            //audit fga
            OracleCommand command1 = new OracleCommand();
            command1.Connection = connect;
            command1.CommandText = "DBA_MNG.PROC_AUDITFGA";
            command1.CommandType = CommandType.StoredProcedure;
            command1.Parameters.Add("CUR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da1 = new OracleDataAdapter();
            da1.SelectCommand = command1;
            DataTable table1 = new DataTable();
            da1.Fill(table1);
            dgvauditfga.DataSource = table1;
            connect.Close();

        }

        private void btnchangekey_Click(object sender, EventArgs e)
        {
            connect.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connect;
            command.CommandText = "DBA_MNG.SP_CHANGEKEY";
            command.CommandType = CommandType.StoredProcedure;
            if (txtchangekey.Text != "")
            {
                command.Parameters.Add("KEY_CHANGE", OracleDbType.Varchar2).Value = txtchangekey.Text;
                
            }
            else
            {
                MessageBox.Show("input key");
            }
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("UPDATE KEY SUCCESSFULL");
            }
            catch(Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
            connect.Close();
        }
    }
}
