namespace TH_OSS
{
    partial class frThongtintaikhoan
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
            this.btnThoattk = new System.Windows.Forms.Button();
            this.dgvtaikhoansinhvien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnThemtk = new System.Windows.Forms.Button();
            this.btnXoatk = new System.Windows.Forms.Button();
            this.btnSuatk = new System.Windows.Forms.Button();
            this.btnKhoitao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntim = new System.Windows.Forms.Button();
            this.txttimMSSV = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoansinhvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoattk
            // 
            this.btnThoattk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThoattk.Location = new System.Drawing.Point(402, 468);
            this.btnThoattk.Name = "btnThoattk";
            this.btnThoattk.Size = new System.Drawing.Size(77, 36);
            this.btnThoattk.TabIndex = 1;
            this.btnThoattk.Text = "Thoát";
            this.btnThoattk.UseVisualStyleBackColor = false;
            this.btnThoattk.Click += new System.EventHandler(this.btnThoattk_Click);
            // 
            // dgvtaikhoansinhvien
            // 
            this.dgvtaikhoansinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtaikhoansinhvien.Location = new System.Drawing.Point(15, 21);
            this.dgvtaikhoansinhvien.Name = "dgvtaikhoansinhvien";
            this.dgvtaikhoansinhvien.RowTemplate.Height = 24;
            this.dgvtaikhoansinhvien.Size = new System.Drawing.Size(452, 246);
            this.dgvtaikhoansinhvien.TabIndex = 2;
            this.dgvtaikhoansinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtaikhoansinhvien_CellContentClick);
            this.dgvtaikhoansinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtaikhoansinhvien_CellContentClick);
            this.dgvtaikhoansinhvien.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtaikhoansinhvien_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvtaikhoansinhvien);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 259);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(145, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÀI KHOẢN SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "StudentID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(97, 26);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(117, 22);
            this.txtstudentid.TabIndex = 8;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(97, 67);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(117, 22);
            this.txtusername.TabIndex = 9;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(97, 108);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(117, 22);
            this.txtpassword.TabIndex = 10;
            // 
            // btnThemtk
            // 
            this.btnThemtk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnThemtk.Location = new System.Drawing.Point(287, 356);
            this.btnThemtk.Name = "btnThemtk";
            this.btnThemtk.Size = new System.Drawing.Size(75, 31);
            this.btnThemtk.TabIndex = 11;
            this.btnThemtk.Text = "Thêm";
            this.btnThemtk.UseVisualStyleBackColor = false;
            this.btnThemtk.Click += new System.EventHandler(this.btnThemtk_Click);
            // 
            // btnXoatk
            // 
            this.btnXoatk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXoatk.Location = new System.Drawing.Point(287, 393);
            this.btnXoatk.Name = "btnXoatk";
            this.btnXoatk.Size = new System.Drawing.Size(75, 31);
            this.btnXoatk.TabIndex = 12;
            this.btnXoatk.Text = "Xóa";
            this.btnXoatk.UseVisualStyleBackColor = false;
            this.btnXoatk.Click += new System.EventHandler(this.btnXoatk_Click);
            // 
            // btnSuatk
            // 
            this.btnSuatk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSuatk.Location = new System.Drawing.Point(287, 430);
            this.btnSuatk.Name = "btnSuatk";
            this.btnSuatk.Size = new System.Drawing.Size(75, 31);
            this.btnSuatk.TabIndex = 13;
            this.btnSuatk.Text = "Sửa";
            this.btnSuatk.UseVisualStyleBackColor = false;
            this.btnSuatk.Click += new System.EventHandler(this.btnSuatk_Click);
            // 
            // btnKhoitao
            // 
            this.btnKhoitao.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKhoitao.Location = new System.Drawing.Point(287, 467);
            this.btnKhoitao.Name = "btnKhoitao";
            this.btnKhoitao.Size = new System.Drawing.Size(75, 31);
            this.btnKhoitao.TabIndex = 14;
            this.btnKhoitao.Text = "Khởi tạo";
            this.btnKhoitao.UseVisualStyleBackColor = false;
            this.btnKhoitao.Click += new System.EventHandler(this.btnKhoitao_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtstudentid);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtusername);
            this.groupBox2.Controls.Add(this.txtpassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 148);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(107, 16);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(58, 26);
            this.btntim.TabIndex = 16;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txttimMSSV
            // 
            this.txttimMSSV.Location = new System.Drawing.Point(6, 18);
            this.txttimMSSV.Name = "txttimMSSV";
            this.txttimMSSV.Size = new System.Drawing.Size(95, 22);
            this.txttimMSSV.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttimMSSV);
            this.groupBox3.Controls.Add(this.btntim);
            this.groupBox3.Location = new System.Drawing.Point(331, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 46);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập MSSV";
            // 
            // frThongtintaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 513);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnKhoitao);
            this.Controls.Add(this.btnSuatk);
            this.Controls.Add(this.btnXoatk);
            this.Controls.Add(this.btnThemtk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoattk);
            this.Name = "frThongtintaikhoan";
            this.Text = "frThongtintaikhoan";
            this.Load += new System.EventHandler(this.frThongtintaikhoan_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtaikhoansinhvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoattk;
        private System.Windows.Forms.DataGridView dgvtaikhoansinhvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnThemtk;
        private System.Windows.Forms.Button btnXoatk;
        private System.Windows.Forms.Button btnSuatk;
        private System.Windows.Forms.Button btnKhoitao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txttimMSSV;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}