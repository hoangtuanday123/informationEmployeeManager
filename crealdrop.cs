using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PH1_5
{
    public partial class CreateAlterDrop : Form
    {
        String stringConnect = "";
        string id = "";
        public CreateAlterDrop()
        {
            InitializeComponent();
        }
        public CreateAlterDrop(string _connect, string id)
        {
            InitializeComponent();
            //connect = new OracleConnection(_connect);
            this.id = id;
            this.stringConnect = _connect;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(stringConnect);
            conn.Open();

            if (cbRole.Checked)
            {
                if (cbPassword.Checked == false)

                {
                    String sqlStr1 = "ALTER SESSION SET \"_ORACLE_SCRIPT\"=TRUE";
                    String sqlStr2 = "CREATE ROLE " + txtUserName.Text;

                    OracleCommand cmd1 = new OracleCommand(sqlStr1, conn);
                    OracleCommand cmd2 = new OracleCommand(sqlStr2, conn);

                    try
                    {
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Sucessfull !");
                    }
                    catch
                    {
                        MessageBox.Show("Fail !");
                    }
                }
                else
                {
                    String sqlStr1 = "ALTER SESSION SET \"_ORACLE_SCRIPT\"=TRUE";
                    String sqlStr2 = "CREATE ROLE " +txtUserName.Text+" IDENTIFIED BY "+txtPassword.Text;

                    OracleCommand cmd1 = new OracleCommand(sqlStr1, conn);
                    OracleCommand cmd2 = new OracleCommand(sqlStr2, conn);

                    try
                    {
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Sucessfull !");
                    }
                    catch
                    {
                        MessageBox.Show("Fail !");
                    }
                }    

            }
            else
            {
                String sqlStr1 = "ALTER SESSION SET \"_ORACLE_SCRIPT\"=TRUE";
                String sqlStr2 = "CREATE USER " +txtUserName.Text+" IDENTIFIED BY "+txtPassword.Text;

                OracleCommand cmd1 = new OracleCommand(sqlStr1, conn);
                OracleCommand cmd2 = new OracleCommand(sqlStr2, conn);
                try
                {
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Sucessfull !");
                }
                catch
                {
                    MessageBox.Show("Fail !");
                }

            }
            conn.Close();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(stringConnect);
            conn.Open();

            if (cbRole.Checked)
            {
                String sqlStr1 = "ALTER SESSION SET \"_ORACLE_SCRIPT\"=TRUE";
                String sqlStr2 = "ALTER ROLE " +txtUserName.Text+ " IDENTIFIED BY "+txtPassword.Text;

                OracleCommand cmd1 = new OracleCommand(sqlStr1, conn);
                OracleCommand cmd2 = new OracleCommand(sqlStr2, conn);

                try
                {
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Sucessfull !");
                }
                catch
                {
                    MessageBox.Show("Fail !");
                }

            }
            else
            {
                String sqlStr1 = "ALTER SESSION SET \"_ORACLE_SCRIPT\"=TRUE";
                String sqlStr2 = "ALTER USER " + txtUserName.Text + " IDENTIFIED BY " + txtPassword.Text;

                OracleCommand cmd1 = new OracleCommand(sqlStr1, conn);
                OracleCommand cmd2 = new OracleCommand(sqlStr2, conn);

                try
                {
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Sucessfull !");
                }
                catch
                {
                    MessageBox.Show("Fail !");
                }  
            }
            conn.Close();
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(stringConnect);
            conn.Open();

            if (cbRole.Checked)
            {
                String sqlStr1 = "ALTER SESSION SET \"_ORACLE_SCRIPT\"=TRUE";
                String sqlStr2 = "DROP ROLE " + txtUserName.Text;

                OracleCommand cmd1 = new OracleCommand(sqlStr1, conn);
                OracleCommand cmd2 = new OracleCommand(sqlStr2, conn);

                try
                {
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Sucessfull !");
                }
                catch
                {
                    MessageBox.Show("Fail !");
                }

            }
            else
            {
                String sqlStr1 = "ALTER SESSION SET \"_ORACLE_SCRIPT\"=TRUE";
                String sqlStr2 = "DROP USER " + txtUserName.Text;

                OracleCommand cmd1 = new OracleCommand(sqlStr1, conn);
                OracleCommand cmd2 = new OracleCommand(sqlStr2, conn);

                try
                {
                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Sucessfull !");
                }
                catch
                {
                    MessageBox.Show("Fail !");
                }
                
            }
            conn.Close();
        }

        private void CreateAlterDrop_Load(object sender, EventArgs e)
        {

        }
    }
}
