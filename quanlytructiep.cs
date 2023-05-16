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
using NHANVIEN;
namespace PHANHE1
{
    public partial class quanlytructiep : Form
    {
        OracleConnection connect = null;
        public string _connect = "";
        string id = "";
        public quanlytructiep()
        {
            InitializeComponent();
        }
        public quanlytructiep(string _connect, string id)
        {
            InitializeComponent();
            OracleConnection connect_temp = new OracleConnection(_connect);
            this.connect = connect_temp;
            this.id = id;
            this._connect = _connect;
            lblidnvqltt.Text = id;
        }

        private void quanlytructiep_Load(object sender, EventArgs e)
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

        private void btninfor_qltt_Click(object sender, EventArgs e)
        {
            frmNhanVien emp = new frmNhanVien(this._connect, this.id);
            emp.ShowDialog();
            emp = null;
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnnhanvien_qltt_Click(object sender, EventArgs e)
        {
            
            gbnhanvien_qltt.Visible = true;
            gbphancong_qltt.Visible = false;
            OracleCommand command = new OracleCommand();
            command.Connection = connect;
            command.CommandText = "DBA_MNG.PROC_NVQL";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("CUR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            //OracleDataReader reader = command.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            dgvnhanvienqltt.DataSource = table;
            connect.Close();
        }

        private void btnphancong_qltt_Click(object sender, EventArgs e)
        {
           
            gbnhanvien_qltt.Visible = false;
            gbphancong_qltt.Visible = true;
            connect.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connect;
            command.CommandText = "DBA_MNG.PROC_NVQL_PHANCONG";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("CUR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            dgvphancongqltt.DataSource = table;
            connect.Close();
        }

       
      
    }
}
