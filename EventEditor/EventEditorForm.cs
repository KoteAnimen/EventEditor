namespace EventEditor
{
	public partial class EventEditorForm : Form
	{
		private FakeCamera? _camera = null;
		private Mark? _mark = null;

		public EventEditorForm()
		{
			InitializeComponent();
			UpdateCameras();
		}

		#region Работа с камерами

		private void UpdateCameras()
		{
			listCamera.Items.Clear();

			foreach (var item in FakeCameras.Cameras)
			{
				listCamera.Items.Add(item.Name);
			}
		}

		private void listCamera_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selected = listCamera.SelectedIndex;

			if (selected != -1)
			{
				_camera = FakeCameras.Cameras[selected];
				pictureBox.Image = _camera.Video;
				UpdateMarks();
			}
		}

		#endregion


		#region Редактирование заметок

		private void UpdateMarks()
		{
			if (_camera != null)
			{
				_mark = null;
				listMarks.Items.Clear();
				var list = EventMarks.Marks.Where(x => x.CameraInfo == _camera.Name || x.Type == MarkType.EVENT).ToList();

				if (list.Count > 0)
				{
					foreach (var item in list)
					{
						Color color = EventMarks.ToColor(item.Color);
						string Name = item.Name;
						string Short = item.ShortDescription;
						string Full = item.Description;

						listMarks.Items.Add(new ListViewItem(new string[] { Name, Short, Full }) { BackColor = color });						
					}
				}				
			}
		}

		private void listMarks_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				var name = listMarks.SelectedItems[0].SubItems[0].Text;
				_mark = EventMarks.Marks.FirstOrDefault(x => x.Name == name);
			}
			catch { }
		}

		private void mi_AddMark_Click(object sender, EventArgs e)
		{
			if (_camera != null)
			{
				var item = new Mark()
				{
					FrameID = 0,
					CameraInfo = _camera.Name
				};

				new EditMarkForm(item, false).ShowDialog();
				UpdateMarks();
			}
		}

		private void mi_EditMark_Click(object sender, EventArgs e)
		{
			if (_mark != null)
			{
				new EditMarkForm(_mark, true).ShowDialog();
				UpdateMarks();
			}
		}

		private void mi_DeleteMark_Click(object sender, EventArgs e)
		{
			if (_mark != null)
			{
				DialogResult result = MessageBox.Show("Вы действительно хотите удалить заметку?", "удалить заметку", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					EventMarks.Marks.Remove(_mark);
					UpdateMarks();
				}
			}			
		}

		private void cms_AddMark_Click(object sender, EventArgs e)
		{
			mi_AddMark_Click(sender, e);
		}

		private void cms_EditMark_Click(object sender, EventArgs e)
		{
			mi_EditMark_Click(sender, e);
		}

		private void cms_DeleteMark_Click(object sender, EventArgs e)
		{
			mi_DeleteMark_Click(sender, e);
		}
		#endregion		
	}
}