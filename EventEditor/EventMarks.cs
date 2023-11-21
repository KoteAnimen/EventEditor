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
	}	
}
