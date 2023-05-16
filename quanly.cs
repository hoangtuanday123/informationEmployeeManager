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
    public partial class quanly : Form
    {
        OracleConnection connect = null;
        public string _connect = "";
        string id = "";
        public quanly()
        {
            InitializeComponent();
        }
        public quanly(string _connect, string id)
        {
            InitializeComponent();
            OracleConnection connect_temp = new OracleConnection(_connect);
            this.connect = connect_temp;
            this.id = id;
            this._connect = _connect;
            lblidnvquanly.Text = id;
        }

        private void quanly_Load(object sender, EventArgs e)
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

        private void btnnhanvien_quanly_Click(object sender, EventArgs e)
        {
            gbnhanvien_quanly.Visible = true;
            gbphancong_quanly.Visible = false;
            connect.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connect;
            command.CommandText = "DBA_MNG.PROC_MNG_PHG";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("CUR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            dgvnhanvien_quanly.DataSource = table;
            connect.Close();

        }

        private void gbphancong_quanly_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnphancong_quanly_Click(object sender, EventArgs e)
        {
            
            gbnhanvien_quanly.Visible = false;
            gbphancong_quanly.Visible = true;
            connect.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connect;
            command.CommandText = "dba_mng.PROC_SELECT_MODIFIED_PHANCONG";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("CUR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            dgvphancong_quanly.DataSource = table;
            connect.Close();
        }

        private void dgvphancong_quanly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvphancong_quanly.Rows[e.RowIndex];
                txtmanvphancong_quanly.Text = row.Cells["MANV"].Value.ToString();
                txtmadaphancong_quanly.Text= row.Cells["MADA"].Value.ToString();
                txtthoigianphancong_quanly.Text= row.Cells["THOIGIAN"].Value.ToString();
            }
        }

        private void btninsertphancong_quanly_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OracleCommand command = new OracleCommand();
                command.Connection = connect;
                String sql = string.Format("INSERT INTO DBA_MNG.MODIFIED_PHANCONG VALUES('{2}','{0}',TO_DATE('{1}','MM/DD/YYYY'))", txtmadaphancong_quanly.Text, txtthoigianphancong_quanly.Text, txtmanvphancong_quanly.Text);
                //MessageBox.Show(sql);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                int n = command.ExecuteNonQuery();
                if (n > 0)
                {


                    MessageBox.Show("INSERT SUCCESSFULL");
                }
                
                connect.Close();
            }
            catch 
            {
                MessageBox.Show("INSERT FAIL");
                connect.Close();
            }
        }

        private void btnupdatephancong_quanly_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OracleCommand command = new OracleCommand();
                command.Connection = connect;
                String sql = string.Format("UPDATE DBA_MNG.MODIFIED_PHANCONG SET THOIGIAN=TO_DATE('{1}','MM/DD/YYYY') WHERE MANV='{2}' AND MADA='{0}'", txtmadaphancong_quanly.Text, txtthoigianphancong_quanly.Text, txtmanvphancong_quanly.Text);
                //MessageBox.Show(sql);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                try
                {
                    int n = command.ExecuteNonQuery();
                    if (n > 0)
                    {
                        MessageBox.Show("UPDATE SUCCESSFULL");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                    
               connect.Close();
                
            }
            catch 
            {
                MessageBox.Show("UPDATE FAIL");
                connect.Close();
            }
        }

        private void btndeletephancong_quanly_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OracleCommand command = new OracleCommand();
                command.Connection = connect;
                String sql = string.Format("DELETE DBA_MNG.MODIFIED_PHANCONG WHERE MANV='{0}'AND MADA='{1}'", txtmanvphancong_quanly.Text, txtmadaphancong_quanly.Text);
                //MessageBox.Show(sql);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                int n = command.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("DELETE SUCCESSFULL");
                }
                connect.Close();
            }
            catch 
            {
                MessageBox.Show("DELETE FAIL");
                connect.Close();
            }
        }

        private void btninfor_quanly_Click(object sender, EventArgs e)
        {
            frmNhanVien emp = new frmNhanVien(this._connect,this.id);
            emp.ShowDialog();
            emp = null;
            this.Show();
        }
    }
}
