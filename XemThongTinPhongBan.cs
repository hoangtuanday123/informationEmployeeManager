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
    public partial class frmXemTTPB : Form
    {
        OracleConnection connect = null;
        public string _connect = "";
        public frmXemTTPB()
        {
            InitializeComponent();
        }
        public frmXemTTPB(string _connect)
        {
            InitializeComponent();
            OracleConnection connect_temp = new OracleConnection(_connect);
            this.connect = connect_temp;
            this._connect = _connect;
        }

        private void frmXemTTPB_Load(object sender, EventArgs e)
        {
            
            loadTTPhongBan();
        }

        private void loadTTPhongBan()
        {
            connect.Open();

            OracleCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM DBA_MNG.PHONGBAN";
            cmd.CommandType = CommandType.Text;

            OracleDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dgvTTBP.DataSource = dataTable;

            connect.Close();
        }
    }
}
