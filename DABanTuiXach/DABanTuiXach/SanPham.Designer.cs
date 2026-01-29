namespace DABanTuiXach
{
	partial class SanPham
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
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			label10 = new Label();
			txtTimKiemSanPham = new TextBox();
			txtChatLieu = new TextBox();
			txtKieuDang = new TextBox();
			txtSize = new TextBox();
			btnClear = new Button();
			btnSua = new Button();
			btnThem = new Button();
			txtMaSanPham = new TextBox();
			label1 = new Label();
			txtTenSanPham = new TextBox();
			lb = new Label();
			lbChatLieu = new Label();
			lbsize = new Label();
			lbKieuDang = new Label();
			dgvSanPham = new DataGridView();
			tabPage2 = new TabPage();
			txtTenSanPhamCuaChitTiet = new TextBox();
			label9 = new Label();
			txtCRUDMauSac = new Button();
			cbbMaSanPham = new ComboBox();
			btnClearSanPhamChiTiet = new Button();
			groupBox1 = new GroupBox();
			label11 = new Label();
			txtTimKiemSanPhamChiTiet = new TextBox();
			dgvSanPhamChiTiet = new DataGridView();
			btnSuaSanPhamChiTiet = new Button();
			btnThemSanPhamChiTiet = new Button();
			label8 = new Label();
			rdbtHetHang = new RadioButton();
			rdbtConHang = new RadioButton();
			label7 = new Label();
			txtMaSanPhamChiTiet = new TextBox();
			cbbMauSac = new ComboBox();
			label6 = new Label();
			label5 = new Label();
			txtTenSanPhamChiTiet = new TextBox();
			label4 = new Label();
			label3 = new Label();
			txtSoLuong = new TextBox();
			label2 = new Label();
			txtGiaSanPham = new TextBox();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
			tabPage2.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvSanPhamChiTiet).BeginInit();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			tabControl1.Location = new Point(3, -3);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(2197, 1357);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(label10);
			tabPage1.Controls.Add(txtTimKiemSanPham);
			tabPage1.Controls.Add(txtChatLieu);
			tabPage1.Controls.Add(txtKieuDang);
			tabPage1.Controls.Add(txtSize);
			tabPage1.Controls.Add(btnClear);
			tabPage1.Controls.Add(btnSua);
			tabPage1.Controls.Add(btnThem);
			tabPage1.Controls.Add(txtMaSanPham);
			tabPage1.Controls.Add(label1);
			tabPage1.Controls.Add(txtTenSanPham);
			tabPage1.Controls.Add(lb);
			tabPage1.Controls.Add(lbChatLieu);
			tabPage1.Controls.Add(lbsize);
			tabPage1.Controls.Add(lbKieuDang);
			tabPage1.Controls.Add(dgvSanPham);
			tabPage1.Location = new Point(4, 45);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(2189, 1308);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "Sản Phẩm";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(1168, 445);
			label10.Name = "label10";
			label10.Size = new Size(304, 36);
			label10.TabIndex = 21;
			label10.Text = "Tìm kiếm sản phẩm: ";
			// 
			// txtTimKiemSanPham
			// 
			txtTimKiemSanPham.Location = new Point(1493, 432);
			txtTimKiemSanPham.Name = "txtTimKiemSanPham";
			txtTimKiemSanPham.Size = new Size(635, 43);
			txtTimKiemSanPham.TabIndex = 20;
			// 
			// txtChatLieu
			// 
			txtChatLieu.Location = new Point(1383, 275);
			txtChatLieu.Name = "txtChatLieu";
			txtChatLieu.Size = new Size(732, 43);
			txtChatLieu.TabIndex = 19;
			// 
			// txtKieuDang
			// 
			txtKieuDang.Location = new Point(1395, 157);
			txtKieuDang.Name = "txtKieuDang";
			txtKieuDang.Size = new Size(732, 43);
			txtKieuDang.TabIndex = 18;
			// 
			// txtSize
			// 
			txtSize.Location = new Point(357, 271);
			txtSize.Name = "txtSize";
			txtSize.Size = new Size(732, 43);
			txtSize.TabIndex = 17;
			// 
			// btnClear
			// 
			btnClear.Location = new Point(784, 429);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(247, 91);
			btnClear.TabIndex = 14;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(437, 432);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(247, 91);
			btnSua.TabIndex = 12;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(73, 431);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(233, 89);
			btnThem.TabIndex = 11;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click_1;
			// 
			// txtMaSanPham
			// 
			txtMaSanPham.Enabled = false;
			txtMaSanPham.Location = new Point(357, 43);
			txtMaSanPham.Name = "txtMaSanPham";
			txtMaSanPham.Size = new Size(732, 43);
			txtMaSanPham.TabIndex = 10;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(49, 55);
			label1.Name = "label1";
			label1.Size = new Size(198, 36);
			label1.TabIndex = 9;
			label1.Text = "Mã Sản Phẩm";
			// 
			// txtTenSanPham
			// 
			txtTenSanPham.Location = new Point(357, 163);
			txtTenSanPham.Name = "txtTenSanPham";
			txtTenSanPham.Size = new Size(732, 43);
			txtTenSanPham.TabIndex = 8;
			// 
			// lb
			// 
			lb.AutoSize = true;
			lb.Location = new Point(39, 163);
			lb.Name = "lb";
			lb.Size = new Size(208, 36);
			lb.TabIndex = 7;
			lb.Text = "Tên Sản Phẩm";
			// 
			// lbChatLieu
			// 
			lbChatLieu.AutoSize = true;
			lbChatLieu.Location = new Point(1168, 285);
			lbChatLieu.Name = "lbChatLieu";
			lbChatLieu.Size = new Size(144, 36);
			lbChatLieu.TabIndex = 3;
			lbChatLieu.Text = "Chất Liệu";
			// 
			// lbsize
			// 
			lbsize.AutoSize = true;
			lbsize.Location = new Point(169, 271);
			lbsize.Name = "lbsize";
			lbsize.Size = new Size(69, 36);
			lbsize.TabIndex = 2;
			lbsize.Text = "Size";
			// 
			// lbKieuDang
			// 
			lbKieuDang.AutoSize = true;
			lbKieuDang.Location = new Point(1157, 157);
			lbKieuDang.Name = "lbKieuDang";
			lbKieuDang.Size = new Size(156, 36);
			lbKieuDang.TabIndex = 1;
			lbKieuDang.Text = "Kiểu Dáng";
			// 
			// dgvSanPham
			// 
			dgvSanPham.AllowUserToAddRows = false;
			dgvSanPham.AllowUserToDeleteRows = false;
			dgvSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSanPham.Location = new Point(3, 557);
			dgvSanPham.Name = "dgvSanPham";
			dgvSanPham.ReadOnly = true;
			dgvSanPham.RowHeadersWidth = 51;
			dgvSanPham.RowTemplate.Height = 24;
			dgvSanPham.Size = new Size(2183, 743);
			dgvSanPham.TabIndex = 0;
			dgvSanPham.SelectionChanged += dgvSanPham_SelectionChanged;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(txtTenSanPhamCuaChitTiet);
			tabPage2.Controls.Add(label9);
			tabPage2.Controls.Add(txtCRUDMauSac);
			tabPage2.Controls.Add(cbbMaSanPham);
			tabPage2.Controls.Add(btnClearSanPhamChiTiet);
			tabPage2.Controls.Add(groupBox1);
			tabPage2.Controls.Add(btnSuaSanPhamChiTiet);
			tabPage2.Controls.Add(btnThemSanPhamChiTiet);
			tabPage2.Controls.Add(label8);
			tabPage2.Controls.Add(rdbtHetHang);
			tabPage2.Controls.Add(rdbtConHang);
			tabPage2.Controls.Add(label7);
			tabPage2.Controls.Add(txtMaSanPhamChiTiet);
			tabPage2.Controls.Add(cbbMauSac);
			tabPage2.Controls.Add(label6);
			tabPage2.Controls.Add(label5);
			tabPage2.Controls.Add(txtTenSanPhamChiTiet);
			tabPage2.Controls.Add(label4);
			tabPage2.Controls.Add(label3);
			tabPage2.Controls.Add(txtSoLuong);
			tabPage2.Controls.Add(label2);
			tabPage2.Controls.Add(txtGiaSanPham);
			tabPage2.Location = new Point(4, 45);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(2189, 1308);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Sản Phẩm Chi Tiết";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtTenSanPhamCuaChitTiet
			// 
			txtTenSanPhamCuaChitTiet.Enabled = false;
			txtTenSanPhamCuaChitTiet.Location = new Point(1521, 123);
			txtTenSanPhamCuaChitTiet.Name = "txtTenSanPhamCuaChitTiet";
			txtTenSanPhamCuaChitTiet.Size = new Size(316, 43);
			txtTenSanPhamCuaChitTiet.TabIndex = 26;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(1231, 125);
			label9.Name = "label9";
			label9.Size = new Size(208, 36);
			label9.TabIndex = 24;
			label9.Text = "Tên Sản Phẩm";
			// 
			// txtCRUDMauSac
			// 
			txtCRUDMauSac.Location = new Point(1845, 231);
			txtCRUDMauSac.Name = "txtCRUDMauSac";
			txtCRUDMauSac.Size = new Size(59, 55);
			txtCRUDMauSac.TabIndex = 23;
			txtCRUDMauSac.Text = "+";
			txtCRUDMauSac.UseVisualStyleBackColor = true;
			// 
			// cbbMaSanPham
			// 
			cbbMaSanPham.FormattingEnabled = true;
			cbbMaSanPham.Location = new Point(1521, 27);
			cbbMaSanPham.Name = "cbbMaSanPham";
			cbbMaSanPham.Size = new Size(316, 44);
			cbbMaSanPham.TabIndex = 22;
			// 
			// btnClearSanPhamChiTiet
			// 
			btnClearSanPhamChiTiet.Location = new Point(1401, 637);
			btnClearSanPhamChiTiet.Name = "btnClearSanPhamChiTiet";
			btnClearSanPhamChiTiet.Size = new Size(184, 77);
			btnClearSanPhamChiTiet.TabIndex = 21;
			btnClearSanPhamChiTiet.Text = "Clear";
			btnClearSanPhamChiTiet.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label11);
			groupBox1.Controls.Add(txtTimKiemSanPhamChiTiet);
			groupBox1.Controls.Add(dgvSanPhamChiTiet);
			groupBox1.Location = new Point(27, 723);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1941, 493);
			groupBox1.TabIndex = 19;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông Tin Chi Tiết Sản Phẩm";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(1177, 57);
			label11.Name = "label11";
			label11.Size = new Size(399, 36);
			label11.TabIndex = 27;
			label11.Text = "Tìm kiếm sản phẩm chi tiết:";
			// 
			// txtTimKiemSanPhamChiTiet
			// 
			txtTimKiemSanPhamChiTiet.Location = new Point(1621, 45);
			txtTimKiemSanPhamChiTiet.Name = "txtTimKiemSanPhamChiTiet";
			txtTimKiemSanPhamChiTiet.Size = new Size(313, 43);
			txtTimKiemSanPhamChiTiet.TabIndex = 20;
			// 
			// dgvSanPhamChiTiet
			// 
			dgvSanPhamChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvSanPhamChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSanPhamChiTiet.Location = new Point(0, 140);
			dgvSanPhamChiTiet.Name = "dgvSanPhamChiTiet";
			dgvSanPhamChiTiet.RowHeadersWidth = 51;
			dgvSanPhamChiTiet.RowTemplate.Height = 24;
			dgvSanPhamChiTiet.Size = new Size(1933, 349);
			dgvSanPhamChiTiet.TabIndex = 0;
			// 
			// btnSuaSanPhamChiTiet
			// 
			btnSuaSanPhamChiTiet.Location = new Point(967, 637);
			btnSuaSanPhamChiTiet.Name = "btnSuaSanPhamChiTiet";
			btnSuaSanPhamChiTiet.Size = new Size(251, 77);
			btnSuaSanPhamChiTiet.TabIndex = 17;
			btnSuaSanPhamChiTiet.Text = "Sửa ";
			btnSuaSanPhamChiTiet.UseVisualStyleBackColor = true;
			// 
			// btnThemSanPhamChiTiet
			// 
			btnThemSanPhamChiTiet.Location = new Point(581, 637);
			btnThemSanPhamChiTiet.Name = "btnThemSanPhamChiTiet";
			btnThemSanPhamChiTiet.Size = new Size(171, 77);
			btnThemSanPhamChiTiet.TabIndex = 16;
			btnThemSanPhamChiTiet.Text = "Thêm";
			btnThemSanPhamChiTiet.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(29, 52);
			label8.Name = "label8";
			label8.Size = new Size(311, 36);
			label8.TabIndex = 15;
			label8.Text = "Mã Sản Phẩm Chi Tiết";
			// 
			// rdbtHetHang
			// 
			rdbtHetHang.AutoSize = true;
			rdbtHetHang.Location = new Point(283, 533);
			rdbtHetHang.Name = "rdbtHetHang";
			rdbtHetHang.Size = new Size(164, 40);
			rdbtHetHang.TabIndex = 14;
			rdbtHetHang.TabStop = true;
			rdbtHetHang.Text = "Hết Hàng";
			rdbtHetHang.UseVisualStyleBackColor = true;
			// 
			// rdbtConHang
			// 
			rdbtConHang.AutoSize = true;
			rdbtConHang.Location = new Point(280, 437);
			rdbtConHang.Name = "rdbtConHang";
			rdbtConHang.Size = new Size(167, 40);
			rdbtConHang.TabIndex = 13;
			rdbtConHang.TabStop = true;
			rdbtConHang.Text = "Còn Hàng";
			rdbtConHang.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(41, 440);
			label7.Name = "label7";
			label7.Size = new Size(180, 36);
			label7.TabIndex = 12;
			label7.Text = "Trạng Thái :";
			// 
			// txtMaSanPhamChiTiet
			// 
			txtMaSanPhamChiTiet.Enabled = false;
			txtMaSanPhamChiTiet.Location = new Point(369, 52);
			txtMaSanPhamChiTiet.Name = "txtMaSanPhamChiTiet";
			txtMaSanPhamChiTiet.Size = new Size(405, 43);
			txtMaSanPhamChiTiet.TabIndex = 11;
			// 
			// cbbMauSac
			// 
			cbbMauSac.FormattingEnabled = true;
			cbbMauSac.Location = new Point(1521, 231);
			cbbMauSac.Name = "cbbMauSac";
			cbbMauSac.Size = new Size(316, 44);
			cbbMauSac.TabIndex = 10;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(1231, 237);
			label6.Name = "label6";
			label6.Size = new Size(126, 36);
			label6.TabIndex = 9;
			label6.Text = "Màu Sắc";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(29, 149);
			label5.Name = "label5";
			label5.Size = new Size(314, 36);
			label5.TabIndex = 8;
			label5.Text = "Tên Sản PhẩmChi Tiết";
			// 
			// txtTenSanPhamChiTiet
			// 
			txtTenSanPhamChiTiet.Location = new Point(369, 141);
			txtTenSanPhamChiTiet.Name = "txtTenSanPhamChiTiet";
			txtTenSanPhamChiTiet.Size = new Size(405, 43);
			txtTenSanPhamChiTiet.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(1237, 37);
			label4.Name = "label4";
			label4.Size = new Size(198, 36);
			label4.TabIndex = 5;
			label4.Text = "Mã Sản Phẩm";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(59, 291);
			label3.Name = "label3";
			label3.Size = new Size(146, 36);
			label3.TabIndex = 4;
			label3.Text = "Số Lượng";
			// 
			// txtSoLuong
			// 
			txtSoLuong.Location = new Point(369, 291);
			txtSoLuong.Name = "txtSoLuong";
			txtSoLuong.Size = new Size(313, 43);
			txtSoLuong.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(1237, 357);
			label2.Name = "label2";
			label2.Size = new Size(201, 36);
			label2.TabIndex = 2;
			label2.Text = "Giá Sản Phẩm";
			// 
			// txtGiaSanPham
			// 
			txtGiaSanPham.Location = new Point(1521, 357);
			txtGiaSanPham.Name = "txtGiaSanPham";
			txtGiaSanPham.Size = new Size(316, 43);
			txtGiaSanPham.TabIndex = 1;
			// 
			// SanPham
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2225, 1061);
			Controls.Add(tabControl1);
			Name = "SanPham";
			Text = "SanPham";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvSanPhamChiTiet).EndInit();
			ResumeLayout(false);
		}
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label lbsize;
		private System.Windows.Forms.Label lbKieuDang;
		private System.Windows.Forms.DataGridView dgvSanPham;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox txtTenSanPham;
		private System.Windows.Forms.Label lb;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.TextBox txtMaSanPham;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtGiaSanPham;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTenSanPhamChiTiet;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.RadioButton rdbtHetHang;
		private System.Windows.Forms.RadioButton rdbtConHang;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtMaSanPhamChiTiet;
		private System.Windows.Forms.ComboBox cbbMauSac;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnSuaSanPhamChiTiet;
		private System.Windows.Forms.Button btnThemSanPhamChiTiet;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtTimKiemSanPhamChiTiet;
		private System.Windows.Forms.DataGridView dgvSanPhamChiTiet;
		private System.Windows.Forms.TextBox txtTimKiemSanPham;
		private System.Windows.Forms.TextBox txtChatLieu;
		private System.Windows.Forms.TextBox txtKieuDang;
		private System.Windows.Forms.TextBox txtSize;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnClearSanPhamChiTiet;
		private System.Windows.Forms.ComboBox cbbMaSanPham;
		private System.Windows.Forms.Button txtCRUDMauSac;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtTenSanPhamCuaChitTiet;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lbChatLieu;
		private System.Windows.Forms.Label label11;
	
	#endregion
}
}