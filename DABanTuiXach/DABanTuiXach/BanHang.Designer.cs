namespace DABanTuiXach
{
	partial class BanHang
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
			panel1 = new Panel();
			label2 = new Label();
			label1 = new Label();
			groupBox2 = new GroupBox();
			btnHuy = new Button();
			btnThanhToan = new Button();
			lblTienThua = new Label();
			label9 = new Label();
			txtTienKhachDua = new TextBox();
			label8 = new Label();
			lblTongTien = new Label();
			label6 = new Label();
			dtgvHoaDon = new DataGridView();
			cbbChonHoaDon = new ComboBox();
			label5 = new Label();
			groupBox3 = new GroupBox();
			dtgvSanPhamChiTiet = new DataGridView();
			txtTimSanPham = new TextBox();
			label11 = new Label();
			label3 = new Label();
			label4 = new Label();
			txtSoDienThoai = new TextBox();
			txtTenKH = new TextBox();
			btnTaoHoaDon = new Button();
			txtTimKH = new TextBox();
			btnTimKH = new Button();
			groupBox1 = new GroupBox();
			panel1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtgvHoaDon).BeginInit();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dtgvSanPhamChiTiet).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			panel1.Location = new Point(12, 15);
			panel1.Name = "panel1";
			panel1.Size = new Size(2169, 103);
			panel1.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(5, 65);
			label2.Name = "label2";
			label2.Size = new Size(161, 32);
			label2.TabIndex = 1;
			label2.Text = "Nhân Viên 1";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(5, -2);
			label1.Name = "label1";
			label1.Size = new Size(113, 32);
			label1.TabIndex = 0;
			label1.Text = "Chức vụ";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnHuy);
			groupBox2.Controls.Add(btnThanhToan);
			groupBox2.Controls.Add(lblTienThua);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(txtTienKhachDua);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(lblTongTien);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(dtgvHoaDon);
			groupBox2.Controls.Add(cbbChonHoaDon);
			groupBox2.Controls.Add(label5);
			groupBox2.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox2.Location = new Point(616, 175);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(836, 1185);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "Thông tin hóa đơn";
			// 
			// btnHuy
			// 
			btnHuy.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnHuy.Location = new Point(591, 1091);
			btnHuy.Name = "btnHuy";
			btnHuy.Size = new Size(141, 57);
			btnHuy.TabIndex = 10;
			btnHuy.Text = "Hủy";
			btnHuy.UseVisualStyleBackColor = true;
			btnHuy.Click += btnHuy_Click_1;
			// 
			// btnThanhToan
			// 
			btnThanhToan.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnThanhToan.Location = new Point(591, 975);
			btnThanhToan.Name = "btnThanhToan";
			btnThanhToan.Size = new Size(141, 85);
			btnThanhToan.TabIndex = 9;
			btnThanhToan.Text = "Thanh toán";
			btnThanhToan.UseVisualStyleBackColor = true;
			btnThanhToan.Click += btnThanhToan_Click_1;
			// 
			// lblTienThua
			// 
			lblTienThua.AutoSize = true;
			lblTienThua.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTienThua.Location = new Point(280, 1103);
			lblTienThua.Name = "lblTienThua";
			lblTienThua.Size = new Size(100, 23);
			lblTienThua.TabIndex = 8;
			lblTienThua.Text = "Tiền thừa";
			lblTienThua.TextChanged += lblTienThua_TextChanged;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label9.Location = new Point(33, 1095);
			label9.Name = "label9";
			label9.Size = new Size(142, 32);
			label9.TabIndex = 7;
			label9.Text = "Tiền thừa:";
			// 
			// txtTienKhachDua
			// 
			txtTienKhachDua.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtTienKhachDua.Location = new Point(280, 1020);
			txtTienKhachDua.Name = "txtTienKhachDua";
			txtTienKhachDua.Size = new Size(280, 31);
			txtTienKhachDua.TabIndex = 6;
			txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged_1;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.Location = new Point(31, 1017);
			label8.Name = "label8";
			label8.Size = new Size(213, 32);
			label8.TabIndex = 5;
			label8.Text = "Tiền khách đưa:";
			// 
			// lblTongTien
			// 
			lblTongTien.AutoSize = true;
			lblTongTien.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTongTien.Location = new Point(285, 957);
			lblTongTien.Name = "lblTongTien";
			lblTongTien.Size = new Size(95, 23);
			lblTongTien.TabIndex = 4;
			lblTongTien.Text = "Tổng tiền";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(33, 951);
			label6.Name = "label6";
			label6.Size = new Size(190, 32);
			label6.TabIndex = 3;
			label6.Text = "Tổng hóa đơn:";
			// 
			// dtgvHoaDon
			// 
			dtgvHoaDon.AllowUserToAddRows = false;
			dtgvHoaDon.AllowUserToDeleteRows = false;
			dtgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtgvHoaDon.Location = new Point(0, 169);
			dtgvHoaDon.Name = "dtgvHoaDon";
			dtgvHoaDon.ReadOnly = true;
			dtgvHoaDon.RowHeadersWidth = 51;
			dtgvHoaDon.RowTemplate.Height = 24;
			dtgvHoaDon.Size = new Size(836, 702);
			dtgvHoaDon.TabIndex = 2;
			// 
			// cbbChonHoaDon
			// 
			cbbChonHoaDon.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cbbChonHoaDon.FormattingEnabled = true;
			cbbChonHoaDon.Location = new Point(277, 71);
			cbbChonHoaDon.Name = "cbbChonHoaDon";
			cbbChonHoaDon.Size = new Size(521, 39);
			cbbChonHoaDon.TabIndex = 1;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(60, 71);
			label5.Name = "label5";
			label5.Size = new Size(183, 32);
			label5.TabIndex = 0;
			label5.Text = "Chọn hóa đơn";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(dtgvSanPhamChiTiet);
			groupBox3.Controls.Add(txtTimSanPham);
			groupBox3.Controls.Add(label11);
			groupBox3.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox3.Location = new Point(1457, 175);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(724, 1185);
			groupBox3.TabIndex = 0;
			groupBox3.TabStop = false;
			groupBox3.Text = "Danh sách sản phẩm";
			// 
			// dtgvSanPhamChiTiet
			// 
			dtgvSanPhamChiTiet.AllowUserToAddRows = false;
			dtgvSanPhamChiTiet.AllowUserToDeleteRows = false;
			dtgvSanPhamChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtgvSanPhamChiTiet.Location = new Point(0, 169);
			dtgvSanPhamChiTiet.Name = "dtgvSanPhamChiTiet";
			dtgvSanPhamChiTiet.ReadOnly = true;
			dtgvSanPhamChiTiet.RowHeadersWidth = 51;
			dtgvSanPhamChiTiet.RowTemplate.Height = 24;
			dtgvSanPhamChiTiet.Size = new Size(724, 935);
			dtgvSanPhamChiTiet.TabIndex = 2;
			dtgvSanPhamChiTiet.CellContentClick += dtgvSanPhamChiTiet_CellContentClick;
			// 
			// txtTimSanPham
			// 
			txtTimSanPham.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtTimSanPham.Location = new Point(212, 71);
			txtTimSanPham.Multiline = true;
			txtTimSanPham.Name = "txtTimSanPham";
			txtTimSanPham.Size = new Size(461, 61);
			txtTimSanPham.TabIndex = 1;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label11.Location = new Point(36, 92);
			label11.Name = "label11";
			label11.Size = new Size(132, 32);
			label11.TabIndex = 0;
			label11.Text = "Tìm kiếm";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(25, 217);
			label3.Name = "label3";
			label3.Size = new Size(172, 32);
			label3.TabIndex = 0;
			label3.Text = "Số điện thoại";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(25, 429);
			label4.Name = "label4";
			label4.Size = new Size(207, 32);
			label4.TabIndex = 1;
			label4.Text = "Tên khách hàng";
			// 
			// txtSoDienThoai
			// 
			txtSoDienThoai.Location = new Point(48, 294);
			txtSoDienThoai.Multiline = true;
			txtSoDienThoai.Name = "txtSoDienThoai";
			txtSoDienThoai.Size = new Size(491, 47);
			txtSoDienThoai.TabIndex = 2;
			txtSoDienThoai.TextChanged += txtSoDienThoai_TextChanged;
			// 
			// txtTenKH
			// 
			txtTenKH.Location = new Point(48, 557);
			txtTenKH.Multiline = true;
			txtTenKH.Name = "txtTenKH";
			txtTenKH.Size = new Size(471, 49);
			txtTenKH.TabIndex = 3;
			// 
			// btnTaoHoaDon
			// 
			btnTaoHoaDon.Location = new Point(181, 749);
			btnTaoHoaDon.Name = "btnTaoHoaDon";
			btnTaoHoaDon.Size = new Size(207, 109);
			btnTaoHoaDon.TabIndex = 4;
			btnTaoHoaDon.Text = "Tạo hóa đơn";
			btnTaoHoaDon.UseVisualStyleBackColor = true;
			btnTaoHoaDon.Click += btnTaoHoaDon_Click;
			// 
			// txtTimKH
			// 
			txtTimKH.Location = new Point(13, 92);
			txtTimKH.Multiline = true;
			txtTimKH.Name = "txtTimKH";
			txtTimKH.Size = new Size(309, 69);
			txtTimKH.TabIndex = 5;
			// 
			// btnTimKH
			// 
			btnTimKH.Location = new Point(344, 94);
			btnTimKH.Name = "btnTimKH";
			btnTimKH.Size = new Size(220, 69);
			btnTimKH.TabIndex = 6;
			btnTimKH.Text = "Tìm kiếm";
			btnTimKH.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(btnTimKH);
			groupBox1.Controls.Add(txtTimKH);
			groupBox1.Controls.Add(btnTaoHoaDon);
			groupBox1.Controls.Add(txtTenKH);
			groupBox1.Controls.Add(txtSoDienThoai);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.Location = new Point(12, 175);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(599, 1185);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông tin khách hàng";
			// 
			// BanHang
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2314, 1369);
			Controls.Add(groupBox1);
			Controls.Add(groupBox2);
			Controls.Add(groupBox3);
			Controls.Add(panel1);
			Name = "BanHang";
			Text = "Form1";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dtgvHoaDon).EndInit();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dtgvSanPhamChiTiet).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblTongTien;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dtgvHoaDon;
		private System.Windows.Forms.ComboBox cbbChonHoaDon;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnThanhToan;
		private System.Windows.Forms.Label lblTienThua;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtTienKhachDua;
		private System.Windows.Forms.TextBox txtTimSanPham;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnTimKH;
		private System.Windows.Forms.TextBox txtTimKH;
		private System.Windows.Forms.Button btnTaoHoaDon;
		private System.Windows.Forms.TextBox txtTenKH;
		private System.Windows.Forms.TextBox txtSoDienThoai;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dtgvSanPhamChiTiet;
		#endregion
	}
}