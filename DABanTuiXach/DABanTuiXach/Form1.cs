using System.Data;

namespace DABanTuiXach
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.Columns.Clear();

			
			DataTable dt = new DataTable();
			dt.Columns.Add("Id", typeof(int));
			dt.Columns.Add("Name", typeof(string));
			dt.Columns.Add("Age", typeof(int));
			dt.Columns.Add("Sdt", typeof(string));
			dt.Columns.Add("Gioitinh", typeof(string));
			dt.Columns.Add("Email", typeof(string));

			DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn
			{
				Name = "Id",
				HeaderText = "Mã Nhân Viên",
				DataPropertyName = "Id",
				Width = 100
			};

			DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn
			{
				Name = "Name",
				HeaderText = "Tên Nhân Viên",
				DataPropertyName = "Name",
				Width = 200
			};

			DataGridViewTextBoxColumn colAge = new DataGridViewTextBoxColumn
			{
				Name = "Age",
				HeaderText = "Tuổi",
				DataPropertyName = "Age",
				Width = 50
			};
			DataGridViewTextBoxColumn colSdt = new DataGridViewTextBoxColumn
			{
				Name = "Sdt",
				HeaderText = "Số Điện Thoại",
				DataPropertyName = "Sdt",
				Width = 150
			};
			DataGridViewTextBoxColumn colGioitinh = new DataGridViewTextBoxColumn
			{
				Name = "Gioitinh",
				HeaderText = "Giới Tính",
				DataPropertyName = "Gioitinh",
				Width = 100
			};
			DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn
			{
				Name = "Email",
				HeaderText = "Email",
				DataPropertyName = "Email",
				Width = 200
			};



			dataGridView1.Columns.AddRange(colId, colName, colAge,colSdt,colGioitinh,colEmail);

			
			dt.Rows.Add(1, "Nguyễn Văn A", 25,"0934272337","1");
			dt.Rows.Add(2, "Trần Thị B", 30);

			
			dataGridView1.DataSource = dt;
		}


	}
}
