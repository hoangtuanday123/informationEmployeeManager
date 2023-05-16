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
using Oracle.ManagedDataAccess.Types;
using NHANVIEN;
using PHANHE1;
namespace GUI_ATBMTT_CS4
{
    public partial class Fiance : Form
    {
        OracleConnection con = null;
        public string stringConnection = "";
        string manv = "";
        public Fiance()
        {
            InitializeComponent();
            grbNhanVien.Visible = false;
            grbPhongBan.Visible = false;
            grbThongTinCaNhan.Visible = false;
        }
        public Fiance(string _connect,string id)
        {
            InitializeComponent();
            grbNhanVien.Visible = false;
            grbPhongBan.Visible = false;
            grbThongTinCaNhan.Visible = false;
            OracleConnection connect_temp = new OracleConnection(_connect);
            this.con = connect_temp;
            this.manv = id;
            this.stringConnection = _connect;
           
        }

        //public static string stringConnection1 = @"DBA PRIVILEGE=SYSDBA;TNS_ADMIN=C:\Users\vohoa\Oracle\network\admin;USER ID=SYS; PASSWORD = giatin2002*;DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True";
       

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            //grbNhanVien.Visible = false;
            //grbPhongBan.Visible = false;
            //grbThongTinCaNhan.Visible = true;
            //con.Open();
            //string proc = "DBA_MNG.CUR_InformationFiance";
            //OracleCommand cmd = new OracleCommand(proc, con);          
            //cmd.CommandType = CommandType.StoredProcedure;
            //OracleParameter parameter = cmd.Parameters.Add("CUR", OracleDbType.RefCursor, ParameterDirection.Output);
            //cmd.Parameters.Add("ma", OracleDbType.Varchar2).Value = manv;
            //OracleDataReader reader = cmd.ExecuteReader();
            //int rowIndex = 0;
            //while (reader.Read())
            //{
            //    if (rowIndex == 0)
            //    {

            //        txtHoTen.Text = reader.GetOracleString(reader.GetOrdinal("TENNV")).Value;
            //        txtMaNV.Text = reader.GetOracleString(reader.GetOrdinal("MANV")).Value;
            //        txtGioiTinh.Text = reader.GetOracleString(reader.GetOrdinal("PHAI")).Value;
            //        txtNgaySinh.Text = reader.GetOracleString(reader.GetOrdinal("NGAYSINH")).Value;
            //        txtDiaChi.Text = reader.GetOracleString(reader.GetOrdinal("DIACHI")).Value;
            //        txtSDT.Text = reader.GetOracleString(reader.GetOrdinal("SODT")).Value;

            //        txtPhongBan.Text = reader.GetOracleString(reader.GetOrdinal("PHG")).Value;
            //        txtVaiTro.Text = reader.GetOracleString(reader.GetOrdinal("VAITRO")).Value;
            //        if (!reader.IsDBNull(reader.GetOrdinal("PHUCAP")))
            //        {
            //            txtPhuCap.Text = reader.GetOracleString(reader.GetOrdinal("PHUCAP")).Value;
            //        }
            //        else
            //        {
            //            txtPhuCap.Text = "";
            //        }

            //        if (!reader.IsDBNull(reader.GetOrdinal("LUONG")))
            //        {
            //            txtLuong.Text = reader.GetOracleString(reader.GetOrdinal("LUONG")).Value;
            //        }
            //        else
            //        {
            //            txtLuong.Text = "";
            //        }

            //        break;
            //    }
            //    rowIndex++;
            //}
            //reader.Close();
            //con.Close();
            frmNhanVien emp = new frmNhanVien(this.stringConnection, this.manv);
            emp.ShowDialog();
            emp = null;
            this.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            grbNhanVien.Visible = true;
            grbPhongBan.Visible = false;
            grbThongTinCaNhan.Visible = false;
            con.Open();
            string proc = "DBA_MNG.CUR_NVV";
            OracleCommand cmd = new OracleCommand(proc, con);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter parameter = cmd.Parameters.Add("CUR", OracleDbType.RefCursor, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvNhanVien.DataSource = table;
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            string proc = "DBA_MNG.sp_updateInformation";
            OracleCommand cmd = new OracleCommand(proc, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("ma", OracleDbType.Varchar2).Value = txtMaNVUpdate.Text;
            cmd.Parameters.Add("l", OracleDbType.Int32).Value = int.Parse(txtLuongUpdate.Text);
            cmd.Parameters.Add("pc", OracleDbType.Int32).Value = int.Parse(txtPhuCapUpdate.Text);
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update thành công!!!");
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("update không thành công" + ex.Message);
            }
            
            string proc1 = "DBA_MNG.CUR_NVV";
            OracleCommand cmd1 = new OracleCommand(proc1, con);
            cmd1.CommandType = CommandType.StoredProcedure;
            OracleParameter parameter = cmd1.Parameters.Add("CUR", OracleDbType.RefCursor, ParameterDirection.Output);
            cmd1.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(cmd1);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvNhanVien.DataSource = table;
            con.Close();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgvNhanVien.Rows[index];
            txtMaNVUpdate.Text = row.Cells[0].Value.ToString();
            if (row.Cells[7].Value != null)
                txtLuongUpdate.Text = row.Cells[7].Value.ToString();
            else
                txtLuongUpdate.Text = "";

            if (row.Cells[8].Value != null)
                txtPhuCapUpdate.Text = row.Cells[8].Value.ToString();
            else
                txtPhuCapUpdate.Text = "";

        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            grbNhanVien.Visible = false;
            grbPhongBan.Visible = true;
            grbThongTinCaNhan.Visible = false;
            con.Open();
            string proc = "DBA_MNG.CUR_PCV";
            OracleCommand cmd = new OracleCommand(proc, con);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter parameter = cmd.Parameters.Add("CUR", OracleDbType.RefCursor, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dgvPhongBan.DataSource = table;
            con.Close();
        }

        private void Fiance_Load(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = con;
            command.CommandText = "DBA_MNG.SP_FINANCE_DECRYPTIONNHANVIEN";
            command.CommandType = CommandType.StoredProcedure;
   
            command.ExecuteNonQuery();
            con.Close();
        }

        private void btnmanager_Click(object sender, EventArgs e)
        {
            managerfinance manager = new managerfinance(this.stringConnection, this.manv);
            manager.ShowDialog();
            manager = null;
            this.Show();
        }
    }
}