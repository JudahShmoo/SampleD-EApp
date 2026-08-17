namespace CustomWFA
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Large_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Maximized;
		}

		private void Small_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Normal;
		}

		private void Close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Open_Click(object sender, EventArgs e)
		{
			Form1 newForm = new();
			newForm.Show();
		}
	}
}
