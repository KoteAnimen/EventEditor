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

		public EditMarkForm(Mark mark, bool isEdit)
		{
			InitializeComponent();

			foreach (var item in Enum.GetNames(typeof(MarkType)))
			{
				cmb_MarkType.Items.Add(item);
			}

			CurrentMark = mark;
			IsEdit = isEdit;

			tbx_Name.Text = CurrentMark.Name;
			btn_SelectColor.BackColor = CurrentMark.Color == "" ? Color.White : EventMarks.ToColor(CurrentMark.Color);
			cmb_MarkType.Text = CurrentMark.Type.ToString();
			tbx_ShortDescription.Text = CurrentMark.ShortDescription;
			tbx_Description.Text = CurrentMark.Description;

			if (IsEdit == true)
			{
				Text = "Редактировать заметку";
				lbl_Header.Text = Text;
				btn_Accept.Text = "Редактировать";
				cmb_MarkType.Enabled = false;
			}
		}

		private void btn_SelectColor_Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == DialogResult.OK)
			{
				btn_SelectColor.BackColor = cd.Color;
				CurrentMark.Color = EventMarks.FromColor(cd.Color);
			}
		}

		private void btn_Accept_Click(object sender, EventArgs e)
		{
			var item = EventMarks.Marks.FirstOrDefault(m => m.Name == tbx_Name.Text);

			if (tbx_Name.Text == "")
			{
				MessageBox.Show("Не введено имя события!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (item != null && !IsEdit)
			{
				MessageBox.Show("Такое имя события уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (cmb_MarkType.Text == "")
			{
				MessageBox.Show("Не выбран тип события!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			CurrentMark.Name = tbx_Name.Text;
			CurrentMark.Type = (MarkType)cmb_MarkType.SelectedIndex;
			CurrentMark.Color = EventMarks.FromColor(btn_SelectColor.BackColor);
			CurrentMark.ShortDescription = tbx_ShortDescription.Text;
			CurrentMark.Description = tbx_Description.Text;

			if (!IsEdit)
			{
				EventMarks.Marks.Add(CurrentMark);
				DialogResult = DialogResult.OK;
				this.Close();
				return;
			}

			item = CurrentMark;

			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
