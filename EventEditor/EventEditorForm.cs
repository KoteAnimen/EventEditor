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
				CameraInfoView(_camera);
				pictureBox.Image = _camera.Video;
				UpdateMarks();
			}
		}

		private void CameraInfoView(FakeCamera camera)
		{
			tbx_EventInfo.Text = "Камера: " + camera.Name + "\r\n"
								+ "Заметок: "
								+ EventMarks.Marks.Where(x => x.CameraInfo == camera.Name || x.Type == MarkType.EVENT).Count();
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

				UpdateImage();
			}
		}

		private void EventInfo(Mark? mark)
		{
			if (mark != null)
			{
				tbx_EventInfo.Text = "Имя события: " + mark.Name + "\r\n" +
									 "Краткое описание: " + mark.ShortDescription + "\r\n" +
									 "Тип: " + mark.Type.ToString() + "\r\n" +
									 "Камера: " + (mark.Type == MarkType.EVENT ? "All" : mark.CameraInfo) + "\r\n" +
									 "Кадр: " + (mark.Type == MarkType.EVENT || mark.Type == MarkType.VIDEO ? "-" : mark.FrameID.ToString());

				toolStripEventName.Text = mark.Name;

				StartRIO_Button.Enabled = mark.Type == MarkType.FRAME_ROI;
			}
		}

		private void listMarks_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				var name = listMarks.SelectedItems[0].SubItems[0].Text;
				_mark = EventMarks.Marks.FirstOrDefault(x => x.Name == name);
				EventInfo(_mark);
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

		#region ROI Editor

		Pen? pen = null;
		Rectangle rect = new Rectangle();
		bool firstPoint = false;
		bool secondPoint = false;

		private void StartRIO_Button_Click(object sender, EventArgs e)
		{
			if (_mark != null)
			{
				pen = new Pen(EventMarks.ToColor(_mark.Color), 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
				firstPoint = true;
				secondPoint = false;
			}

		}

		private void UpdateImage()
		{
			//FOR ONE FRAME (It's TEST!!!!!!!!!!)
			if (_camera != null)
			{
				var list = EventMarks.Marks.Where(x => x.CameraInfo == _camera.Name && x.Type == MarkType.FRAME_ROI && x.ROI != null).ToList();
				if (list != null)
				{
					pictureBox.Refresh();

					foreach (var item in list)
					{
						Rectangle rect = new Rectangle();

						rect.X = item.ROI.X;
						rect.Y = item.ROI.Y;

						rect.Width = item.ROI.Width;
						rect.Height = item.ROI.Height;

						Pen pr = new Pen(EventMarks.ToColor(item.Color), 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };

						pictureBox.CreateGraphics().DrawRectangle(pr, rect);
					}
				}
			}
		}		

		private void pictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (firstPoint && _mark != null)
			{
				_mark.ROI = new Rect_ROI();
				_mark.ROI.FirstPoint = e.Location;
				secondPoint = true;
				firstPoint = false;
			}
		}

		private void pictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			if (_mark != null && secondPoint == true)
			{
				secondPoint = false;

				rect.X = _mark.ROI.X;
				rect.Y = _mark.ROI.Y;

				rect.Width = _mark.ROI.Width;
				rect.Height = _mark.ROI.Height;

				UpdateImage();
			}
		}

		private void pictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (secondPoint && _mark != null)
			{
				Point p = e.Location;

				if (p.X > pictureBox.Width || p.Y > pictureBox.Height)
				{
					return;
				}

				_mark.ROI.SecondPoint = p;

				UpdateImage();

				pictureBox.CreateGraphics().DrawRectangle(pen, _mark.ROI.GetRect());
			}
		}

		private void EventEditorForm_SizeChanged(object sender, EventArgs e)
		{
			UpdateImage();
		}

		private void panelImage_Scroll(object sender, ScrollEventArgs e)
		{
			UpdateImage();
		}

		#endregion
	}
}