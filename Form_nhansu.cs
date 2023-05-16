using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHANVIEN;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace project_ATBM
{
    public partial class Form_nhansu : Form
    {
        string conStr ="";
        OracleConnection con = null;
        string _id;
        public Form_nhansu()
        {
            InitializeComponent();
        }
        public Form_nhansu(string _connect, string id)
        {
            InitializeComponent();
            this.conStr = _connect;
            this._id = id;
        }

        // PHONG BAN
        private void buttonxempb_Click(object sender, EventArgs e)
        {
            // show and hide
            datagridview.Visible = true;
            groupboxthempb.Visible = false;
            groupboxcapnhatpb.Visible = false;
            groupboxthemnv.Visible = false;
            groupboxcapnhatnv.Visible = false;

            // get data
            con = new OracleConnection(conStr);
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM DBA_MNG.PHONGBAN";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("MAPB", typeof(int));
            table.Columns.Add("TENPB", typeof(String));
            table.Columns.Add("TRPHG", typeof(String));
            DataRow row = null;
            while (reader.Read())
            {
                row = table.NewRow();
                row["MAPB"] = reader["MAPB"];
                row["TENPB"] = reader["TENPB"];
                row["TRPHG"] = reader["TRPHG"];
                table.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            datagridview.DataSource = table;
        }

        private void buttonthempb_Click(object sender, EventArgs e)
        {
            // show and hide
            datagridview.Visible = false;
            groupboxthempb.Visible = true;
            groupboxcapnhatpb.Visible = false;
            groupboxthemnv.Visible = false;
            groupboxcapnhatnv.Visible = false;
        }

        private void buttoncapnhatpb_Click(object sender, EventArgs e)
        {
            // show and hide
            datagridview.Visible = false;
            groupboxthempb.Visible = false;
            groupboxcapnhatpb.Visible = true;
            groupboxthemnv.Visible = false;
            groupboxcapnhatnv.Visible = false;

            textboxcapnhatpb_tenpb.Visible = false;
            textboxcapnhatpb_trphg.Visible = false;
        }

        private void buttonthempb_them_Click(object sender, EventArgs e)
        {
            if (textboxthempb_mapb.Text == "" || textboxthempb_tenpb.Text == "" || textboxthempb_trphg.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                con = new OracleConnection(conStr);
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = String.Format("INSERT INTO DBA_MNG.PHONGBAN VALUES ({0}, '{1}', '{2}')", textboxthempb_mapb.Text, textboxthempb_tenpb.Text, textboxthempb_trphg.Text);
                cmd.CommandType = CommandType.Text;
                int temp = cmd.ExecuteNonQuery();
                if (temp > 0)
                    MessageBox.Show("Them thanh cong");
                else
                    MessageBox.Show("Them khong thanh cong");
                con.Close();
            }
        }

        private void buttoncapnhatpb_tim_Click(object sender, EventArgs e)
        {
            if (textboxcapnhatpb_mapb.Text == "")
            {
                MessageBox.Show("Vui long nhap ma phong ban can cap nhat");
            }
            else
            {
                textboxcapnhatpb_tenpb.Visible = true;
                textboxcapnhatpb_trphg.Visible = true;

                con = new OracleConnection(conStr);
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = String.Format("SELECT TENPB, TRPHG FROM DBA_MNG.PHONGBAN WHERE MAPB = '{0}'", textboxcapnhatpb_mapb.Text);
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                textboxcapnhatpb_tenpb.Text = reader["TENPB"].ToString();
                textboxcapnhatpb_trphg.Text = reader["TRPHG"].ToString();
                reader.Close();
                con.Close();
            }
        }

        private void buttoncapnhatpb_capnhat_Click(object sender, EventArgs e)
        {
            con = new OracleConnection(conStr);
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = String.Format("UPDATE DBA_MNG.PHONGBAN SET TENPB = '{0}' , TRPHG = '{1}' WHERE MAPB = {2}", textboxcapnhatpb_tenpb.Text, textboxcapnhatpb_trphg.Text, textboxcapnhatpb_mapb.Text);
            cmd.CommandType = CommandType.Text;
            int temp = cmd.ExecuteNonQuery();
            if (temp > 0)
                MessageBox.Show("Cap nhat thanh cong");
            else
                MessageBox.Show("Cap nhat khong thanh cong");
            con.Close();
        }



        // NHAN VIEN
        private void buttonxemnv_Click(object sender, EventArgs e)
        {
            // show and hide
            datagridview.Visible = true;
            groupboxthempb.Visible = false;
            groupboxcapnhatpb.Visible = false;
            groupboxthemnv.Visible = false;
            groupboxcapnhatnv.Visible = false;

            // get data
            con = new OracleConnection(conStr);
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "dba_mng.PROC_NHANSU_KHONGTHAY_LUONGPHUCAP";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter cursor = new OracleParameter("cur", OracleDbType.RefCursor);
            cursor.Direction = ParameterDirection.Input;

            cmd.Parameters.Add(cursor);
            cmd.ExecuteNonQuery();
            OracleDataReader reader = ((OracleRefCursor)cursor.Value).GetDataReader();

            DataTable table = new DataTable();
            table.Columns.Add("MANV", typeof(String));
            table.Columns.Add("TENNV", typeof(String));
            table.Columns.Add("PHAI", typeof(String));
            table.Columns.Add("NGAYSINH", typeof(String));
            table.Columns.Add("DIACHI", typeof(String));
            table.Columns.Add("SODT", typeof(String));
            table.Columns.Add("VAITRO", typeof(String));
            table.Columns.Add("MANQL", typeof(String));
            table.Columns.Add("PHG", typeof(int));
            DataRow row = null;
            while (reader.Read())
            {
                row = table.NewRow();
                row["MANV"] = reader["MANV"];
                row["TENNV"] = reader["TENNV"];
                row["PHAI"] = reader["PHAI"];
                row["NGAYSINH"] = reader["NGAYSINH"];
                row["DIACHI"] = reader["DIACHI"];
                row["SODT"] = reader["SODT"];
                row["VAITRO"] = reader["VAITRO"];
                row["MANQL"] = reader["MANQL"];
                row["PHG"] = reader["PHG"];
                table.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            datagridview.DataSource = table;
        }

        private void buttonthemnv_Click(object sender, EventArgs e)
        {
            // show and hide
            datagridview.Visible = false;
            groupboxthempb.Visible = false;
            groupboxcapnhatpb.Visible = false;
            groupboxthemnv.Visible = true;
            groupboxcapnhatnv.Visible = false;
        }

        private void buttoncapnhatnv_Click(object sender, EventArgs e)
        {
            // show and hide
            datagridview.Visible = false;
            groupboxthempb.Visible = false;
            groupboxcapnhatpb.Visible = false;
            groupboxthemnv.Visible = false;
            groupboxcapnhatnv.Visible = true;

            textboxcapnhatnv_ngaysinh.Visible = false;
            textboxcapnhatnv_sdt.Visible = false;
            textboxcapnhatnv_diachi.Visible = false;
            textboxcapnhatnv_vaitro.Visible = false;
            textboxcapnhatnv_manql.Visible = false;
            textboxcapnhatnv_phg.Visible = false;
        }

        private void buttonthemnv_them_Click(object sender, EventArgs e)
        {
            if (textboxthemnv_manv.Text == "" || textboxthemnv_tennv.Text == "" || textboxthemnv_phai.Text == "" || textboxthemnv_vaitro.Text == "" || textboxthemnv_phg.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                if (textboxthemnv_manql.Text == "")
                    textboxthemnv_manql.Text = "NULL";

                con = new OracleConnection(conStr);
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = String.Format("INSERT INTO DBA_MNG.view_nhansu_khongthay_luongphucap(MANV, TENNV, PHAI, VAITRO, MANQL, PHG) VALUES ('{0}', '{1}', '{2}', '{3}', ", textboxthemnv_manv.Text, textboxthemnv_tennv.Text, textboxthemnv_phai.Text, textboxthemnv_vaitro.Text);
                cmd.CommandText += (textboxthemnv_manql.Text == "NULL")  ?  "NULL"  :  String.Format("'{0}'", textboxthemnv_manql.Text);
                cmd.CommandText += String.Format(", {0})", textboxthemnv_phg.Text);
                cmd.CommandType = CommandType.Text;
                int temp = cmd.ExecuteNonQuery();
                if (temp > 0)
                    MessageBox.Show("Them thanh cong");
                else
                    MessageBox.Show("Them khong thanh cong");
                con.Close();
            }
        }

        private void buttoncapnhatnv_tim_Click(object sender, EventArgs e)
        {
            if (textboxcapnhatnv_manv.Text == "")
            {
                MessageBox.Show("Vui long nhap ma phong ban can cap nhat");
            }
            else
            {
                textboxcapnhatnv_ngaysinh.Visible = true;
                textboxcapnhatnv_sdt.Visible = true;
                textboxcapnhatnv_diachi.Visible = true;
                textboxcapnhatnv_vaitro.Visible = true;
                textboxcapnhatnv_manql.Visible = true;
                textboxcapnhatnv_phg.Visible = true;

                con = new OracleConnection(conStr);
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = String.Format("SELECT TENNV, NGAYSINH, SODT, DIACHI, VAITRO, MANQL, PHG FROM DBA_MNG.view_nhansu_khongthay_luongphucap WHERE MANV = '{0}'", textboxcapnhatnv_manv.Text);
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();

                labelcapnhatnv_tennv.Text = reader["TENNV"].ToString();

                // ngaysinh co van de
                String temp = reader["NGAYSINH"].ToString();
                if (temp != "")
                    temp = temp.Substring(3, 2) + "/" + temp.Substring(0, 3) + temp.Substring(6, 4);
                textboxcapnhatnv_ngaysinh.Text = temp;

                textboxcapnhatnv_sdt.Text = reader["SODT"].ToString();
                textboxcapnhatnv_diachi.Text = reader["DIACHI"].ToString();
                textboxcapnhatnv_vaitro.Text = reader["VAITRO"].ToString();
                textboxcapnhatnv_manql.Text = reader["MANQL"].ToString();
                textboxcapnhatnv_phg.Text = reader["PHG"].ToString();
                reader.Close();
                con.Close();
            }
        }

        private void buttoncapnhatnv_capnhat_Click(object sender, EventArgs e)
        {
            con = new OracleConnection(conStr);
            con.Open();
            OracleCommand cmd = con.CreateCommand();

            if (textboxcapnhatnv_ngaysinh.Text != "")
                cmd.CommandText = String.Format("UPDATE DBA_MNG.view_nhansu_khongthay_luongphucap SET NGAYSINH = TO_DATE('{0}','MM/DD/YYYY'), SODT = '{1}', DIACHI = '{2}', VAITRO = '{3}', MANQL = '{4}', PHG = {5} WHERE MANV = '{6}'", 
                                                textboxcapnhatnv_ngaysinh.Text, textboxcapnhatnv_sdt.Text, textboxcapnhatnv_diachi.Text, textboxcapnhatnv_vaitro.Text, textboxcapnhatnv_manql.Text, textboxcapnhatnv_phg.Text, textboxcapnhatnv_manv.Text);
            else
                cmd.CommandText = String.Format("UPDATE DBA_MNG.view_nhansu_khongthay_luongphucap SET SODT = '{0}', DIACHI = '{1}', VAITRO = '{2}', MANQL = '{3}', PHG = {4} WHERE MANV = '{5}'",
                                                textboxcapnhatnv_sdt.Text, textboxcapnhatnv_diachi.Text, textboxcapnhatnv_vaitro.Text, textboxcapnhatnv_manql.Text, textboxcapnhatnv_phg.Text, textboxcapnhatnv_manv.Text);
            
            cmd.CommandType = CommandType.Text;
            int temp = cmd.ExecuteNonQuery();
            if (temp > 0)
                MessageBox.Show("Cap nhat thanh cong");
            else
                MessageBox.Show("Cap nhat khong thanh cong");
            con.Close();
        }



        private void Form_nhansu_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(conStr);
            con.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = con;
            command.CommandText = "DBA_MNG.SP_DECRYPTIONNHANVIEN";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("MANV_TEMP", OracleDbType.Varchar2).Value = this._id;
            command.ExecuteNonQuery();
            con.Close();
        }

        private void groupboxcapnhatnv_Enter(object sender, EventArgs e)
        {

        }

        private void INFOR_Click(object sender, EventArgs e)
        {
            frmNhanVien emp = new frmNhanVien(this.conStr, this._id);
            emp.ShowDialog();
            emp = null;
            this.Show();
        }
    }
}
