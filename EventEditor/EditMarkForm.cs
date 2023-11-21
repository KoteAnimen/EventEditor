using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventEditor
{
	public partial class EditMarkForm : Form
	{
		private Mark CurrentMark { get; set; } = new Mark();
		private bool IsEdit { get; set; } = false;

		public EditMarkForm()
		{
			InitializeComponent();
		}

		public EditMarkForm(Mark mark)
		{
			InitializeComponent();

			CurrentMark = mark;
			IsEdit = true;			
		}

		private void btn_SelectColor_Click(object sender, EventArgs e)
		{

		}

		private void btn_Accept_Click(object sender, EventArgs e)
		{

		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
