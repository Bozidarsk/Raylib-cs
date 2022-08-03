using System.Runtime.InteropServices;
namespace Raylib 
{
	public static class Graphics 
	{
		[DllImport("raylib.dll")] public static extern void BeginDrawing();
		[DllImport("raylib.dll")] public static extern void EndDrawing();
		[DllImport("raylib.dll")] public static extern void DrawPixel(int x, int y, Color color);
		[DllImport("raylib.dll")] public static extern void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color);
		[DllImport("raylib.dll")] public static extern void DrawRectangle(int x, int y, int width, int height, Color color);
		[DllImport("raylib.dll")] public static extern void DrawText(string text, int x, int y, int fontSize, Color color);
		public static void DrawSquare(int x, int y, int size, Color color) { DrawRectangle(x, y, size, size, color); }

		public static void DrawCircle(int x, int y, int radius, Color color) 
		{
			for (int _y = y; _y >= y - radius; _y--) 
			{
				for (int _x = x; _x <= x + radius; _x++) { if ((int)Utils.Math2.Distance(
						new Utils.Vector2((int)x, (int)y),
						new Utils.Vector2((int)_x, (int)_y)
					) == radius) { DrawPixel(_x, _y, color); } }
				for (int _x = x; _x >= x - radius; _x--) { if ((int)Utils.Math2.Distance(
						new Utils.Vector2((int)x, (int)y),
						new Utils.Vector2((int)_x, (int)_y)
					) == radius) { DrawPixel(_x, _y, color); } }
			}

			for (int _y = y; _y <= y + radius; _y++) 
			{
				for (int _x = x; _x <= x + radius; _x++) { if ((int)Utils.Math2.Distance(
						new Utils.Vector2((int)x, (int)y),
						new Utils.Vector2((int)_x, (int)_y)
					) == radius) { DrawPixel(_x, _y, color); } }
				for (int _x = x; _x >= x - radius; _x--) { if ((int)Utils.Math2.Distance(
						new Utils.Vector2((int)x, (int)y),
						new Utils.Vector2((int)_x, (int)_y)
					) == radius) { DrawPixel(_x, _y, color); } }
			}
		}

		public static void DrawDisk(int x, int y, int radius, Color color) 
		{
			for (int _y = y; _y >= y - radius; _y--) 
			{
				for (int _x = x; _x <= x + radius; _x++) { if ((int)Utils.Math2.Distance(
						new Utils.Vector2((int)x, (int)y),
						new Utils.Vector2((int)_x, (int)_y)
					) <= radius) { DrawPixel(_x, _y, color); } }
				for (int _x = x; _x >= x - radius; _x--) { if ((int)Utils.Math2.Distance(
						new Utils.Vector2((int)x, (int)y),
						new Utils.Vector2((int)_x, (int)_y)
					) <= radius) { DrawPixel(_x, _y, color); } }
			}

			for (int _y = y; _y <= y + radius; _y++) 
			{
				for (int _x = x; _x <= x + radius; _x++) { if ((int)Utils.Math2.Distance(
						new Utils.Vector2((int)x, (int)y),
						new Utils.Vector2((int)_x, (int)_y)
					) <= radius) { DrawPixel(_x, _y, color); } }
				for (int _x = x; _x >= x - radius; _x--) { if ((int)Utils.Math2.Distance(
						new Utils.Vector2((int)x, (int)y),
						new Utils.Vector2((int)_x, (int)_y)
					) <= radius) { DrawPixel(_x, _y, color); } }
			}
		}
	}
}