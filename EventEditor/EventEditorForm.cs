namespace EventEditor
{
	public partial class EventEditorForm : Form
	{
		public EventEditorForm()
		{
			InitializeComponent();
			UpdateCameras();
		}

		private void UpdateCameras()
		{
			listCamera.Items.Clear();

			foreach (var item in FakeCameras.Cameras)
			{
				listCamera.Items.Add(item.Name);
			}
		}

		private void EventEditorForm_Load(object sender, EventArgs e)
		{

		}

		private void listCamera_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selected = listCamera.SelectedIndex;

			if (selected != -1)
			{
				pictureBox.Image = FakeCameras.Cameras[selected].Video;
			}
		}
	}
}