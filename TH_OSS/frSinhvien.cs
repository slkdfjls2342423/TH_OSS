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
    public partial class frSinhvien : Form
    {
        SqlConnection connection;
        SqlCommand command;

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private long studentId;

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from Diem WHERE MSSV = @StudentID ";
            command.Parameters.AddWithValue("@StudentID", studentId);
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            dgvSinhvien.DataSource = table;
        }

        public frSinhvien(long studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
        }

        private void frSinhvien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(Program.conStr);
            connection.Open();
            loaddata();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            frDangnhap loginForm = new frDangnhap();
            this.Hide();
            loginForm.Show();
        }
        private void frSinhvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}