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

namespace project_ATBM
{
    public partial class Form_truongdean : Form
    {
        OracleConnection con = null;
        string conStr = "";
        string _id;
        public Form_truongdean()
        {
            InitializeComponent();
        }
        public Form_truongdean(string _connect, string id)
        {
            InitializeComponent();
            this.conStr = _connect;
            this._id = id;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // show and hide
            dataGridView1.Visible = false;
            groupboxthemdean.Visible = false;
            groupboxcapnhatdean.Visible = false;
            groupboxxoadean.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // show and hide
            dataGridView1.Visible = false;
            groupboxthemdean.Visible = false;
            groupboxcapnhatdean.Visible = true;
            groupboxxoadean.Visible = false;

            textboxcapnhatdean_tenda.Visible = false;
            textboxcapnhatdean_phong.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // show and hide
            dataGridView1.Visible = false;
            groupboxthemdean.Visible = true;
            groupboxcapnhatdean.Visible = false;
            groupboxxoadean.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // show and hide
            dataGridView1.Visible = true;
            groupboxthemdean.Visible = false;
            groupboxcapnhatdean.Visible = false;
            groupboxxoadean.Visible = false;

            // get data
            con = new OracleConnection(conStr);
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM DBA_MNG.DEAN";
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Columns.Add("MADA", typeof(String));
            table.Columns.Add("TENDA", typeof(String));
            table.Columns.Add("NGAYBD", typeof(String));
            table.Columns.Add("PHONG", typeof(int));
            DataRow row = null;
            while (reader.Read())
            {
                row = table.NewRow();
                row["MADA"] = reader["MADA"];
                row["TENDA"] = reader["TENDA"];
                row["NGAYBD"] = reader["NGAYBD"];
                row["PHONG"] = reader["PHONG"];
                table.Rows.Add(row);
            }
            reader.Close();
            con.Close();
            dataGridView1.DataSource = table;
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            if (textboxthemdean_mada.Text == "" || textboxthemdean_tenda.Text == "" || textboxthemdean_ngaybd.Text == "" || textboxthemdean_phong.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
            else
            {
                con = new OracleConnection(conStr);
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = String.Format("INSERT INTO DBA_MNG.DEAN VALUES ('{0}', '{1}', TO_DATE('{2}','MM/DD/YYYY'), {3})", textboxthemdean_mada.Text, textboxthemdean_tenda.Text, textboxthemdean_ngaybd.Text, textboxthemdean_phong.Text);
                cmd.CommandType = CommandType.Text;
                int temp = cmd.ExecuteNonQuery();
                if (temp > 0)
                    MessageBox.Show("Them thanh cong");
                else
                    MessageBox.Show("Them khong thanh cong");
                con.Close();
            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            if (textboxxoadean_mada.Text == "")
            {
                MessageBox.Show("Vui long nhap ma de an can xoa");
            }
            else
            {
                con = new OracleConnection(conStr);
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = String.Format("DELETE FROM DBA_MNG.DEAN WHERE MADA = '{0}'", textboxxoadean_mada.Text);
                cmd.CommandType = CommandType.Text;
                int temp = cmd.ExecuteNonQuery();
                if (temp > 0)
                    MessageBox.Show("Xoa thanh cong");
                else
                    MessageBox.Show("Xoa khong thanh cong");
                con.Close();
            }
        }

        private void buttontim_Click(object sender, EventArgs e)
        {
            if (textboxcapnhatdean_mada.Text == "")
            {
                MessageBox.Show("Vui long nhap ma de an can cap nhat");   
            }
            else
            {
                textboxcapnhatdean_tenda.Visible = true;
                textboxcapnhatdean_phong.Visible = true;

                con = new OracleConnection(conStr);
                con.Open();
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = String.Format("SELECT TENDA,PHONG FROM DBA_MNG.DEAN WHERE MADA = '{0}'", textboxcapnhatdean_mada.Text);
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                textboxcapnhatdean_tenda.Text = reader["TENDA"].ToString();
                textboxcapnhatdean_phong.Text = reader["PHONG"].ToString();
                reader.Close();
                con.Close();
            }
        }

        private void buttoncapnhat_Click(object sender, EventArgs e)
        {
            con = new OracleConnection(conStr);
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = String.Format("UPDATE DBA_MNG.DEAN  SET TENDA = '{0}', PHONG = {1} WHERE MADA = '{2}'", textboxcapnhatdean_tenda.Text, textboxcapnhatdean_phong.Text, textboxcapnhatdean_mada.Text);
            cmd.CommandType = CommandType.Text;
            int temp = cmd.ExecuteNonQuery();
            if (temp > 0)
                MessageBox.Show("Cap nhat thanh cong");
            else
                MessageBox.Show("Cap nhat khong thanh cong");
            con.Close();
        }

        private void Form_truongdean_Load(object sender, EventArgs e)
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

        private void information_Click(object sender, EventArgs e)
        {
            frmNhanVien emp = new frmNhanVien(this.conStr, this._id);
            emp.ShowDialog();
            emp = null;
            this.Show();
        }
    }
}
