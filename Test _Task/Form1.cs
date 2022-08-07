using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test__Task
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Run_Bt_Click(object sender, EventArgs e)
		{
			dataGridView1.DataSource = Product.Get_data(Select_Combo.SelectedIndex);
		}
	}
}
