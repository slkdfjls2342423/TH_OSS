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
    public partial class frQuantri : Form
    {
        SqlConnection connection;
        SqlCommand command;
        List<DataRow> sortedData = new List<DataRow>();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = " SELECT * FROM Diem";
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

            if (sortedData.Count > 0)
            {
                table = sortedData.CopyToDataTable();
                dgvQuantri.DataSource = table;
            }
            else
            {
                // Nếu không có dữ liệu, gán DataSource về null để làm trống bảng hiển thị
                dgvQuantri.DataSource = null;
            }
            dgvQuantri.DataSource = table;

        }
        public frQuantri()
        {
            InitializeComponent();
        }

        private void frQuantri_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Program.conStr);
            connection.Open();
            dgvQuantri.ReadOnly = true;
            loaddata();
            cbTimkiem_CheckedChanged(sender, e);

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgvQuantri.CurrentRow.Index;
            txtMSSV.Text = dgvQuantri.Rows[i].Cells[0].Value.ToString();
            txtTenSV.Text = dgvQuantri.Rows[i].Cells[1].Value.ToString();
            txtLop.Text = dgvQuantri.Rows[i].Cells[2].Value.ToString();
            cbGioitinh.Text = dgvQuantri.Rows[i].Cells[3].Value.ToString();
            txtDiem1.Text = dgvQuantri.Rows[i].Cells[4].Value.ToString();
            txtDiem2.Text = dgvQuantri.Rows[i].Cells[5].Value.ToString();
            txtDiem3.Text = dgvQuantri.Rows[i].Cells[6].Value.ToString();
        }
        private bool InputValidation()
        {
            int nullString = isnotEmpty(txtMSSV.Text)*isnotEmpty(txtTenSV.Text)*isnotEmpty(txtLop.Text)*isnotEmpty(txtDiem1.Text)*isnotEmpty(txtDiem2.Text) * isnotEmpty(txtDiem3.Text) * isnotEmpty(cbGioitinh.Text);
            if (nullString == 0)
            {
                MessageBox.Show("Nhap day du thong tin");
                return false;
            }
            double diem1 ;
            double diem2 ;
            double diem3 ;
            try
            {
                diem1 = double.Parse(txtDiem1.Text);
                diem2 = double.Parse(txtDiem2.Text);
                diem3 = double.Parse(txtDiem3.Text);

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
            if(cbGioitinh.Text!="Nam" && cbGioitinh.Text != "Nu")
            {
                MessageBox.Show("NHap gioi tinh");
                return false;
            }
            return true;
        }
        private int isnotEmpty(string text)
        {
            return string.IsNullOrEmpty(text)?0:1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
                return;
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "insert into Diem values('" + txtMSSV.Text + "', N'" + txtTenSV.Text + "','" + txtLop.Text + "', N'" + cbGioitinh.Text + "','" + txtDiem1.Text + "','" + txtDiem2.Text + "','" + txtDiem3.Text + "')";
                command.ExecuteNonQuery();
                txtDiem1.Text = " ";
                loaddata();
                MessageBox.Show("Thêm thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM Diem WHERE MSSV ='" + txtMSSV.Text + "' ";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!InputValidation())
                return;

            string query = "UPDATE Diem SET TenSV = @TenSV, Lop = @Lop, GioiTinh = @GioiTinh, Mon1 = @Mon1, Mon2 = @Mon2, Mon3 = @Mon3 WHERE MSSV = @MSSV";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MSSV", txtMSSV.Text);
            command.Parameters.AddWithValue("@TenSV", txtTenSV.Text);
            command.Parameters.AddWithValue("@Lop", txtLop.Text);
            command.Parameters.AddWithValue("@GioiTinh", cbGioitinh.Text);
            command.Parameters.AddWithValue("@Mon1", txtDiem1.Text);
            command.Parameters.AddWithValue("@Mon2", txtDiem2.Text);
            command.Parameters.AddWithValue("@Mon3", txtDiem3.Text);
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Sửa thông tin sinh viên thành công!");

        }
        private void frQuantri_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void btnDangxuat2_Click(object sender, EventArgs e)
        {
            frDangnhap loginForm = new frDangnhap();
            this.Hide();
            loginForm.Show();

        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
            txtMSSV.Text = "";
            txtTenSV.Text = "";
            txtLop.Text = "";
            txtDiem1.Text = "";
            txtDiem2.Text = "";
            txtDiem3.Text = "";
            txttimMSSV.Text = "";
            cbLop.Text = "";
            cbTimkiem.Checked = false;
        }
        private void btntt_Click(object sender, EventArgs e)
        {
            frThongtintaikhoan f = new frThongtintaikhoan();
            f.Show();
        }

        private void btnttgv_Click(object sender, EventArgs e)
        {
            frtaikhoanGV f = new frtaikhoanGV();
            f.Show();
        }

        private void cbTimkiem_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTimkiem.Checked == true)
            {
                cbTimtheolop.Visible = true;
                cbLop.Visible = true;
                cbTimtheoMSSV.Visible = true;
                txttimMSSV.Visible = true;
                btntim.Visible = true;

            }
            else
            {
                cbTimtheolop.Checked = false;
                cbTimtheolop.Visible = false;
                cbLop.Visible = false;
                cbTimtheoMSSV.Checked = false;
                cbTimtheoMSSV.Visible = false;
                txttimMSSV.Visible = false;
                btntim.Visible = false;
                dgvQuantri.DataSource = table;
            }
        }
        private void Taidanhsachlop()
        {

            string query = "SELECT DISTINCT Lop FROM Diem";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            cbLop.Items.Clear();
            while (reader.Read())
            {
                cbLop.Items.Add(reader["Lop"].ToString());
            }
            reader.Close();
        }
        private void cbTimtheolop_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTimtheolop.Checked)
            {
                cbTimtheoMSSV.Checked = false;
                Taidanhsachlop();
                command = connection.CreateCommand();
                string query = " Diem SET Lop = @Lop";
                command.Parameters.AddWithValue("@Lop", cbLop);
            }

            else
            {

                dgvQuantri.DataSource = table;
            }


        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTimtheolop.Checked)
            {
                command = connection.CreateCommand();

                command.CommandText = " SELECT * FROM Diem WHERE Lop = '" + cbLop.Text + "' ";
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);

                dgvQuantri.DataSource = table;
            }
        }

        private void cbTimtheoMSSV_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTimtheoMSSV.Checked)
            {
                cbTimtheolop.Checked = false;
            }
            else
            {
                dgvQuantri.DataSource = table;

            }

        }

        private void btntim_Click(object sender, EventArgs e)
        {

            if (cbTimtheoMSSV.Checked)
            {
                if (!string.IsNullOrEmpty(txttimMSSV.Text))
                {
                    var searchResult = sortedData.Where(row => row["MSSV"].ToString().Contains(txttimMSSV.Text)).ToList();
                    if (searchResult.Count > 0)
                    {
                        DataTable searchTable = searchResult.CopyToDataTable();
                        dgvQuantri.DataSource = searchTable;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên với MSSV này.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập MSSV để tìm kiếm.");
                }
            }
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


            if (data.Count > 0)
            {
                table = data.CopyToDataTable();
            }
            else
            {
                // Xử lý khi không có dữ liệu
                // Nếu bạn muốn giữ cấu trúc bảng nhưng không có dữ liệu, hãy dùng Clone() từ bảng gốc (nếu có biến bảng gốc)
                // table = originalDataTable.Clone(); 

                // Hoặc gán bằng null
                table = null;
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
            dgvQuantri.DataSource = table;
        }

        private void frQuantri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
