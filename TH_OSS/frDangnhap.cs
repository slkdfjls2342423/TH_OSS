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
using TH_OSS;

namespace TH_OSS

{
    public partial class frDangnhap : Form
    {

        SqlConnection sqlcon = null;

        public frDangnhap()
        {

            InitializeComponent();

        }

        private void frDangnhap_Load(object sender, EventArgs e)
        {
            Thongbaoloi.Hide();
            LoiVaiTro.Hide();
            cbVaitro.Text = cbVaitro.Items[1].ToString();
            sqlcon = new SqlConnection(Program.conStr);
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string tk = txtTenDN.Text.Trim();
                string mk = txtMatkhau.Text.Trim();
                string Vaitro = cbVaitro.SelectedItem.ToString();
                if (string.IsNullOrEmpty(Vaitro))
                {
                    MessageBox.Show("Vui lòng chọn vai trò để đăng nhập!");
                }
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Connection = sqlcon;
                if (Vaitro == "Sinh viên")
                {
                    sqlcmd.CommandText = "SELECT * FROM Students WHERE Username = @Username AND Password = @Password";
                    sqlcmd.Parameters.AddWithValue("@Username", tk);
                    sqlcmd.Parameters.AddWithValue("@Password", mk);
                }
                else if (Vaitro == "Giảng viên")
                {
                    sqlcmd.CommandText = "SELECT * FROM Lecturers WHERE Username = @Username AND Password = @Password";
                    sqlcmd.Parameters.AddWithValue("@Username", tk);
                    sqlcmd.Parameters.AddWithValue("@Password", mk);
                }
                else if (Vaitro == "Quản trị")
                {
                    sqlcmd.CommandText = "SELECT * FROM Admins WHERE Username = @Username AND Password = @Password";
                    sqlcmd.Parameters.AddWithValue("@Username", tk);
                    sqlcmd.Parameters.AddWithValue("@Password", mk);
                }
                SqlDataReader data = sqlcmd.ExecuteReader();

                if (data.Read())
                {

                    if (Vaitro == "Sinh viên")
                    {
                        long studentId = Convert.ToInt64(data["StudentID"]);
                        frSinhvien formSinhvien = new frSinhvien(studentId);
                        formSinhvien.Show();
                    }
                    else if (Vaitro == "Giảng viên")
                    {
                        frGiangvien formLecturer = new frGiangvien();
                        formLecturer.Show();
                    }

                    else if (Vaitro == "Quản trị")
                    {
                        frQuantri formAdmin = new frQuantri();
                        formAdmin.Show();
                    }

                    this.Hide();
                }

                else
                {
                    Thongbaoloi.Show();
                }

                data.Close();

            }
            catch (Exception ex)
            {
                LoiVaiTro.Show();
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbhtmk_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMatkhau.PasswordChar == '•')
            {
                txtMatkhau.PasswordChar = '\0';
            }
            else if (txtMatkhau.PasswordChar == '\0')
            {
                txtMatkhau.PasswordChar = '•';
            }
        }

        private void frDangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
