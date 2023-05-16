using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUDIT
{
    public partial class frmXemLuongPC : Form
    {
        OracleConnection connect = null;
        public string _connect = "";
        public frmXemLuongPC()
        {
            InitializeComponent();
        }
        public frmXemLuongPC(string _connect)
        {
            InitializeComponent();
            OracleConnection connect_temp = new OracleConnection(_connect);
            this.connect = connect_temp;
            this._connect = _connect;
        }

        private void frmXemLuongPC_Load(object sender, EventArgs e)
        {
            
            loadNK();
        }

        private void loadNK()
        {
            connect.Open();

            OracleCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT OBJECT_SCHEMA, OBJECT_NAME, ACTION_NAME,SQL_TEXT, EVENT_TIMESTAMP, DBUSERNAME FROM UNIFIED_AUDIT_TRAIL WHERE OBJECT_NAME = 'NHANVIEN' AND ACTION_NAME = 'SELECT'";
            cmd.CommandType = CommandType.Text;

            OracleDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dgvNKXemLPC.DataSource = dataTable;

            connect.Close();
        }
    }
}
