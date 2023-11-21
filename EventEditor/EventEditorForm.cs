namespace EventEditor
{
	public partial class EventEditorForm : Form
	{
		private FakeCamera? _camera = null;

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
				listMarks.Items.Clear();
				var list = EventMarks.Marks.Where(x => x.CameraInfo == _camera.Name).ToList();

				if (list.Count > 0)
				{
					foreach (var item in list)
					{
						Color color = item.Color == "" ? Color.White : Color.Red;
						string Name = item.Name;
						string Short = item.ShortDescription;
						string Full = item.Description;

						listMarks.Items.Add(new ListViewItem(new string[] { Name, Short, Full }) { BackColor = color });
					}
				}
			}
		}

		private void mi_AddMark_Click(object sender, EventArgs e)
		{

		}

		private void mi_EditMark_Click(object sender, EventArgs e)
		{

		}

		private void mi_DeleteMark_Click(object sender, EventArgs e)
		{

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