namespace DABanTuiXach
{
	partial class NhanVien
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
			groupBox2 = new GroupBox();
			dataGridView1 = new DataGridView();
			txtTimkiem = new TextBox();
			btnLammoi = new Button();
			btnSua = new Button();
			btnThem = new Button();
			rbNghilam = new RadioButton();
			rbLam = new RadioButton();
			cbGt = new ComboBox();
			txtMk = new TextBox();
			txtTk = new TextBox();
			txtSdt = new TextBox();
			txtDiachi = new TextBox();
			txtEmail = new TextBox();
			txtTennv = new TextBox();
			txtmaNv = new TextBox();
			label9 = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			groupBox1 = new GroupBox();
			label11 = new Label();
			cbCv = new ComboBox();
			label10 = new Label();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox2
			// 
			groupBox2.AutoSize = true;
			groupBox2.Controls.Add(dataGridView1);
			groupBox2.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox2.Location = new Point(12, 419);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(1742, 456);
			groupBox2.TabIndex = 4;
			groupBox2.TabStop = false;
			groupBox2.Text = "Danh Sách Nhân Viên";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(3, 34);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.RowTemplate.Height = 24;
			dataGridView1.Size = new Size(1739, 414);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			
			// 
			// txtTimkiem
			// 
			txtTimkiem.Location = new Point(1208, 300);
			txtTimkiem.Name = "txtTimkiem";
			txtTimkiem.Size = new Size(332, 38);
			txtTimkiem.TabIndex = 24;
			// 
			// btnLammoi
			// 
			btnLammoi.Location = new Point(1587, 168);
			btnLammoi.Name = "btnLammoi";
			btnLammoi.Size = new Size(130, 40);
			btnLammoi.TabIndex = 22;
			btnLammoi.Text = "Làm Mới";
			btnLammoi.UseVisualStyleBackColor = true;
			btnLammoi.Click += btnLammoi_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(1587, 111);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(130, 40);
			btnSua.TabIndex = 20;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(1587, 64);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(130, 40);
			btnThem.TabIndex = 19;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// rbNghilam
			// 
			rbNghilam.AutoSize = true;
			rbNghilam.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			rbNghilam.Location = new Point(1390, 224);
			rbNghilam.Name = "rbNghilam";
			rbNghilam.Size = new Size(150, 36);
			rbNghilam.TabIndex = 18;
			rbNghilam.TabStop = true;
			rbNghilam.Text = "Nghỉ Làm";
			rbNghilam.UseVisualStyleBackColor = true;
			// 
			// rbLam
			// 
			rbLam.AutoSize = true;
			rbLam.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			rbLam.Location = new Point(1263, 224);
			rbLam.Name = "rbLam";
			rbLam.Size = new Size(121, 36);
			rbLam.TabIndex = 17;
			rbLam.TabStop = true;
			rbLam.Text = "Đi Làm";
			rbLam.UseVisualStyleBackColor = true;
			// 
			// cbGt
			// 
			cbGt.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			cbGt.FormattingEnabled = true;
			cbGt.Location = new Point(753, 218);
			cbGt.Name = "cbGt";
			cbGt.Size = new Size(300, 39);
			cbGt.TabIndex = 16;
			// 
			// txtMk
			// 
			txtMk.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtMk.Location = new Point(1240, 135);
			txtMk.Name = "txtMk";
			txtMk.Size = new Size(300, 38);
			txtMk.TabIndex = 15;
			// 
			// txtTk
			// 
			txtTk.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtTk.Location = new Point(1240, 69);
			txtTk.Name = "txtTk";
			txtTk.Size = new Size(300, 38);
			txtTk.TabIndex = 14;
			// 
			// txtSdt
			// 
			txtSdt.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtSdt.Location = new Point(753, 139);
			txtSdt.Name = "txtSdt";
			txtSdt.Size = new Size(300, 38);
			txtSdt.TabIndex = 13;
			// 
			// txtDiachi
			// 
			txtDiachi.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtDiachi.Location = new Point(753, 59);
			txtDiachi.Name = "txtDiachi";
			txtDiachi.Size = new Size(300, 38);
			txtDiachi.TabIndex = 12;
			// 
			// txtEmail
			// 
			txtEmail.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtEmail.Location = new Point(231, 219);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(300, 38);
			txtEmail.TabIndex = 11;
			// 
			// txtTennv
			// 
			txtTennv.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtTennv.Location = new Point(231, 143);
			txtTennv.Name = "txtTennv";
			txtTennv.Size = new Size(300, 38);
			txtTennv.TabIndex = 10;
			// 
			// txtmaNv
			// 
			txtmaNv.Enabled = false;
			txtmaNv.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtmaNv.Location = new Point(231, 69);
			txtmaNv.Name = "txtmaNv";
			txtmaNv.Size = new Size(300, 38);
			txtmaNv.TabIndex = 9;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label9.Location = new Point(1075, 219);
			label9.Name = "label9";
			label9.Size = new Size(147, 32);
			label9.TabIndex = 8;
			label9.Text = "Trạng Thái";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.Location = new Point(1075, 145);
			label8.Name = "label8";
			label8.Size = new Size(131, 32);
			label8.TabIndex = 7;
			label8.Text = "Mật Khẩu";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label7.Location = new Point(1075, 75);
			label7.Name = "label7";
			label7.Size = new Size(137, 32);
			label7.TabIndex = 6;
			label7.Text = "Tài Khoản";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(564, 221);
			label6.Name = "label6";
			label6.Size = new Size(128, 32);
			label6.TabIndex = 5;
			label6.Text = "Giới Tính";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(564, 140);
			label5.Name = "label5";
			label5.Size = new Size(182, 32);
			label5.TabIndex = 4;
			label5.Text = "Số Điện Thoại";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(564, 69);
			label4.Name = "label4";
			label4.Size = new Size(100, 32);
			label4.TabIndex = 3;
			label4.Text = "Địa Chỉ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(43, 215);
			label3.Name = "label3";
			label3.Size = new Size(84, 32);
			label3.TabIndex = 2;
			label3.Text = "Email";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(43, 139);
			label2.Name = "label2";
			label2.Size = new Size(191, 32);
			label2.TabIndex = 1;
			label2.Text = "Tên Nhân Viên";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(43, 65);
			label1.Name = "label1";
			label1.Size = new Size(182, 32);
			label1.TabIndex = 0;
			label1.Text = "Mã Nhân Viên";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label11);
			groupBox1.Controls.Add(cbCv);
			groupBox1.Controls.Add(label10);
			groupBox1.Controls.Add(txtTimkiem);
			groupBox1.Controls.Add(btnLammoi);
			groupBox1.Controls.Add(btnSua);
			groupBox1.Controls.Add(btnThem);
			groupBox1.Controls.Add(rbNghilam);
			groupBox1.Controls.Add(rbLam);
			groupBox1.Controls.Add(cbGt);
			groupBox1.Controls.Add(txtMk);
			groupBox1.Controls.Add(txtTk);
			groupBox1.Controls.Add(txtSdt);
			groupBox1.Controls.Add(txtDiachi);
			groupBox1.Controls.Add(txtEmail);
			groupBox1.Controls.Add(txtTennv);
			groupBox1.Controls.Add(txtmaNv);
			groupBox1.Controls.Add(label9);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			groupBox1.Location = new Point(12, 36);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1742, 366);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			groupBox1.Text = "Thông Tin Nhân Viên";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label11.Location = new Point(913, 304);
			label11.Name = "label11";
			label11.Size = new Size(266, 32);
			label11.TabIndex = 27;
			label11.Text = "Tìm kiếm nhân viên:";
			// 
			// cbCv
			// 
			cbCv.FormattingEnabled = true;
			cbCv.Location = new Point(202, 284);
			cbCv.Name = "cbCv";
			cbCv.Size = new Size(300, 39);
			cbCv.TabIndex = 26;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(43, 291);
			label10.Name = "label10";
			label10.Size = new Size(114, 32);
			label10.TabIndex = 25;
			label10.Text = "Chức Vụ";
			// 
			// NhanVien
			// 
			AutoScaleDimensions = new SizeF(9F, 18F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1821, 876);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Name = "NhanVien";
			Text = "QuanLyNhanVien";
			groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtTimkiem;
		private System.Windows.Forms.Button btnLammoi;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.RadioButton rbNghilam;
		private System.Windows.Forms.RadioButton rbLam;
		private System.Windows.Forms.ComboBox cbGt;
		private System.Windows.Forms.TextBox txtMk;
		private System.Windows.Forms.TextBox txtTk;
		private System.Windows.Forms.TextBox txtSdt;
		private System.Windows.Forms.TextBox txtDiachi;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtTennv;
		private System.Windows.Forms.TextBox txtmaNv;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbCv;
		private System.Windows.Forms.Label label11;
		#endregion
	}
}