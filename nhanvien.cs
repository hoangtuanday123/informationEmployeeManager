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
    public partial class frmNhanVien : Form
    {
        OracleConnection connect = null;
        public string _connect = "";
        string id = "";
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public frmNhanVien(string _connect, string id)
        {
            InitializeComponent();
            OracleConnection connect_temp = new OracleConnection(_connect);
            this.connect = connect_temp;
            this.id = id;
            this._connect = _connect;
        }

        private void btnXemTTDeAn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmXemThongTinDeAn frmXTTDA = new frmXemThongTinDeAn(_connect);
            frmXTTDA.ShowDialog();
            frmXTTDA = null;
            this.Show();
        }

        private void btnXemTTPB_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmXemTTPB frmTTPB = new frmXemTTPB(_connect);
            frmTTPB.ShowDialog();
            frmTTPB = null;
            this.Show();
        }

        private void btnXemPhanCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmXemPC frmXemPhanCong = new frmXemPC(_connect);
            frmXemPhanCong.ShowDialog();
            frmXemPhanCong = null;
            this.Show();
        }

        private void btnXemTTCaNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmXemTTCN frmXemTTCaNhan = new frmXemTTCN(_connect);
            frmXemTTCaNhan.ShowDialog();
            frmXemTTCaNhan = null;
            this.Show();
        }

        private void btnCapNhatTTCaNhan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCapNhatTTCN frmCNTTCN = new frmCapNhatTTCN(_connect);
            frmCNTTCN.ShowDialog();
            frmCNTTCN= null;
            this.Show();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            connect.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connect;
            command.CommandText = "DBA_MNG.SP_DECRYPTIONNHANVIEN";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("MANV_TEMP", OracleDbType.Varchar2).Value = this.id;
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}
