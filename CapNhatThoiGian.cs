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

namespace AUDIT
{
    public partial class frmCapNhatThoiGian : Form
    {
        OracleConnection connect = null;
        public string _connect = "";
        public frmCapNhatThoiGian()
        {
            InitializeComponent();
        }
        public frmCapNhatThoiGian(string _connect)
        {
            InitializeComponent();
            OracleConnection connect_temp = new OracleConnection(_connect);
            this.connect = connect_temp;
            this._connect = _connect;
        }

        private void frmCapNhatThoiGian_Load(object sender, EventArgs e)
        {
           
            loadNK();
        }
        private void loadNK()
        {
            connect.Open();

            OracleCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM AUDIT_LOG";
            cmd.CommandType = CommandType.Text;

            OracleDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dgvNKCapNhatTG.DataSource = dataTable;

            connect.Close();
        }
    }
}
