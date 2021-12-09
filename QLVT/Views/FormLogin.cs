using QLVT.Models;
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

namespace QLVT.Views
{
    public partial class FormLogin : Form
    {
        private SqlConnection sqlConn = new SqlConnection();
        public FormLogin()
        {
            InitializeComponent();
        }
        private void GetFragmentation(String strQuery)
        {
            DataTable dt = new DataTable();
            if (sqlConn.State == ConnectionState.Closed) sqlConn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(strQuery, sqlConn);
            sda.Fill(dt);
            sqlConn.Close();
            Program.bds_dspm.DataSource = dt;
            cmbBranch.DataSource = Program.bds_dspm;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";
        }

        private bool CheckChonnection()
        {
            if (sqlConn != null && sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
            }
            try
            {
                sqlConn.ConnectionString = Program.connStrOrigin;
                sqlConn.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối đến server gốc, vui lòng kiểm tra lại.\n" + e.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (!CheckChonnection()) return;
            GetFragmentation("SELECT * FROM Get_Subcriber");
            cmbBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranch.SelectedIndex = 1;
            cmbBranch.SelectedIndex = 0;
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = cmbBranch.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Vui long dien tai khoan va mat khau", "", MessageBoxButtons.OK);
                return;
            }
            Program.loginName = txtUsername.Text.Trim();
            Program.password = txtPassword.Text.Trim();
            if (!Program.CheckConnection()) return;

            Program.branchIndex = cmbBranch.SelectedIndex;
            Program.loginNameCurrent = Program.loginName;
            Program.passwordCurrent = Program.password;

            string strQuery = "EXEC Sp_GetInfoLogin " + Program.loginNameCurrent;
            Program.myReader = Program.ExecSqlDataReader(strQuery);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tai khoan khong co quyen truy cap, vui long kiem tra lai tai khoan, mat khau", "", MessageBoxButtons.OK);
                return;
            }
            Program.fullName = Program.myReader.GetString(1);
            Program.group = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.sqlConn.Close();

            Hide();
            FormMain fMain = new FormMain(this);
            fMain.UpdateInfoLogin();
            fMain.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
