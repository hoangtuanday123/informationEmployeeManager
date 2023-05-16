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
    public partial class frmAudit : Form
    {
        OracleConnection connect = null;
        public string _connect = "";
        string id = "";
        public frmAudit()
        {
            InitializeComponent();
        }
        public frmAudit(string _connect, string id)
        {
            InitializeComponent();
            OracleConnection connect_temp = new OracleConnection(_connect);
            this.connect = connect_temp;
            this.id = id;
            this._connect = _connect;
        }

        private void btnNKCapNhatTG_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCapNhatThoiGian frmCNTG  = new frmCapNhatThoiGian(_connect);
            frmCNTG.ShowDialog();
            frmCNTG = null;
            this.Show();
        }

        private void btnNKXemLPC_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmXemLuongPC frmXLPC = new frmXemLuongPC(_connect);
            frmXLPC.ShowDialog();
            frmXLPC = null;
            this.Show();
        }

        private void btnNKCapNhatLPC_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCapNhatLPC frmCNLPC = new frmCapNhatLPC(_connect);
            frmCNLPC.ShowDialog();
            frmCNLPC = null;
            this.Show();
        }

        private void frmAudit_Load(object sender, EventArgs e)
        {

        }
    }
}
