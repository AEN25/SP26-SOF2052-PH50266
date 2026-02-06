namespace DABanTuiXach
{
	partial class HoaDon
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
			grpLocHoaDon = new GroupBox();
			label1 = new Label();
			dtpTuNgay = new DateTimePicker();
			label2 = new Label();
			dtpDenNgay = new DateTimePicker();
			label3 = new Label();
			txtTimKiem = new TextBox();
			btnTimKiem = new Button();
			grpDanhSachHoaDon = new GroupBox();
			dgvHoaDon = new DataGridView();
			grpChiTietHoaDon = new GroupBox();
			lblMucGiamGia = new Label();
			lblMaKhuyenMai = new Label();
			lblMaHD = new Label();
			lblNgay = new Label();
			lblKhach = new Label();
			lblNhanVien = new Label();
			dgvChiTietHoaDon = new DataGridView();
			lblTongTien = new Label();
			grpLocHoaDon.SuspendLayout();
			grpDanhSachHoaDon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
			grpChiTietHoaDon.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
			SuspendLayout();
			// 
			// grpLocHoaDon
			// 
			grpLocHoaDon.Controls.Add(label1);
			grpLocHoaDon.Controls.Add(dtpTuNgay);
			grpLocHoaDon.Controls.Add(label2);
			grpLocHoaDon.Controls.Add(dtpDenNgay);
			grpLocHoaDon.Controls.Add(label3);
			grpLocHoaDon.Controls.Add(txtTimKiem);
			grpLocHoaDon.Controls.Add(btnTimKiem);
			grpLocHoaDon.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			grpLocHoaDon.Location = new Point(10, 12);
			grpLocHoaDon.Margin = new Padding(2, 3, 2, 3);
			grpLocHoaDon.Name = "grpLocHoaDon";
			grpLocHoaDon.Padding = new Padding(2, 3, 2, 3);
			grpLocHoaDon.Size = new Size(603, 480);
			grpLocHoaDon.TabIndex = 0;
			grpLocHoaDon.TabStop = false;
			grpLocHoaDon.Text = "Lọc hóa đơn";
			// 
			// label1
			// 
			label1.Location = new Point(21, 63);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(62, 49);
			label1.TabIndex = 0;
			label1.Text = "Từ ngày:";
			// 
			// dtpTuNgay
			// 
			dtpTuNgay.Location = new Point(174, 63);
			dtpTuNgay.Margin = new Padding(2, 3, 2, 3);
			dtpTuNgay.Name = "dtpTuNgay";
			dtpTuNgay.Size = new Size(380, 38);
			dtpTuNgay.TabIndex = 1;
			// 
			// label2
			// 
			label2.Location = new Point(21, 168);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(101, 49);
			label2.TabIndex = 2;
			label2.Text = "Đến ngày:";
			// 
			// dtpDenNgay
			// 
			dtpDenNgay.Location = new Point(174, 168);
			dtpDenNgay.Margin = new Padding(2, 3, 2, 3);
			dtpDenNgay.Name = "dtpDenNgay";
			dtpDenNgay.Size = new Size(380, 38);
			dtpDenNgay.TabIndex = 3;
			// 
			// label3
			// 
			label3.Location = new Point(21, 268);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(149, 43);
			label3.TabIndex = 4;
			label3.Text = "Tên/SĐT Khách:";
			// 
			// txtTimKiem
			// 
			txtTimKiem.Location = new Point(174, 268);
			txtTimKiem.Margin = new Padding(2, 3, 2, 3);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(380, 38);
			txtTimKiem.TabIndex = 5;
			// 
			// btnTimKiem
			// 
			btnTimKiem.Location = new Point(197, 367);
			btnTimKiem.Margin = new Padding(2, 3, 2, 3);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(182, 77);
			btnTimKiem.TabIndex = 6;
			btnTimKiem.Text = "Tìm kiếm";
			btnTimKiem.Click += btnTimKiem_Click;
			// 
			// grpDanhSachHoaDon
			// 
			grpDanhSachHoaDon.Controls.Add(dgvHoaDon);
			grpDanhSachHoaDon.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			grpDanhSachHoaDon.Location = new Point(639, 17);
			grpDanhSachHoaDon.Margin = new Padding(2, 3, 2, 3);
			grpDanhSachHoaDon.Name = "grpDanhSachHoaDon";
			grpDanhSachHoaDon.Padding = new Padding(2, 3, 2, 3);
			grpDanhSachHoaDon.Size = new Size(1543, 476);
			grpDanhSachHoaDon.TabIndex = 1;
			grpDanhSachHoaDon.TabStop = false;
			grpDanhSachHoaDon.Text = "Danh sách hóa đơn đã thanh toán";
			// 
			// dgvHoaDon
			// 
			dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			dgvHoaDon.ColumnHeadersHeight = 29;
			dgvHoaDon.Dock = DockStyle.Fill;
			dgvHoaDon.Location = new Point(2, 34);
			dgvHoaDon.Margin = new Padding(2, 3, 2, 3);
			dgvHoaDon.Name = "dgvHoaDon";
			dgvHoaDon.RowHeadersWidth = 51;
			dgvHoaDon.Size = new Size(1539, 439);
			dgvHoaDon.TabIndex = 0;
			dgvHoaDon.SelectionChanged += dgvHoaDon_SelectionChanged;
			// 
			// grpChiTietHoaDon
			// 
			grpChiTietHoaDon.Controls.Add(lblMucGiamGia);
			grpChiTietHoaDon.Controls.Add(lblMaKhuyenMai);
			grpChiTietHoaDon.Controls.Add(lblMaHD);
			grpChiTietHoaDon.Controls.Add(lblNgay);
			grpChiTietHoaDon.Controls.Add(lblKhach);
			grpChiTietHoaDon.Controls.Add(lblNhanVien);
			grpChiTietHoaDon.Controls.Add(dgvChiTietHoaDon);
			grpChiTietHoaDon.Controls.Add(lblTongTien);
			grpChiTietHoaDon.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			grpChiTietHoaDon.Location = new Point(15, 524);
			grpChiTietHoaDon.Margin = new Padding(2, 3, 2, 3);
			grpChiTietHoaDon.Name = "grpChiTietHoaDon";
			grpChiTietHoaDon.Padding = new Padding(2, 3, 2, 3);
			grpChiTietHoaDon.Size = new Size(2178, 816);
			grpChiTietHoaDon.TabIndex = 2;
			grpChiTietHoaDon.TabStop = false;
			grpChiTietHoaDon.Text = "Chi tiết hóa đơn";
			// 
			// lblMucGiamGia
			// 
			lblMucGiamGia.AutoSize = true;
			lblMucGiamGia.Location = new Point(1339, 724);
			lblMucGiamGia.Margin = new Padding(5, 0, 5, 0);
			lblMucGiamGia.Name = "lblMucGiamGia";
			lblMucGiamGia.Size = new Size(98, 32);
			lblMucGiamGia.TabIndex = 12;
			lblMucGiamGia.Text = "Tên CT";
			// 
			// lblMaKhuyenMai
			// 
			lblMaKhuyenMai.AutoSize = true;
			lblMaKhuyenMai.Location = new Point(789, 731);
			lblMaKhuyenMai.Margin = new Padding(5, 0, 5, 0);
			lblMaKhuyenMai.Name = "lblMaKhuyenMai";
			lblMaKhuyenMai.Size = new Size(200, 32);
			lblMaKhuyenMai.TabIndex = 11;
			lblMaKhuyenMai.Text = "Mã Khuyến Mãi";
			// 
			// lblMaHD
			// 
			lblMaHD.Location = new Point(89, 76);
			lblMaHD.Margin = new Padding(2, 0, 2, 0);
			lblMaHD.Name = "lblMaHD";
			lblMaHD.Size = new Size(302, 56);
			lblMaHD.TabIndex = 0;
			lblMaHD.Text = "Mã HĐ:";
			lblMaHD.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblNgay
			// 
			lblNgay.Location = new Point(433, 76);
			lblNgay.Margin = new Padding(2, 0, 2, 0);
			lblNgay.Name = "lblNgay";
			lblNgay.Size = new Size(328, 60);
			lblNgay.TabIndex = 1;
			lblNgay.Text = "Ngày:";
			lblNgay.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblKhach
			// 
			lblKhach.Location = new Point(878, 76);
			lblKhach.Margin = new Padding(2, 0, 2, 0);
			lblKhach.Name = "lblKhach";
			lblKhach.Size = new Size(454, 60);
			lblKhach.TabIndex = 2;
			lblKhach.Text = "Khách hàng:";
			lblKhach.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblNhanVien
			// 
			lblNhanVien.Location = new Point(1397, 76);
			lblNhanVien.Margin = new Padding(2, 0, 2, 0);
			lblNhanVien.Name = "lblNhanVien";
			lblNhanVien.Size = new Size(702, 69);
			lblNhanVien.TabIndex = 3;
			lblNhanVien.Text = "Nhân viên:";
			lblNhanVien.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// dgvChiTietHoaDon
			// 
			dgvChiTietHoaDon.AllowUserToAddRows = false;
			dgvChiTietHoaDon.AllowUserToDeleteRows = false;
			dgvChiTietHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvChiTietHoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			dgvChiTietHoaDon.ColumnHeadersHeight = 29;
			dgvChiTietHoaDon.Location = new Point(6, 172);
			dgvChiTietHoaDon.Margin = new Padding(2, 3, 2, 3);
			dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
			dgvChiTietHoaDon.ReadOnly = true;
			dgvChiTietHoaDon.RowHeadersWidth = 51;
			dgvChiTietHoaDon.Size = new Size(2174, 511);
			dgvChiTietHoaDon.TabIndex = 4;
			// 
			// lblTongTien
			// 
			lblTongTien.Location = new Point(89, 712);
			lblTongTien.Margin = new Padding(2, 0, 2, 0);
			lblTongTien.Name = "lblTongTien";
			lblTongTien.Size = new Size(438, 76);
			lblTongTien.TabIndex = 5;
			lblTongTien.Text = "Tổng tiền:";
			lblTongTien.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// HoaDon
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2242, 1348);
			Controls.Add(grpLocHoaDon);
			Controls.Add(grpDanhSachHoaDon);
			Controls.Add(grpChiTietHoaDon);
			Margin = new Padding(2, 3, 2, 3);
			Name = "HoaDon";
			Text = " ";
			Load += HoaDon_Load;
			grpLocHoaDon.ResumeLayout(false);
			grpLocHoaDon.PerformLayout();
			grpDanhSachHoaDon.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
			grpChiTietHoaDon.ResumeLayout(false);
			grpChiTietHoaDon.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private Label lblMucGiamGia;
		private Label lblMaKhuyenMai;
		private System.Windows.Forms.GroupBox grpLocHoaDon;
		private System.Windows.Forms.DateTimePicker dtpTuNgay;
		private System.Windows.Forms.DateTimePicker dtpDenNgay;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button btnTimKiem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.GroupBox grpDanhSachHoaDon;
		private System.Windows.Forms.DataGridView dgvHoaDon;

		private System.Windows.Forms.GroupBox grpChiTietHoaDon;
		private System.Windows.Forms.Label lblMaHD;
		private System.Windows.Forms.Label lblNgay;
		private System.Windows.Forms.Label lblKhach;
		private System.Windows.Forms.Label lblNhanVien;
		private System.Windows.Forms.Label lblTongTien;

		private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
	}
}