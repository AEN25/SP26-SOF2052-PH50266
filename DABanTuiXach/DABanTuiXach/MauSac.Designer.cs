namespace DABanTuiXach
{
	partial class MauSac
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
			dgvMauSac = new DataGridView();
			LbMauSac = new Label();
			txtMauSac = new TextBox();
			btnThem = new Button();
			btnSua = new Button();
			((System.ComponentModel.ISupportInitialize)dgvMauSac).BeginInit();
			SuspendLayout();
			// 
			// dgvMauSac
			// 
			dgvMauSac.AllowUserToAddRows = false;
			dgvMauSac.AllowUserToDeleteRows = false;
			dgvMauSac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvMauSac.ColumnHeadersHeight = 29;
			dgvMauSac.Location = new Point(0, 463);
			dgvMauSac.Margin = new Padding(4, 5, 4, 5);
			dgvMauSac.Name = "dgvMauSac";
			dgvMauSac.ReadOnly = true;
			dgvMauSac.RowHeadersWidth = 51;
			dgvMauSac.Size = new Size(1065, 231);
			dgvMauSac.TabIndex = 0;
			dgvMauSac.SelectionChanged += dgvMauSac_SelectionChanged;
			// 
			// LbMauSac
			// 
			LbMauSac.AutoSize = true;
			LbMauSac.Location = new Point(276, 131);
			LbMauSac.Margin = new Padding(4, 0, 4, 0);
			LbMauSac.Name = "LbMauSac";
			LbMauSac.Size = new Size(65, 20);
			LbMauSac.TabIndex = 1;
			LbMauSac.Text = "Màu Sắc";
			// 
			// txtMauSac
			// 
			txtMauSac.Location = new Point(388, 131);
			txtMauSac.Margin = new Padding(4, 5, 4, 5);
			txtMauSac.Name = "txtMauSac";
			txtMauSac.Size = new Size(279, 27);
			txtMauSac.TabIndex = 2;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(260, 329);
			btnThem.Margin = new Padding(4, 5, 4, 5);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(169, 54);
			btnThem.TabIndex = 3;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(519, 329);
			btnSua.Margin = new Padding(4, 5, 4, 5);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(207, 54);
			btnSua.TabIndex = 4;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// MauSac
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1067, 692);
			Controls.Add(btnSua);
			Controls.Add(btnThem);
			Controls.Add(txtMauSac);
			Controls.Add(LbMauSac);
			Controls.Add(dgvMauSac);
			Margin = new Padding(4, 5, 4, 5);
			Name = "MauSac";
			Text = "Màu sắc";
			Load += MauSac_Load;
			((System.ComponentModel.ISupportInitialize)dgvMauSac).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}
		private System.Windows.Forms.DataGridView dgvMauSac;
		private System.Windows.Forms.Label LbMauSac;
		private System.Windows.Forms.TextBox txtMauSac;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		#endregion
	}
}