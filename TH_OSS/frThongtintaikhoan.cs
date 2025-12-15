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
    public partial class frThongtintaikhoan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Students";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            dgvtaikhoansinhvien.DataSource = table;
        }
        public frThongtintaikhoan()
        {
            InitializeComponent();

        }

        private void frThongtintaikhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        private void btnThoattk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvtaikhoansinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgvtaikhoansinhvien.CurrentRow.Index;
            if (i >= 0)
            {
                txtstudentid.Text = dgvtaikhoansinhvien.Rows[i].Cells[0].Value.ToString();
                txtusername.Text = dgvtaikhoansinhvien.Rows[i].Cells[1].Value.ToString();
                txtpassword.Text = dgvtaikhoansinhvien.Rows[i].Cells[2].Value.ToString();
            }
        }

        private void frThongtintaikhoan_Load_1(object sender, EventArgs e)
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
        private bool InputValidation()
        {
            int nullString =  isnotEmpty(txtusername.Text) * isnotEmpty(txtpassword.Text);
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

        private void btnThemtk_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
            {
                return;
            }
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Students ( Username, Password) VALUES ( @Username, @Password)";
                command.Parameters.AddWithValue("@Username", txtusername.Text);
                command.Parameters.AddWithValue("@Password", txtpassword.Text);
                command.ExecuteNonQuery();
                loaddata();
            }
            catch
            {
                MessageBox.Show("MSSV đã tồn tại, không thể thêm !!!");
            }
        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
            txtstudentid.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
            loaddata();
            txttimMSSV.Text = " ";

        }

        private void btnXoatk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtstudentid.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.");
                return;
            }
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Students WHERE StudentID ='" + txtstudentid.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnSuatk_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
            {
                return;
            }
            if (string.IsNullOrEmpty(txtstudentid.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa.");
                return;
            }
            string query = "UPDATE Students SET Username = @Username, Password = @Password WHERE StudentID = @StudentID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@StudentID", txtstudentid.Text);
            command.Parameters.AddWithValue("@Username", txtusername.Text);
            command.Parameters.AddWithValue("@Password", txtpassword.Text);
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Sửa thông tin sinh viên thành công!");
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttimMSSV.Text))
            {
                string query = "SELECT * FROM Students WHERE StudentID LIKE @StudentID";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentID", "%" + txttimMSSV.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                table.Clear();
                adapter.Fill(table);
                dgvtaikhoansinhvien.DataSource = table;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập MSSV để tìm kiếm.");
            }
        }

    }
}
