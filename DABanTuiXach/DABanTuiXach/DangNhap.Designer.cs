namespace DABanTuiXach
{
	partial class DangNhap
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
			btnDangNhap = new Button();
			btnThoat = new Button();
			groupBox1 = new GroupBox();
			linkLabel1 = new LinkLabel();
			txtMk = new TextBox();
			txtTk = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// btnDangNhap
			// 
			btnDangNhap.AutoSize = true;
			btnDangNhap.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnDangNhap.Location = new Point(107, 255);
			btnDangNhap.Name = "btnDangNhap";
			btnDangNhap.Size = new Size(104, 32);
			btnDangNhap.TabIndex = 0;
			btnDangNhap.Text = "Đăng Nhập";
			btnDangNhap.UseVisualStyleBackColor = true;
			// 
			// btnThoat
			// 
			btnThoat.AutoSize = true;
			btnThoat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnThoat.Location = new Point(310, 255);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(84, 32);
			btnThoat.TabIndex = 1;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = SystemColors.ButtonFace;
			groupBox1.Controls.Add(linkLabel1);
			groupBox1.Controls.Add(txtMk);
			groupBox1.Controls.Add(txtTk);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(btnDangNhap);
			groupBox1.Controls.Add(btnThoat);
			groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			groupBox1.ForeColor = SystemColors.ControlText;
			groupBox1.Location = new Point(202, 218);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(440, 380);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = " ";
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			linkLabel1.Location = new Point(160, 197);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(107, 17);
			linkLabel1.TabIndex = 6;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Quên Mật Khẩu";
			// 
			// txtMk
			// 
			txtMk.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtMk.Location = new Point(160, 164);
			txtMk.Name = "txtMk";
			txtMk.PasswordChar = '*';
			txtMk.Size = new Size(234, 23);
			txtMk.TabIndex = 5;
			// 
			// txtTk
			// 
			txtTk.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtTk.Location = new Point(160, 81);
			txtTk.Name = "txtTk";
			txtTk.Size = new Size(234, 23);
			txtTk.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(68, 164);
			label3.Name = "label3";
			label3.Size = new Size(68, 17);
			label3.TabIndex = 3;
			label3.Text = "Mật Khẩu";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(64, 88);
			label2.Name = "label2";
			label2.Size = new Size(73, 17);
			label2.TabIndex = 2;
			label2.Text = "Tài Khoản";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(341, 77);
			label1.Name = "label1";
			label1.Size = new Size(175, 36);
			label1.TabIndex = 7;
			label1.Text = "Đăng Nhập";
			// 
			// DangNhap
			// 
			AcceptButton = btnDangNhap;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(888, 583);
			ControlBox = false;
			Controls.Add(groupBox1);
			Controls.Add(label1);
			DoubleBuffered = true;
			Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Location = new Point(262, 71);
			Name = "DangNhap";
			Text = "DangNhap";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}
		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.TextBox txtMk;
		private System.Windows.Forms.TextBox txtTk;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		#endregion
	}
}