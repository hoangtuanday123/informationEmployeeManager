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

namespace NHANVIEN
{
    public partial class frmXemPC : Form
    {
        OracleConnection connect = null;
        public string _connect = "";
        public frmXemPC()
        {
            InitializeComponent();
        }
        public frmXemPC(string _connect)
        {
            InitializeComponent();
            OracleConnection connect_temp = new OracleConnection(_connect);
            this.connect = connect_temp;
            this._connect = _connect;
        }

        private void frmXemPC_Load(object sender, EventArgs e)
        {
            
            loadPhanCong();
        }
        
        private void loadPhanCong()
        {
            connect.Open();

            OracleCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM DBA_MNG.PC";
            cmd.CommandType = CommandType.Text;

            OracleDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dgvXemPC.DataSource = dataTable;

            connect.Close();
        }
    }
}
