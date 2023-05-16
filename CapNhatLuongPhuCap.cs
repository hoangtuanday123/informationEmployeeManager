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
    public partial class frmCapNhatLPC : Form
    {
        OracleConnection connect = null;
        public string _connect = "";
        public frmCapNhatLPC()
        {
            InitializeComponent();
        }
        public frmCapNhatLPC(string _connect)
        {
            InitializeComponent();
            OracleConnection connect_temp = new OracleConnection(_connect);
            this.connect = connect_temp;
            this._connect = _connect;
        }
        private void frmCapNhatLPC_Load(object sender, EventArgs e)
        {
   
            loadNK();
        }

        private void loadNK()
        {
            connect.Open();

            OracleCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT AU.* FROM AUDITLOG_LUONGNV AU, NHANVIEN WHERE (USERNAME = MANV AND VAITRO != 'Finance') OR USERNAME='DBA_MNG'";
            cmd.CommandType = CommandType.Text;

            OracleDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dgvCapNhatLPC.DataSource = dataTable;

            connect.Close();
        }
    }
}
