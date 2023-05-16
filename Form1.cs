using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using NHANVIEN;
using AUDIT;
using GUI_ATBMTT_CS4;
using project_ATBM;

namespace PHANHE1
{
    public partial class Form1 : Form
    {
        OracleConnection connect = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string  id="";
            string _connect = @"Data Source=localhost:1521/xe;User ID=DBA_MNG;Password=DBA_MNG";
            OracleConnection connect = new OracleConnection(_connect);
            connect.Open();
            OracleCommand command = new OracleCommand();
            command.Connection = connect;
            command.CommandText = "SP_LOGIN";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("USER_NAME", OracleDbType.Varchar2).Value = username;
            command.Parameters.Add("PASS", OracleDbType.Varchar2).Value = password;
            command.Parameters.Add("ROLE_NAME", OracleDbType.Varchar2, 10).Direction = ParameterDirection.Output;
      
        
            OracleDataReader dr = command.ExecuteReader();
            if (command.Parameters["ROLE_NAME"].Value.ToString() == "SYS")
            {
                id = username;
                _connect = "DATA SOURCE=localhost:1521/xe;DBA PRIVILEGE=SYSDBA;USER ID=SYS;PASSWORD=123456";
                
                this.Hide();
                sys_dba sys = new sys_dba(_connect, id);
                sys.ShowDialog();
                sys = null;
                this.Show();
            }
            //ID000
            else if (command.Parameters["ROLE_NAME"].Value.ToString() == "D_MNG")
            {
               
                String connectpath = string.Format("Data Source=localhost:1521/xe;User ID={0};Password={1};", username, password);
                id = username;
                        
                _connect = connectpath;
                this.Hide();
                quanlytructiep d_mng = new quanlytructiep(_connect, id);
                d_mng.ShowDialog();
                d_mng = null;
                this.Show();
                // GAN LUONG VA PHU CAP LA NULL KHI THOAT GIAO DIEN D_MNG
                OracleConnection connect_temp = new OracleConnection(_connect);
                connect_temp.Open();
                command= new OracleCommand();
                command.Connection = connect_temp;
                command.CommandText = "DBA_MNG.SP_UPDATEAFTERDECRYPTION";
                command.CommandType = CommandType.StoredProcedure;
               command.ExecuteNonQuery();

            }
            //ID020
            else if(command.Parameters["ROLE_NAME"].Value.ToString() == "MNG")
            {
                String connectpath = string.Format("Data Source=localhost:1521/xe;User ID={0};Password={1};", username, password);
                id = username;
                _connect = connectpath;
                this.Hide();
                quanly mng = new quanly(_connect, id);
                mng.ShowDialog();
                mng = null;
                this.Show();
                // GAN LUONG VA PHU CAP LA NULL KHI THOAT GIAO DIEN D_MNG
                OracleConnection connect_temp = new OracleConnection(_connect);
                connect_temp.Open();
                command = new OracleCommand();
                command.Connection = connect_temp;
                command.CommandText = "DBA_MNG.SP_UPDATEAFTERDECRYPTION";
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();

            }
            //ID042
            else if (command.Parameters["ROLE_NAME"].Value.ToString() == "EMPLOYEE")
            {
                String connectpath = string.Format("Data Source=localhost:1521/xe;User ID={0};Password={1};", username, password);
                id = username;
                _connect = connectpath;
                frmNhanVien emp = new frmNhanVien(_connect, id);
                emp.ShowDialog();
                emp = null;
                this.Show();
                // GAN LUONG VA PHU CAP LA NULL KHI THOAT GIAO DIEN D_MNG
                OracleConnection connect_temp = new OracleConnection(_connect);
                connect_temp.Open();
                command = new OracleCommand();
                command.Connection = connect_temp;
                command.CommandText = "DBA_MNG.SP_UPDATEAFTERDECRYPTION";
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
            }
            //DBA_MNG
            else if (command.Parameters["ROLE_NAME"].Value.ToString() == "DBA_MNG")
            {
                String connectpath = _connect;
                id = username;
                _connect = connectpath;
                frmAudit audit = new frmAudit(_connect, id);
                audit.ShowDialog();
                audit = null;
                this.Show();
               
            }
            //ID028
            else if (command.Parameters["ROLE_NAME"].Value.ToString() == "FINANCE")
            {
                String connectpath = string.Format("Data Source=localhost:1521/xe;User ID={0};Password={1};", username, password);
                id = username;
                _connect = connectpath;
                Fiance finance = new Fiance(_connect, id);
                finance.ShowDialog();
                finance = null;
                this.Show();
                // GAN LUONG VA PHU CAP LA NULL KHI THOAT GIAO DIEN D_MNG
                OracleConnection connect_temp = new OracleConnection(_connect);
                connect_temp.Open();
                command = new OracleCommand();
                command.Connection = connect_temp;
                command.CommandText = "DBA_MNG.SP_FINANCE_UPDATEAFTERDECRYPTION";
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                OracleCommand command1 = new OracleCommand();
                command1.Connection = connect_temp;
                command1.CommandText = "DBA_MNG.SP_UPDATEAFTERDECRYPTION";
                command1.CommandType = CommandType.StoredProcedure;
                command1.ExecuteNonQuery();
            }
            //ID033
            else if (command.Parameters["ROLE_NAME"].Value.ToString() == "PERSONNEL")
            {
                String connectpath = string.Format("Data Source=localhost:1521/xe;User ID={0};Password={1};", username, password);
                id = username;
                _connect = connectpath;
                Form_nhansu nhansu = new Form_nhansu(_connect, id);
                nhansu.ShowDialog();
                nhansu = null;
                this.Show();
                // GAN LUONG VA PHU CAP LA NULL KHI THOAT GIAO DIEN D_MNG
                OracleConnection connect_temp = new OracleConnection(_connect);
                connect_temp.Open();
                command = new OracleCommand();
                command.Connection = connect_temp;
                command.CommandText = "DBA_MNG.SP_UPDATEAFTERDECRYPTION";
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                
            }
            //id038
            else if (command.Parameters["ROLE_NAME"].Value.ToString() == "PROLEADER")
            {
                String connectpath = string.Format("Data Source=localhost:1521/xe;User ID={0};Password={1};", username, password);
                id = username;
                _connect = connectpath;
                Form_truongdean LEADER = new Form_truongdean(_connect, id);
                LEADER.ShowDialog();
                LEADER = null;
                this.Show();
                // GAN LUONG VA PHU CAP LA NULL KHI THOAT GIAO DIEN D_MNG
                OracleConnection connect_temp = new OracleConnection(_connect);
                connect_temp.Open();
                command = new OracleCommand();
                command.Connection = connect_temp;
                command.CommandText = "DBA_MNG.SP_UPDATEAFTERDECRYPTION";
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("error");
            }
            connect.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
