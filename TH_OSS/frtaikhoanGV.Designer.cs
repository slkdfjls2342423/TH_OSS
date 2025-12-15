namespace TH_OSS
{
    partial class frtaikhoanGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvtkgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnKhoitao = new System.Windows.Forms.Button();
            this.Lecturers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlecturerid = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(308, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thoát\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvtkgv);
            this.groupBox1.Location = new System.Drawing.Point(9, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(368, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgvtkgv
            // 
            this.dgvtkgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtkgv.Location = new System.Drawing.Point(12, 17);
            this.dgvtkgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvtkgv.Name = "dgvtkgv";
            this.dgvtkgv.RowTemplate.Height = 24;
            this.dgvtkgv.Size = new System.Drawing.Size(344, 192);
            this.dgvtkgv.TabIndex = 0;
            this.dgvtkgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtkgv_CellContentClick);
            this.dgvtkgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtkgv_CellContentClick);
            this.dgvtkgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtkgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(106, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÀI KHOẢN GIẢNG VIÊN";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThem.Location = new System.Drawing.Point(233, 271);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 28);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoa.Location = new System.Drawing.Point(233, 303);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 28);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSua.Location = new System.Drawing.Point(233, 336);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(56, 28);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnKhoitao
            // 
            this.btnKhoitao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKhoitao.Location = new System.Drawing.Point(233, 368);
            this.btnKhoitao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKhoitao.Name = "btnKhoitao";
            this.btnKhoitao.Size = new System.Drawing.Size(56, 28);
            this.btnKhoitao.TabIndex = 6;
            this.btnKhoitao.Text = "Khởi tạo";
            this.btnKhoitao.UseVisualStyleBackColor = false;
            this.btnKhoitao.Click += new System.EventHandler(this.btnKhoitao_Click);
            // 
            // Lecturers
            // 
            this.Lecturers.AutoSize = true;
            this.Lecturers.Location = new System.Drawing.Point(6, 25);
            this.Lecturers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lecturers.Name = "Lecturers";
            this.Lecturers.Size = new System.Drawing.Size(57, 13);
            this.Lecturers.TabIndex = 8;
            this.Lecturers.Text = "LecturerID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // txtlecturerid
            // 
            this.txtlecturerid.Location = new System.Drawing.Point(77, 25);
            this.txtlecturerid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtlecturerid.Name = "txtlecturerid";
            this.txtlecturerid.ReadOnly = true;
            this.txtlecturerid.Size = new System.Drawing.Size(103, 20);
            this.txtlecturerid.TabIndex = 11;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(77, 54);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(103, 20);
            this.txtusername.TabIndex = 12;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(77, 84);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(103, 20);
            this.txtpassword.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtpassword);
            this.groupBox2.Controls.Add(this.Lecturers);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtusername);
            this.groupBox2.Controls.Add(this.txtlecturerid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(9, 271);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(203, 124);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // frtaikhoanGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKhoitao);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frtaikhoanGV";
            this.Text = "frtaikhoanGV";
            this.Load += new System.EventHandler(this.frtaikhoanGV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvtkgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label Lecturers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtlecturerid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKhoitao;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}