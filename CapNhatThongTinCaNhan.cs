using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace NHANVIEN
{
    public partial class frmCapNhatTTCN : Form
    {
       
        OracleCommand _command;
        String sqlStr;
        OracleConnection connect = null;
        public string _connect = "";
        public frmCapNhatTTCN()
        {
            InitializeComponent();
        }
        public frmCapNhatTTCN(string _connect)
        {
            InitializeComponent();
            OracleConnection connect_temp = new OracleConnection(_connect);
            this.connect = connect_temp;
            this._connect = _connect;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            connect.Open();
            if ((string.IsNullOrEmpty(txtNgaySinh.Text) == false) && (string.IsNullOrEmpty(txtDiaChi.Text) == true) && (string.IsNullOrEmpty(txtSDT.Text) == true))
            {
                sqlStr = String.Format("UPDATE DBA_MNG.NV SET NGAYSINH = TO_DATE('{0}','YYYY/MM/DD')", txtNgaySinh.Text);
            }
            else if ((string.IsNullOrEmpty(txtNgaySinh.Text) == true) && (string.IsNullOrEmpty(txtDiaChi.Text) == false) && (string.IsNullOrEmpty(txtSDT.Text) == true))
            {
                sqlStr = String.Format("UPDATE DBA_MNG.NV SET DIACHI = '{0}'", txtDiaChi.Text);
            }
            else if ((string.IsNullOrEmpty(txtNgaySinh.Text) == true) && (string.IsNullOrEmpty(txtDiaChi.Text) == true) && (string.IsNullOrEmpty(txtSDT.Text) == false))
            {
                sqlStr = String.Format("UPDATE DBA_MNG.NV SET SODT = '{0}'", txtSDT.Text);
            }
            else if ((string.IsNullOrEmpty(txtNgaySinh.Text) == false) && (string.IsNullOrEmpty(txtDiaChi.Text) == false) && (string.IsNullOrEmpty(txtSDT.Text) == true))
            {
                sqlStr = String.Format("UPDATE DBA_MNG.NV SET NGAYSINH = TO_DATE('{0}','YYYY/MM/DD'),DIACHI = '{1}'", txtNgaySinh.Text, txtDiaChi.Text);
            }
            else if ((string.IsNullOrEmpty(txtNgaySinh.Text) == true) && (string.IsNullOrEmpty(txtDiaChi.Text) == false) && (string.IsNullOrEmpty(txtSDT.Text) == false))
            {
                sqlStr = String.Format("UPDATE DBA_MNG.NV SET DIACHI = '{0}', SODT ='{1}'", txtDiaChi.Text, txtSDT.Text);
            }
            else if ((string.IsNullOrEmpty(txtNgaySinh.Text) == false) && (string.IsNullOrEmpty(txtDiaChi.Text) == true) && (string.IsNullOrEmpty(txtSDT.Text) == false))
            {
                sqlStr = String.Format("UPDATE DBA_MNG.NV SET NGAYSINH = TO_DATE('{0}','YYYY/MM/DD'), SODT = '{1}'", txtNgaySinh.Text, txtSDT.Text);
            }
            else
            {
                sqlStr = String.Format("UPDATE DBA_MNG.NV SET NGAYSINH  = TO_DATE('{0}','YYYY/MM/DD'),DIACHI = '{1}',SODT='{2}'", txtNgaySinh.Text, txtDiaChi.Text, txtSDT.Text);
            }    

            _command = new OracleCommand(sqlStr);
            _command.Connection = connect;

            int n = _command.ExecuteNonQuery();
            if (n>0)
            {
                MessageBox.Show("Update successfully !");
            }
            else
            {
                MessageBox.Show("Update fail !");
            }

            connect.Close();
        }

        private void frmCapNhatTTCN_Load(object sender, EventArgs e)
        {

        }
    }
}
