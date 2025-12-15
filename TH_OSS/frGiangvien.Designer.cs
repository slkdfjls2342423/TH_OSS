namespace TH_OSS
{
    partial class frGiangvien
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
            this.dgvGiangvien = new System.Windows.Forms.DataGridView();
            this.GrbDSSV = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNDangXuat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimlop = new System.Windows.Forms.TextBox();
            this.btnTimlop = new System.Windows.Forms.Button();
            this.cbTimLop = new System.Windows.Forms.CheckBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MSSV = new System.Windows.Forms.Label();
            this.txtmon3 = new System.Windows.Forms.TextBox();
            this.txtmon2 = new System.Windows.Forms.TextBox();
            this.txtmon1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKhoitao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbtieuchisx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangvien)).BeginInit();
            this.GrbDSSV.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGiangvien
            // 
            this.dgvGiangvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangvien.Location = new System.Drawing.Point(14, 17);
            this.dgvGiangvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGiangvien.Name = "dgvGiangvien";
            this.dgvGiangvien.RowTemplate.Height = 24;
            this.dgvGiangvien.Size = new System.Drawing.Size(744, 228);
            this.dgvGiangvien.TabIndex = 0;
            this.dgvGiangvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangvien_CellContentClick);
            this.dgvGiangvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangvien_CellContentClick);
            this.dgvGiangvien.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiangvien_CellContentClick);
            // 
            // GrbDSSV
            // 
            this.GrbDSSV.Controls.Add(this.dgvGiangvien);
            this.GrbDSSV.Location = new System.Drawing.Point(9, 55);
            this.GrbDSSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrbDSSV.Name = "GrbDSSV";
            this.GrbDSSV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrbDSSV.Size = new System.Drawing.Size(767, 258);
            this.GrbDSSV.TabIndex = 1;
            this.GrbDSSV.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(772, 41);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(285, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // BTNDangXuat
            // 
            this.BTNDangXuat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BTNDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDangXuat.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BTNDangXuat.Location = new System.Drawing.Point(685, 440);
            this.BTNDangXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNDangXuat.Name = "BTNDangXuat";
            this.BTNDangXuat.Size = new System.Drawing.Size(82, 30);
            this.BTNDangXuat.TabIndex = 0;
            this.BTNDangXuat.Text = "Đăng xuất";
            this.BTNDangXuat.UseVisualStyleBackColor = false;
            this.BTNDangXuat.Click += new System.EventHandler(this.BTNDangXuat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSua.Location = new System.Drawing.Point(685, 368);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 29);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimlop);
            this.groupBox3.Controls.Add(this.btnTimlop);
            this.groupBox3.Controls.Add(this.cbTimLop);
            this.groupBox3.Controls.Add(this.txtLop);
            this.groupBox3.Controls.Add(this.txtTenSV);
            this.groupBox3.Controls.Add(this.txtMSSV);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.MSSV);
            this.groupBox3.Controls.Add(this.txtmon3);
            this.groupBox3.Controls.Add(this.txtmon2);
            this.groupBox3.Controls.Add(this.txtmon1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 318);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(479, 152);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // txtTimlop
            // 
            this.txtTimlop.Location = new System.Drawing.Point(106, 27);
            this.txtTimlop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimlop.Name = "txtTimlop";
            this.txtTimlop.Size = new System.Drawing.Size(86, 21);
            this.txtTimlop.TabIndex = 14;
            // 
            // btnTimlop
            // 
            this.btnTimlop.Location = new System.Drawing.Point(210, 23);
            this.btnTimlop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimlop.Name = "btnTimlop";
            this.btnTimlop.Size = new System.Drawing.Size(56, 28);
            this.btnTimlop.TabIndex = 13;
            this.btnTimlop.Text = "Tìm";
            this.btnTimlop.UseVisualStyleBackColor = true;
            this.btnTimlop.Click += new System.EventHandler(this.btnTimlop_Click);
            // 
            // cbTimLop
            // 
            this.cbTimLop.AutoSize = true;
            this.cbTimLop.Location = new System.Drawing.Point(14, 28);
            this.cbTimLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTimLop.Name = "cbTimLop";
            this.cbTimLop.Size = new System.Drawing.Size(94, 19);
            this.cbTimLop.TabIndex = 12;
            this.cbTimLop.Text = "Tìm theo lớp";
            this.cbTimLop.UseVisualStyleBackColor = true;
            this.cbTimLop.CheckedChanged += new System.EventHandler(this.cbTimLop_CheckedChanged);
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(106, 122);
            this.txtLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(162, 21);
            this.txtLop.TabIndex = 11;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(106, 92);
            this.txtTenSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(162, 21);
            this.txtTenSV.TabIndex = 10;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(106, 59);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(162, 21);
            this.txtMSSV.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tên sinh viên";
            // 
            // MSSV
            // 
            this.MSSV.AutoSize = true;
            this.MSSV.Location = new System.Drawing.Point(12, 62);
            this.MSSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MSSV.Name = "MSSV";
            this.MSSV.Size = new System.Drawing.Size(41, 15);
            this.MSSV.TabIndex = 6;
            this.MSSV.Text = "MSSV";
            // 
            // txtmon3
            // 
            this.txtmon3.Location = new System.Drawing.Point(382, 120);
            this.txtmon3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmon3.Name = "txtmon3";
            this.txtmon3.Size = new System.Drawing.Size(77, 21);
            this.txtmon3.TabIndex = 5;
            // 
            // txtmon2
            // 
            this.txtmon2.Location = new System.Drawing.Point(382, 92);
            this.txtmon2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmon2.Name = "txtmon2";
            this.txtmon2.Size = new System.Drawing.Size(77, 21);
            this.txtmon2.TabIndex = 4;
            // 
            // txtmon1
            // 
            this.txtmon1.Location = new System.Drawing.Point(382, 59);
            this.txtmon1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmon1.Name = "txtmon1";
            this.txtmon1.Size = new System.Drawing.Size(77, 21);
            this.txtmon1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điểm môn 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điểm môn 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Điểm môn 1";
            // 
            // btnKhoitao
            // 
            this.btnKhoitao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoitao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnKhoitao.Location = new System.Drawing.Point(685, 405);
            this.btnKhoitao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKhoitao.Name = "btnKhoitao";
            this.btnKhoitao.Size = new System.Drawing.Size(82, 29);
            this.btnKhoitao.TabIndex = 7;
            this.btnKhoitao.Text = "Khởi tạo";
            this.btnKhoitao.UseVisualStyleBackColor = true;
            this.btnKhoitao.Click += new System.EventHandler(this.btnKhoitao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 338);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sắp xếp theo";
            // 
            // cbtieuchisx
            // 
            this.cbtieuchisx.FormattingEnabled = true;
            this.cbtieuchisx.Items.AddRange(new object[] {
            "Tên Sinh Viên",
            "MSSV",
            "Lớp",
            "Điểm TB"});
            this.cbtieuchisx.Location = new System.Drawing.Point(576, 337);
            this.cbtieuchisx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbtieuchisx.Name = "cbtieuchisx";
            this.cbtieuchisx.Size = new System.Drawing.Size(83, 21);
            this.cbtieuchisx.TabIndex = 9;
            this.cbtieuchisx.SelectedIndexChanged += new System.EventHandler(this.cbtieuchisx_SelectedIndexChanged);
            // 
            // frGiangvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 480);
            this.Controls.Add(this.cbtieuchisx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKhoitao);
            this.Controls.Add(this.BTNDangXuat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrbDSSV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frGiangvien";
            this.Text = "Danh Sách Sinh Viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frGiangvien_FormClosed);
            this.Load += new System.EventHandler(this.frGiangvien_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangvien)).EndInit();
            this.GrbDSSV.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGiangvien;
        private System.Windows.Forms.GroupBox GrbDSSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNDangXuat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtmon3;
        private System.Windows.Forms.TextBox txtmon2;
        private System.Windows.Forms.TextBox txtmon1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MSSV;
        private System.Windows.Forms.Button btnKhoitao;
        private System.Windows.Forms.TextBox txtTimlop;
        private System.Windows.Forms.Button btnTimlop;
        private System.Windows.Forms.CheckBox cbTimLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbtieuchisx;
    }
}