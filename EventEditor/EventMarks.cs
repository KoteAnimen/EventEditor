using System.ComponentModel;

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

		public static string FromColor(Color color)
		{
			string r = color.R.ToString();
			string g = color.G.ToString();
			string b = color.B.ToString();

			return r+","+g+","+ b;
		}	

		public static Color ToColor(string str) 
		{
			try
			{
				int r = Convert.ToInt32((str.Split(',')[0]));
				int g = Convert.ToInt32((str.Split(',')[1]));
				int b = Convert.ToInt32((str.Split(',')[2]));

				return Color.FromArgb(r, g, b);
			}
			catch {	return Color.FromArgb(0, 0, 0);	}			
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

		private System.Drawing.Point firstPoint = new Point();
		private System.Drawing.Point secondPoint = new Point();

		public System.Drawing.Point FirstPoint
		{
			get	{ return firstPoint; }
			set
			{
				X = value.X;
				Y = value.Y;

				firstPoint = value;
			}
		}
		public System.Drawing.Point SecondPoint
		{
			get { return  secondPoint; }
			set
			{
				secondPoint = value;

				Width = Math.Abs(firstPoint.X - secondPoint.X);
				Height = Math.Abs(firstPoint.Y - secondPoint.Y);
			}
		}	

		public System.Drawing.Size SizeImage { get; set; }

		public Rectangle GetRect()
		{
			System.Drawing.Size size = new System.Drawing.Size();
			size.Width = Width;
			size.Height = Height;
			SizeImage = size;

			return new Rectangle(X, Y, SizeImage.Width, SizeImage.Height);
		}
	}
}
