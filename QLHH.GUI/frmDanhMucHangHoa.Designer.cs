namespace QLHH.GUI
{
    partial class frmDanhMucHangHoa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.cboMaChatLieu = new System.Windows.Forms.ComboBox();
            this.btnThem_Click = new System.Windows.Forms.Button();
            this.btnXoa_Click = new System.Windows.Forms.Button();
            this.btnSua_Click = new System.Windows.Forms.Button();
            this.btnLuu_Click = new System.Windows.Forms.Button();
            this.btnTimKiem_Click = new System.Windows.Forms.Button();
            this.btnThoat_Click = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.group = new System.Windows.Forms.GroupBox();
            this.btnMo = new System.Windows.Forms.Button();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.GhiChu_richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BoQua_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(509, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Hàng Hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã chất liệu:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-3, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-3, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-3, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn giá bán:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(387, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ghi chú:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(795, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ảnh:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(125, 58);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(229, 22);
            this.txtMaHang.TabIndex = 9;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(125, 90);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(229, 22);
            this.txtTenHang.TabIndex = 10;
            this.txtTenHang.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(125, 159);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(229, 22);
            this.txtSoLuong.TabIndex = 12;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(125, 196);
            this.txtDonGiaNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(229, 22);
            this.txtDonGiaNhap.TabIndex = 13;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(125, 231);
            this.txtDonGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(229, 22);
            this.txtDonGiaBan.TabIndex = 14;
            // 
            // cboMaChatLieu
            // 
            this.cboMaChatLieu.FormattingEnabled = true;
            this.cboMaChatLieu.Location = new System.Drawing.Point(125, 122);
            this.cboMaChatLieu.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaChatLieu.Name = "cboMaChatLieu";
            this.cboMaChatLieu.Size = new System.Drawing.Size(229, 24);
            this.cboMaChatLieu.TabIndex = 15;
            this.cboMaChatLieu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnThem_Click
            // 
            this.btnThem_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_Click.Location = new System.Drawing.Point(16, 545);
            this.btnThem_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem_Click.Name = "btnThem_Click";
            this.btnThem_Click.Size = new System.Drawing.Size(123, 42);
            this.btnThem_Click.TabIndex = 16;
            this.btnThem_Click.Text = "Thêm";
            this.btnThem_Click.UseVisualStyleBackColor = true;
            this.btnThem_Click.Click += new System.EventHandler(this.btnThem_Click_Click);
            // 
            // btnXoa_Click
            // 
            this.btnXoa_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_Click.Location = new System.Drawing.Point(147, 545);
            this.btnXoa_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa_Click.Name = "btnXoa_Click";
            this.btnXoa_Click.Size = new System.Drawing.Size(123, 42);
            this.btnXoa_Click.TabIndex = 17;
            this.btnXoa_Click.Text = "Xóa";
            this.btnXoa_Click.UseVisualStyleBackColor = true;
            this.btnXoa_Click.Click += new System.EventHandler(this.btnXoa_Click_Click);
            // 
            // btnSua_Click
            // 
            this.btnSua_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_Click.Location = new System.Drawing.Point(277, 545);
            this.btnSua_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua_Click.Name = "btnSua_Click";
            this.btnSua_Click.Size = new System.Drawing.Size(123, 42);
            this.btnSua_Click.TabIndex = 18;
            this.btnSua_Click.Text = "Sửa";
            this.btnSua_Click.UseVisualStyleBackColor = true;
            this.btnSua_Click.Click += new System.EventHandler(this.btnSua_Click_Click);
            // 
            // btnLuu_Click
            // 
            this.btnLuu_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_Click.Location = new System.Drawing.Point(408, 545);
            this.btnLuu_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu_Click.Name = "btnLuu_Click";
            this.btnLuu_Click.Size = new System.Drawing.Size(123, 42);
            this.btnLuu_Click.TabIndex = 19;
            this.btnLuu_Click.Text = "Lưu";
            this.btnLuu_Click.UseVisualStyleBackColor = true;
            this.btnLuu_Click.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTimKiem_Click
            // 
            this.btnTimKiem_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_Click.Location = new System.Drawing.Point(397, 133);
            this.btnTimKiem_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem_Click.Name = "btnTimKiem_Click";
            this.btnTimKiem_Click.Size = new System.Drawing.Size(140, 55);
            this.btnTimKiem_Click.TabIndex = 21;
            this.btnTimKiem_Click.Text = "Tìm kiếm (Mã)";
            this.btnTimKiem_Click.UseVisualStyleBackColor = true;
            this.btnTimKiem_Click.Click += new System.EventHandler(this.btnTimKiem_Click_Click);
            // 
            // btnThoat_Click
            // 
            this.btnThoat_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_Click.Location = new System.Drawing.Point(1081, 546);
            this.btnThoat_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat_Click.Name = "btnThoat_Click";
            this.btnThoat_Click.Size = new System.Drawing.Size(123, 42);
            this.btnThoat_Click.TabIndex = 22;
            this.btnThoat_Click.Text = "Thoát";
            this.btnThoat_Click.UseVisualStyleBackColor = true;
            this.btnThoat_Click.Click += new System.EventHandler(this.button6_Click);
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(864, 23);
            this.picAnh.Margin = new System.Windows.Forms.Padding(4);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(337, 212);
            this.picAnh.TabIndex = 23;
            this.picAnh.TabStop = false;
            this.picAnh.Click += new System.EventHandler(this.picAnh_Click);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(13, 23);
            this.dgvHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.Size = new System.Drawing.Size(843, 236);
            this.dgvHangHoa.TabIndex = 25;
            this.dgvHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellContentClick);
            // 
            // group
            // 
            this.group.Controls.Add(this.dgvHangHoa);
            this.group.Controls.Add(this.picAnh);
            this.group.Location = new System.Drawing.Point(3, 271);
            this.group.Margin = new System.Windows.Forms.Padding(4);
            this.group.Name = "group";
            this.group.Padding = new System.Windows.Forms.Padding(4);
            this.group.Size = new System.Drawing.Size(1239, 267);
            this.group.TabIndex = 26;
            this.group.TabStop = false;
            this.group.Text = "Sản Phẩm";
            // 
            // btnMo
            // 
            this.btnMo.Location = new System.Drawing.Point(800, 87);
            this.btnMo.Margin = new System.Windows.Forms.Padding(4);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(83, 28);
            this.btnMo.TabIndex = 28;
            this.btnMo.Text = "->";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAnh
            // 
            this.txtAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnh.Location = new System.Drawing.Point(800, 122);
            this.txtAnh.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(358, 89);
            this.txtAnh.TabIndex = 27;
            this.txtAnh.Text = "Path:";
            this.txtAnh.TextChanged += new System.EventHandler(this.txtAnh_TextChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(548, 139);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(164, 42);
            this.txtTimKiem.TabIndex = 29;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GhiChu_richTextBox1
            // 
            this.GhiChu_richTextBox1.Location = new System.Drawing.Point(466, 63);
            this.GhiChu_richTextBox1.Name = "GhiChu_richTextBox1";
            this.GhiChu_richTextBox1.Size = new System.Drawing.Size(196, 49);
            this.GhiChu_richTextBox1.TabIndex = 30;
            this.GhiChu_richTextBox1.Text = "";
            this.GhiChu_richTextBox1.TextChanged += new System.EventHandler(this.GhiChu_richTextBox1_TextChanged);
            // 
            // BoQua_Button
            // 
            this.BoQua_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoQua_Button.Location = new System.Drawing.Point(548, 545);
            this.BoQua_Button.Name = "BoQua_Button";
            this.BoQua_Button.Size = new System.Drawing.Size(114, 42);
            this.BoQua_Button.TabIndex = 31;
            this.BoQua_Button.Text = "Bỏ Qua\r\n";
            this.BoQua_Button.UseVisualStyleBackColor = true;
            this.BoQua_Button.Click += new System.EventHandler(this.BoQua_Button_Click);
            // 
            // frmDanhMucHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 599);
            this.Controls.Add(this.BoQua_Button);
            this.Controls.Add(this.GhiChu_richTextBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnMo);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.group);
            this.Controls.Add(this.btnThoat_Click);
            this.Controls.Add(this.btnTimKiem_Click);
            this.Controls.Add(this.btnLuu_Click);
            this.Controls.Add(this.btnSua_Click);
            this.Controls.Add(this.btnXoa_Click);
            this.Controls.Add(this.btnThem_Click);
            this.Controls.Add(this.cboMaChatLieu);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDanhMucHangHoa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.group.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.ComboBox cboMaChatLieu;
        private System.Windows.Forms.Button btnThem_Click;
        private System.Windows.Forms.Button btnXoa_Click;
        private System.Windows.Forms.Button btnSua_Click;
        private System.Windows.Forms.Button btnLuu_Click;
        private System.Windows.Forms.Button btnTimKiem_Click;
        private System.Windows.Forms.Button btnThoat_Click;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RichTextBox GhiChu_richTextBox1;
        private System.Windows.Forms.Button BoQua_Button;
    }
}

