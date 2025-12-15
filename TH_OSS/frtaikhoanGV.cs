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

namespace TH_OSS
{
    public partial class frtaikhoanGV : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Lecturers";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            dgvtkgv.DataSource = table;
        }

        public frtaikhoanGV()
        {
            InitializeComponent();
        }
        private void frtaikhoanGV_Load(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new SqlConnection(Program.conStr);
            }

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            loaddata();

        }
        private void frThongtintaikhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgvtkgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvtkgv.CurrentRow.Index;
            if (i >= 0)
            {
                txtlecturerid.Text = dgvtkgv.Rows[i].Cells[0].Value.ToString();
                txtusername.Text = dgvtkgv.Rows[i].Cells[1].Value.ToString();
                txtpassword.Text = dgvtkgv.Rows[i].Cells[2].Value.ToString();
            }
        }
        private bool InputValidation()
        {
            int nullString =  isnotEmpty(txtusername.Text) * isnotEmpty(txtpassword.Text) ;
            if (nullString == 0)
            {
                MessageBox.Show("Nhap day du thong tin");
                return false;
            }

            return true;
        }
        private int isnotEmpty(string text)
        {
            return string.IsNullOrEmpty(text) ? 0 : 1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
            {
                return;
            }
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Lecturers (Username, Password) VALUES ( @Username, @Password)";
                command.Parameters.AddWithValue("@Username", txtusername.Text);
                command.Parameters.AddWithValue("@Password", txtpassword.Text);
                command.ExecuteNonQuery();
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm giảng viên: " + ex.Message);
                return;
            }
        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {

            txtlecturerid.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
            {
                return;
            }
            string query = "UPDATE Lecturers SET Username = @Username, Password = @Password WHERE LecturerID = @LecturerID";
            command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@LecturerID", txtlecturerid.Text);
            command.Parameters.AddWithValue("@Username", txtusername.Text);
            command.Parameters.AddWithValue("@Password", txtpassword.Text);
            int rows = command.ExecuteNonQuery();
            loaddata();
            if (rows > 0)
                MessageBox.Show("Sửa thông tin thành công!");
            else
                MessageBox.Show("Sửa thông tin thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(isnotEmpty(txtlecturerid.Text) == 0)
            {
                MessageBox.Show("Vui lòng chọn giảng viên để xóa!");
                return;
            }
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Lecturers WHERE LecturerID ='" + txtlecturerid.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
