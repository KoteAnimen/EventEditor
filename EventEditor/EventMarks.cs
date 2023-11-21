using System.ComponentModel;

namespace EventEditor
{
	public enum MarkType
	{
		[Description("Видео")] VIDEO,
		[Description("Кадр")] FRAME,
		[Description("Фрагмент кадра")] FRAME_ROI
	}

	public static class EventMarks
	{
		public static List<Mark> Marks { get; set; } = new List<Mark>();
	}

	public class Mark
	{
		public string Color { get; set; } = ""; 
		public string Name { get; set; } = "";
		public string ShortDescription { get; set; } = "";
		public string Description { get; set; } = "";
		public MarkType Type { get; set; }
		public string CameraInfo { get; set; } = "";
		public Rect_ROI? ROI { get; set; }
	}
	
	public class Rect_ROI
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public string Color { get; set; } = "";
	}
}
