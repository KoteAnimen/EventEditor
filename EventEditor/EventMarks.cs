using System.ComponentModel;
using System.Diagnostics.Contracts;

namespace EventEditor
{
	public enum MarkType
	{
		[Description("Событие")] EVENT,
		[Description("Видео")] VIDEO,
		[Description("Кадр")] FRAME,
		[Description("Фрагмент кадра")] FRAME_ROI
	}

	public static class EventMarks
	{
		public static List<Mark> Marks { get; set; } = new List<Mark>();

		public static string FromColor(Color color) => color.ToString();		

		public static Color ToColor(string str) 
		{
			int a = Convert.ToInt32(new string(str.Split(',')[0].Where(Char.IsDigit).ToArray()));
			int r = Convert.ToInt32(new string(str.Split(',')[1].Where(Char.IsDigit).ToArray()));
			int g = Convert.ToInt32(new string(str.Split(',')[2].Where(Char.IsDigit).ToArray()));
			int b = Convert.ToInt32(new string(str.Split(',')[3].Where(Char.IsDigit).ToArray()));

			return Color.FromArgb(a, r, g, b);
		}
	}

	public class Mark
	{		
		public string Color { get; set; } = ""; 
		public string Name { get; set; } = "";
		public string ShortDescription { get; set; } = "";
		public string Description { get; set; } = "";
		public MarkType Type { get; set; }
		public int FrameID { get; set; }
		public string CameraInfo { get; set; } = "";
		public Rect_ROI? ROI { get; set; }
	}
	
	public class Rect_ROI
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }		
	}
}
