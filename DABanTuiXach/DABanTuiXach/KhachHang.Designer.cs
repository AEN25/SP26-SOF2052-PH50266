namespace DABanTuiXach
{
	partial class KhachHang
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
			DanhSach_KhachHang = new GroupBox();
			data_viewKH = new DataGridView();
			tb_timkiem = new TextBox();
			lb_timkiemkhachhang = new Label();
			groupBox1 = new GroupBox();
			bt_reset = new Button();
			rb_ngunghoatdong = new RadioButton();
			rb_conhoatdong = new RadioButton();
			tb_makhachhang = new TextBox();
			lb_makhachhang = new Label();
			cbb_gioitinhKhachHang = new ComboBox();
			bt_sua = new Button();
			bt_them = new Button();
			tb_email = new TextBox();
			tb_diachi = new TextBox();
			tb_sdt = new TextBox();
			tb_tenKH = new TextBox();
			lb_trangthaikhachhang = new Label();
			lb_emailkhachhang = new Label();
			lb_diachikhachhang = new Label();
			lb_sodienthoaikhachhang = new Label();
			lb_tenkhachhang = new Label();
			lb_gioitinhkhachhang = new Label();
			label2 = new Label();
			lb_thongtinkhachhang = new Label();
			DanhSach_KhachHang.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)data_viewKH).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// DanhSach_KhachHang
			// 
			DanhSach_KhachHang.Controls.Add(data_viewKH);
			DanhSach_KhachHang.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			DanhSach_KhachHang.Location = new Point(2, 900);
			DanhSach_KhachHang.Margin = new Padding(5, 4, 5, 4);
			DanhSach_KhachHang.Name = "DanhSach_KhachHang";
			DanhSach_KhachHang.Padding = new Padding(5, 4, 5, 4);
			DanhSach_KhachHang.Size = new Size(2201, 452);
			DanhSach_KhachHang.TabIndex = 35;
			DanhSach_KhachHang.TabStop = false;
			DanhSach_KhachHang.Text = "Danh Sách Khách Hàng";
			// 
			// data_viewKH
			// 
			data_viewKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			data_viewKH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			data_viewKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			data_viewKH.Dock = DockStyle.Fill;
			data_viewKH.Location = new Point(5, 35);
			data_viewKH.Margin = new Padding(5, 4, 5, 4);
			data_viewKH.Name = "data_viewKH";
			data_viewKH.RowHeadersWidth = 51;
			data_viewKH.Size = new Size(2191, 413);
			data_viewKH.TabIndex = 3;
			data_viewKH.SelectionChanged += data_viewKH_SelectionChanged;
			// 
			// tb_timkiem
			// 
			tb_timkiem.AccessibleName = "";
			tb_timkiem.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			tb_timkiem.Location = new Point(875, 823);
			tb_timkiem.Margin = new Padding(5, 4, 5, 4);
			tb_timkiem.Name = "tb_timkiem";
			tb_timkiem.Size = new Size(622, 38);
			tb_timkiem.TabIndex = 33;
			tb_timkiem.Tag = "";
			// 
			// lb_timkiemkhachhang
			// 
			lb_timkiemkhachhang.AutoSize = true;
			lb_timkiemkhachhang.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lb_timkiemkhachhang.Location = new Point(563, 828);
			lb_timkiemkhachhang.Margin = new Padding(5, 0, 5, 0);
			lb_timkiemkhachhang.Name = "lb_timkiemkhachhang";
			lb_timkiemkhachhang.Size = new Size(287, 32);
			lb_timkiemkhachhang.TabIndex = 34;
			lb_timkiemkhachhang.Text = "Tìm kiếm khách hàng:";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(bt_reset);
			groupBox1.Controls.Add(rb_ngunghoatdong);
			groupBox1.Controls.Add(rb_conhoatdong);
			groupBox1.Controls.Add(tb_makhachhang);
			groupBox1.Controls.Add(lb_makhachhang);
			groupBox1.Controls.Add(cbb_gioitinhKhachHang);
			groupBox1.Controls.Add(bt_sua);
			groupBox1.Controls.Add(bt_them);
			groupBox1.Controls.Add(tb_email);
			groupBox1.Controls.Add(tb_diachi);
			groupBox1.Controls.Add(tb_sdt);
			groupBox1.Controls.Add(tb_tenKH);
			groupBox1.Controls.Add(lb_trangthaikhachhang);
			groupBox1.Controls.Add(lb_emailkhachhang);
			groupBox1.Controls.Add(lb_diachikhachhang);
			groupBox1.Controls.Add(lb_sodienthoaikhachhang);
			groupBox1.Controls.Add(lb_tenkhachhang);
			groupBox1.Controls.Add(lb_gioitinhkhachhang);
			groupBox1.Controls.Add(label2);
			groupBox1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.Location = new Point(16, 156);
			groupBox1.Margin = new Padding(5, 4, 5, 4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(5, 4, 5, 4);
			groupBox1.Size = new Size(2163, 560);
			groupBox1.TabIndex = 31;
			groupBox1.TabStop = false;
			// 
			// bt_reset
			// 
			bt_reset.BackColor = SystemColors.ActiveBorder;
			bt_reset.Location = new Point(1375, 461);
			bt_reset.Margin = new Padding(5, 4, 5, 4);
			bt_reset.Name = "bt_reset";
			bt_reset.Size = new Size(207, 71);
			bt_reset.TabIndex = 27;
			bt_reset.Text = "Clear";
			bt_reset.UseVisualStyleBackColor = false;
			bt_reset.Click += bt_reset_Click;
			// 
			// rb_ngunghoatdong
			// 
			rb_ngunghoatdong.AutoSize = true;
			rb_ngunghoatdong.Location = new Point(738, 360);
			rb_ngunghoatdong.Margin = new Padding(5, 4, 5, 4);
			rb_ngunghoatdong.Name = "rb_ngunghoatdong";
			rb_ngunghoatdong.Size = new Size(291, 36);
			rb_ngunghoatdong.TabIndex = 26;
			rb_ngunghoatdong.TabStop = true;
			rb_ngunghoatdong.Text = "Không thường xuyên";
			rb_ngunghoatdong.UseVisualStyleBackColor = true;
			// 
			// rb_conhoatdong
			// 
			rb_conhoatdong.AutoSize = true;
			rb_conhoatdong.Location = new Point(354, 360);
			rb_conhoatdong.Margin = new Padding(5, 4, 5, 4);
			rb_conhoatdong.Name = "rb_conhoatdong";
			rb_conhoatdong.Size = new Size(213, 36);
			rb_conhoatdong.TabIndex = 25;
			rb_conhoatdong.TabStop = true;
			rb_conhoatdong.Text = "Thường xuyên";
			rb_conhoatdong.UseVisualStyleBackColor = true;
			// 
			// tb_makhachhang
			// 
			tb_makhachhang.Enabled = false;
			tb_makhachhang.Location = new Point(1152, 36);
			tb_makhachhang.Margin = new Padding(5, 4, 5, 4);
			tb_makhachhang.Name = "tb_makhachhang";
			tb_makhachhang.Size = new Size(307, 38);
			tb_makhachhang.TabIndex = 24;
			// 
			// lb_makhachhang
			// 
			lb_makhachhang.AutoSize = true;
			lb_makhachhang.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lb_makhachhang.Location = new Point(918, 36);
			lb_makhachhang.Margin = new Padding(5, 0, 5, 0);
			lb_makhachhang.Name = "lb_makhachhang";
			lb_makhachhang.Size = new Size(198, 32);
			lb_makhachhang.TabIndex = 23;
			lb_makhachhang.Text = "Mã khách hàng";
			// 
			// cbb_gioitinhKhachHang
			// 
			cbb_gioitinhKhachHang.FormattingEnabled = true;
			cbb_gioitinhKhachHang.Items.AddRange(new object[] { "Nam", "Nữ" });
			cbb_gioitinhKhachHang.Location = new Point(354, 240);
			cbb_gioitinhKhachHang.Margin = new Padding(5, 4, 5, 4);
			cbb_gioitinhKhachHang.Name = "cbb_gioitinhKhachHang";
			cbb_gioitinhKhachHang.Size = new Size(716, 39);
			cbb_gioitinhKhachHang.TabIndex = 22;
			// 
			// bt_sua
			// 
			bt_sua.BackColor = SystemColors.ActiveBorder;
			bt_sua.Location = new Point(1058, 461);
			bt_sua.Margin = new Padding(5, 4, 5, 4);
			bt_sua.Name = "bt_sua";
			bt_sua.Size = new Size(207, 71);
			bt_sua.TabIndex = 19;
			bt_sua.Text = "Sửa";
			bt_sua.UseVisualStyleBackColor = false;
			bt_sua.Click += bt_sua_Click;
			// 
			// bt_them
			// 
			bt_them.BackColor = SystemColors.ActiveBorder;
			bt_them.Location = new Point(738, 461);
			bt_them.Margin = new Padding(5, 4, 5, 4);
			bt_them.Name = "bt_them";
			bt_them.Size = new Size(207, 71);
			bt_them.TabIndex = 17;
			bt_them.Text = "Thêm";
			bt_them.UseVisualStyleBackColor = false;
			bt_them.Click += bt_them_Click;
			// 
			// tb_email
			// 
			tb_email.Location = new Point(1406, 363);
			tb_email.Margin = new Padding(5, 4, 5, 4);
			tb_email.Name = "tb_email";
			tb_email.Size = new Size(716, 38);
			tb_email.TabIndex = 15;
			// 
			// tb_diachi
			// 
			tb_diachi.Location = new Point(1406, 252);
			tb_diachi.Margin = new Padding(5, 4, 5, 4);
			tb_diachi.Name = "tb_diachi";
			tb_diachi.Size = new Size(716, 38);
			tb_diachi.TabIndex = 14;
			// 
			// tb_sdt
			// 
			tb_sdt.Location = new Point(1406, 136);
			tb_sdt.Margin = new Padding(5, 4, 5, 4);
			tb_sdt.Name = "tb_sdt";
			tb_sdt.Size = new Size(716, 38);
			tb_sdt.TabIndex = 13;
			// 
			// tb_tenKH
			// 
			tb_tenKH.Location = new Point(354, 129);
			tb_tenKH.Margin = new Padding(5, 4, 5, 4);
			tb_tenKH.Name = "tb_tenKH";
			tb_tenKH.Size = new Size(716, 38);
			tb_tenKH.TabIndex = 10;
			// 
			// lb_trangthaikhachhang
			// 
			lb_trangthaikhachhang.AutoSize = true;
			lb_trangthaikhachhang.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lb_trangthaikhachhang.Location = new Point(47, 367);
			lb_trangthaikhachhang.Margin = new Padding(5, 0, 5, 0);
			lb_trangthaikhachhang.Name = "lb_trangthaikhachhang";
			lb_trangthaikhachhang.Size = new Size(140, 32);
			lb_trangthaikhachhang.TabIndex = 7;
			lb_trangthaikhachhang.Text = "Trạng thái";
			// 
			// lb_emailkhachhang
			// 
			lb_emailkhachhang.AutoSize = true;
			lb_emailkhachhang.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lb_emailkhachhang.Location = new Point(1126, 367);
			lb_emailkhachhang.Margin = new Padding(5, 0, 5, 0);
			lb_emailkhachhang.Name = "lb_emailkhachhang";
			lb_emailkhachhang.Size = new Size(84, 32);
			lb_emailkhachhang.TabIndex = 6;
			lb_emailkhachhang.Text = "Email";
			// 
			// lb_diachikhachhang
			// 
			lb_diachikhachhang.AutoSize = true;
			lb_diachikhachhang.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lb_diachikhachhang.Location = new Point(1126, 252);
			lb_diachikhachhang.Margin = new Padding(5, 0, 5, 0);
			lb_diachikhachhang.Name = "lb_diachikhachhang";
			lb_diachikhachhang.Size = new Size(98, 32);
			lb_diachikhachhang.TabIndex = 5;
			lb_diachikhachhang.Text = "Địa chỉ";
			// 
			// lb_sodienthoaikhachhang
			// 
			lb_sodienthoaikhachhang.AutoSize = true;
			lb_sodienthoaikhachhang.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lb_sodienthoaikhachhang.Location = new Point(1126, 140);
			lb_sodienthoaikhachhang.Margin = new Padding(5, 0, 5, 0);
			lb_sodienthoaikhachhang.Name = "lb_sodienthoaikhachhang";
			lb_sodienthoaikhachhang.Size = new Size(172, 32);
			lb_sodienthoaikhachhang.TabIndex = 4;
			lb_sodienthoaikhachhang.Text = "Số điện thoại";
			// 
			// lb_tenkhachhang
			// 
			lb_tenkhachhang.AutoSize = true;
			lb_tenkhachhang.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lb_tenkhachhang.Location = new Point(47, 129);
			lb_tenkhachhang.Margin = new Padding(5, 0, 5, 0);
			lb_tenkhachhang.Name = "lb_tenkhachhang";
			lb_tenkhachhang.Size = new Size(212, 32);
			lb_tenkhachhang.TabIndex = 2;
			lb_tenkhachhang.Text = "Tên Khách Hàng";
			// 
			// lb_gioitinhkhachhang
			// 
			lb_gioitinhkhachhang.AutoSize = true;
			lb_gioitinhkhachhang.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lb_gioitinhkhachhang.Location = new Point(57, 252);
			lb_gioitinhkhachhang.Margin = new Padding(5, 0, 5, 0);
			lb_gioitinhkhachhang.Name = "lb_gioitinhkhachhang";
			lb_gioitinhkhachhang.Size = new Size(128, 32);
			lb_gioitinhkhachhang.TabIndex = 1;
			lb_gioitinhkhachhang.Text = "Giới Tính";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 8.25F);
			label2.Location = new Point(43, 64);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(0, 17);
			label2.TabIndex = 0;
			// 
			// lb_thongtinkhachhang
			// 
			lb_thongtinkhachhang.AutoSize = true;
			lb_thongtinkhachhang.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			lb_thongtinkhachhang.ForeColor = SystemColors.MenuHighlight;
			lb_thongtinkhachhang.Location = new Point(872, 28);
			lb_thongtinkhachhang.Margin = new Padding(5, 0, 5, 0);
			lb_thongtinkhachhang.Name = "lb_thongtinkhachhang";
			lb_thongtinkhachhang.Size = new Size(431, 47);
			lb_thongtinkhachhang.TabIndex = 30;
			lb_thongtinkhachhang.Text = "Thông Tin Khách Hàng";
			// 
			// KhachHang
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(2191, 1348);
			Controls.Add(DanhSach_KhachHang);
			Controls.Add(tb_timkiem);
			Controls.Add(lb_timkiemkhachhang);
			Controls.Add(groupBox1);
			Controls.Add(lb_thongtinkhachhang);
			Margin = new Padding(5, 4, 5, 4);
			Name = "KhachHang";
			Text = "FormKhachHang";
			DanhSach_KhachHang.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)data_viewKH).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
		private System.Windows.Forms.GroupBox DanhSach_KhachHang;
		private System.Windows.Forms.DataGridView data_viewKH;
		private System.Windows.Forms.TextBox tb_timkiem;
		private System.Windows.Forms.Label lb_timkiemkhachhang;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button bt_sua;
		private System.Windows.Forms.Button bt_them;
		private System.Windows.Forms.TextBox tb_email;
		private System.Windows.Forms.TextBox tb_diachi;
		private System.Windows.Forms.TextBox tb_sdt;
		private System.Windows.Forms.TextBox tb_tenKH;
		private System.Windows.Forms.Label lb_trangthaikhachhang;
		private System.Windows.Forms.Label lb_emailkhachhang;
		private System.Windows.Forms.Label lb_diachikhachhang;
		private System.Windows.Forms.Label lb_sodienthoaikhachhang;
		private System.Windows.Forms.Label lb_tenkhachhang;
		private System.Windows.Forms.Label lb_gioitinhkhachhang;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lb_thongtinkhachhang;
		private System.Windows.Forms.ComboBox cbb_gioitinhKhachHang;
		private System.Windows.Forms.Label lb_makhachhang;
		private System.Windows.Forms.TextBox tb_makhachhang;
		private System.Windows.Forms.RadioButton rb_ngunghoatdong;
		private System.Windows.Forms.RadioButton rb_conhoatdong;
		private System.Windows.Forms.Button bt_reset;
		#endregion
	}
}