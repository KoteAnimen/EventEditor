namespace EventEditor
{
	public static class FakeCameras
	{
		private static string path1 = "C:\\Users\\Kvantron_Admin\\Desktop\\MV-CA023-10GM (02J90377017)\\Image_20230306142137615.bmp";
		private static string path2 = "C:\\Users\\Kvantron_Admin\\Desktop\\MV-CA023-10GM (02J90377017)\\Image_20230306142137618.bmp";

		public static List<FakeCamera> Cameras { get; set; } = new List<FakeCamera>()
		{
			new FakeCamera() { Name = "Camera1", Video = new Bitmap(path1)},
			new FakeCamera() { Name = "Camera2", Video = new Bitmap(path2)}
		};
	}

	public class FakeCamera
	{
		public string Name { get; set; } = "";
		public Bitmap? Video { get; set; }
	}
}
