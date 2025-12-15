using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TH_OSS
{
    public partial class frGiangvien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        List<DataRow> sortedData = new List<DataRow>();

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void frGiangvien_Load_1(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new SqlConnection(Program.conStr);
            }
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            command = connection.CreateCommand();
            command.CommandText = " SELECT * FROM Diem";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvGiangvien.DataSource = table;
            dgvGiangvien.ReadOnly = true;
            loaddata();
        }

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Diem";

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            sortedData = table.AsEnumerable().ToList();
            if (!table.Columns.Contains("DiemTrungBinh"))
            {
                table.Columns.Add("DiemTrungBinh", typeof(double));
            }
            foreach (DataRow row in table.Rows)
            {
                double diem1 = Convert.ToDouble(row["Mon1"]);
                double diem2 = Convert.ToDouble(row["Mon2"]);
                double diem3 = Convert.ToDouble(row["Mon3"]);
                double diemTrungBinh = (diem1 + diem2 + diem3) / 3;

                row["DiemTrungBinh"] = Math.Round(diemTrungBinh, 2);
            }
            BubbleSort(sortedData, "TenSV");
            dgvGiangvien.DataSource = table;

        }

        public frGiangvien()
        {
            InitializeComponent();

        }

        private void frGiangvien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Program.conStr);
            connection.Open();
            loaddata();
            cbTimLop_CheckedChanged(sender, e);



        }
        private void frGiangvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }



        private void BTNDangXuat_Click(object sender, EventArgs e)
        {

            frDangnhap loginForm = new frDangnhap();
            this.Hide();
            loginForm.Show();
        }


        private bool InputValidation()
        {
            int nullString = isnotEmpty(txtMSSV.Text) * isnotEmpty(txtTenSV.Text) * isnotEmpty(txtLop.Text) * isnotEmpty(txtmon1.Text) * isnotEmpty(txtmon2.Text) * isnotEmpty(txtmon3.Text);
            if (nullString == 0)
            {
                MessageBox.Show("Nhap day du thong tin");
                return false;
            }
            int diem1;
            int diem2;
            int diem3;
            try
            {
                diem1 = int.Parse(txtmon1.Text);
                diem2 = int.Parse(txtmon2.Text);
                diem3 = int.Parse(txtmon3.Text);

            }
            catch
            {
                MessageBox.Show("loi diem");
                return false;
            }
            if (diem1 < 0 || diem1 > 10 || diem2 < 0 || diem2 > 10 || diem3 < 0 || diem3 > 10)
            {
                MessageBox.Show("Diem phai >= 0 va <=10");
                return false;
            }
            return true;
        }
        private int isnotEmpty(string text)
        {
            return string.IsNullOrEmpty(text) ? 0 : 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGiangvien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên!");
                return;
            }
            if (!InputValidation())
            {
                return;
            }
            string query = "UPDATE Diem SET Mon1 = @Mon1, Mon2 = @Mon2, Mon3 = @Mon3 WHERE MSSV = @MSSV";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MSSV", txtMSSV.Text);
            command.Parameters.AddWithValue("@Mon1", txtmon1.Text);
            command.Parameters.AddWithValue("@Mon2", txtmon2.Text);
            command.Parameters.AddWithValue("@Mon3", txtmon3.Text);
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Sửa điểm sinh viên thành công!");
        }

        private void dgvGiangvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMSSV.ReadOnly = true;
            txtTenSV.ReadOnly = true;
            txtLop.ReadOnly = true;
            int i;
            i = dgvGiangvien.CurrentRow.Index;
            txtMSSV.Text = dgvGiangvien.Rows[i].Cells[0].Value.ToString();
            txtTenSV.Text = dgvGiangvien.Rows[i].Cells[1].Value.ToString();
            txtLop.Text = dgvGiangvien.Rows[i].Cells[2].Value.ToString();
            txtmon1.Text = dgvGiangvien.Rows[i].Cells[4].Value.ToString();
            txtmon2.Text = dgvGiangvien.Rows[i].Cells[5].Value.ToString();
            txtmon3.Text = dgvGiangvien.Rows[i].Cells[6].Value.ToString();
        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
            txtMSSV.Text = " ";
            txtTenSV.Text = " ";
            txtLop.Text = " ";
            txtmon1.Text = " ";
            txtmon2.Text = " ";
            txtmon3.Text = " ";
            cbTimLop.Checked = false;
        }


        private void BubbleSort(List<DataRow> data, string criteria)
        {
            int n = data.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {

                    string value1 = data[j][criteria].ToString();
                    string value2 = data[j + 1][criteria].ToString();
                    if (string.Compare(value1, value2) > 0)
                    {

                        DataRow temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
                }
            }


            if (sortedData.Count > 0)
            {
                table = sortedData.CopyToDataTable();
                dgvGiangvien.DataSource = table;
            }
            else
            {
                // Nếu không có dữ liệu, gán DataSource về null để làm trống bảng hiển thị
                dgvGiangvien.DataSource = null;
            };
        }

        private void btnTimlop_Click(object sender, EventArgs e)
        {
            if (cbTimLop.Checked)
            {
                if (!string.IsNullOrEmpty(txtTimlop.Text))
                {

                    string query = "SELECT * FROM Diem WHERE Lop LIKE @Lop";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Lop", "%" + txtTimlop.Text + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    table.Clear();
                    adapter.Fill(table);

                    dgvGiangvien.DataSource = table;

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lớp để tìm kiếm.");
                }
            }
        }

        private void cbTimLop_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTimLop.Checked)
            {

            }
            else
            {
                txtTimlop.Text = "";
                loaddata();
            }
        }

        private void cbtieuchisx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCriteria = cbtieuchisx.SelectedItem.ToString();
            switch (selectedCriteria)
            {
                case "Tên Sinh Viên":
                    BubbleSort(sortedData, "TenSV");
                    break;
                case "MSSV":
                    BubbleSort(sortedData, "MSSV");
                    break;
                case "Lớp":
                    BubbleSort(sortedData, "Lop");
                    break;
                case "Điểm TB":
                    BubbleSort(sortedData, "DiemTrungBinh");
                    break;
                default:
                    BubbleSort(sortedData, "TenSV");
                    break;
            }

            table = sortedData.CopyToDataTable();
            dgvGiangvien.DataSource = table;
        }

        private void frGiangvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
