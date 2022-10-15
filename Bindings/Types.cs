using System.Runtime.InteropServices;

namespace Raylib 
{
	[System.Serializable]
	public struct Color 
	{
		public byte r;
		public byte g;
		public byte b;
		public byte a;

		public static readonly Color LightGray = new Color(200, 200, 200, 255);
		public static readonly Color Gray = new Color(130, 130, 130, 255);
		public static readonly Color DarkGray = new Color(80, 80, 80, 255);
		public static readonly Color Yellow = new Color(253, 249, 0, 255);
		public static readonly Color Gold = new Color(255, 203, 0, 255);
		public static readonly Color Orange = new Color(255, 161, 0, 255);
		public static readonly Color Pink = new Color(255, 109, 194, 255);
		public static readonly Color Red = new Color(230, 41, 55, 255);
		public static readonly Color Maroon = new Color(190, 33, 55, 255);
		public static readonly Color Green = new Color(0, 228, 48, 255);
		public static readonly Color Lime = new Color(0, 158, 47, 255);
		public static readonly Color DarkGreen = new Color(0, 117, 44, 255);
		public static readonly Color SkyBlue = new Color(102, 191, 255, 255);
		public static readonly Color Blue = new Color(0, 121, 241, 255);
		public static readonly Color DarkBlue = new Color(0, 82, 172, 255);
		public static readonly Color Purple = new Color(200, 122, 255, 255);
		public static readonly Color Violet = new Color(135, 60, 190, 255);
		public static readonly Color DarkPurple = new Color(112, 31, 126, 255);
		public static readonly Color Beige = new Color(211, 176, 131, 255);
		public static readonly Color Brown = new Color(127, 106, 79, 255);
		public static readonly Color DarkBrown = new Color(76, 63, 47, 255);
		public static readonly Color White = new Color(255, 255, 255, 255);
		public static readonly Color Black = new Color(0, 0, 0, 255);
		public static readonly Color Magenta = new Color(255, 0, 255, 255);
		public static readonly Color RayWhite = new Color(245, 245, 245, 255);
		public static readonly Color Transparent  = new Color(0, 0, 0, 0);

		public static Color HexToColor(string hex) 
		{
			if (hex.StartsWith("#")) { hex.TrimStart('#'); }
			if (hex.Length != 6) { return Color.Transparent; }
			byte r = (byte)Convert.HexToDecimal(Convert.ToString(hex[0]) + Convert.ToString(hex[1]));
			byte g = (byte)Convert.HexToDecimal(Convert.ToString(hex[2]) + Convert.ToString(hex[3]));
			byte b = (byte)Convert.HexToDecimal(Convert.ToString(hex[4]) + Convert.ToString(hex[5]));
			return new Color(r, g, b, 0xff);
		}

		public Color(string hex) 
		{
			Color color = HexToColor(hex);
			this.r = color.r;
			this.g = color.g;
			this.b = color.b;
			this.a = color.a;
		}

		public Color(uint rgb) 
		{
			this.r = (byte)((rgb >> 16) & 0xff);
			this.g = (byte)((rgb >> 8) & 0xff);
			this.b = (byte)((rgb >> 0) & 0xff);
			this.a = 0xff;
		}
		
		public Color(byte r, byte g, byte b, byte a) 
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}
	}

	public unsafe struct Image 
	{
		public void* data;
		public int width;
		public int height;
		public int mipmaps;
		public int format;

		[DllImport("raylib.dll")] private static extern Image GenImageColor(int width, int height, Color color);

		[DllImport("raylib.dll")] private static extern Image LoadImage(string file);
		public static Image Import(string file) { return LoadImage(file); }

		[DllImport("raylib.dll")] private static extern bool ExportImage(Image image, string file);
		public bool Export(string file) { return ExportImage(this, file); }

		[DllImport("raylib.dll")] private static extern void ImageClearBackground(Image image, Color color);
		public void ClearBackground(Color color) { ImageClearBackground(this, color); }

		[DllImport("raylib.dll")] private static extern void ImageDrawPixel(Image image, int x, int y, Color color);
		public void DrawPixel(int x, int y, Color color) { ImageDrawPixel(this, x, y, color); }

		[DllImport("raylib.dll")] private static extern void ImageDrawLine(Image image, int startX, int startY, int endX, int endY, Color color);
		public void DrawLine(int startX, int startY, int endX, int endY, Color color) { ImageDrawLine(this, startX, startY, endX, endY, color); }

		[DllImport("raylib.dll")] private static extern void ImageDrawRectangle(Image image, int x, int y, int width, int height, Color color);
		public void DrawRectangle(int x, int y, int width, int height, Color color) { ImageDrawRectangle(this, x, y, width, height, color); }
		public void DrawSquare(int x, int y, int size, Color color) { DrawRectangle(x, y, size, size, color); }

		[DllImport("raylib.dll")] private static extern void ImageDrawText(Image image, string text, int x, int y, int fontSize, Color color);
		public void DrawText(string text, int x, int y, int fontSize, Color color) { ImageDrawText(this, text, x, y, fontSize, color); }

		public void DrawCircle(int x, int y, int radius, Color color) 
		{
			for (int _y = y; _y >= y - radius; _y--) 
			{
				for (int _x = x; _x <= x + radius; _x++) { if ((int)Math.Distance(
						new Vector2((int)x, (int)y),
						new Vector2((int)_x, (int)_y)
					) == radius) { DrawPixel(_x, _y, color); } }
				for (int _x = x; _x >= x - radius; _x--) { if ((int)Math.Distance(
						new Vector2((int)x, (int)y),
						new Vector2((int)_x, (int)_y)
					) == radius) { DrawPixel(_x, _y, color); } }
			}

			for (int _y = y; _y <= y + radius; _y++) 
			{
				for (int _x = x; _x <= x + radius; _x++) { if ((int)Math.Distance(
						new Vector2((int)x, (int)y),
						new Vector2((int)_x, (int)_y)
					) == radius) { DrawPixel(_x, _y, color); } }
				for (int _x = x; _x >= x - radius; _x--) { if ((int)Math.Distance(
						new Vector2((int)x, (int)y),
						new Vector2((int)_x, (int)_y)
					) == radius) { DrawPixel(_x, _y, color); } }
			}
		}

		public void DrawDisk(int x, int y, int radius, Color color) 
		{
			for (int _y = y; _y >= y - radius; _y--) 
			{
				for (int _x = x; _x <= x + radius; _x++) { if ((int)Math.Distance(
						new Vector2((int)x, (int)y),
						new Vector2((int)_x, (int)_y)
					) <= radius) { DrawPixel(_x, _y, color); } }
				for (int _x = x; _x >= x - radius; _x--) { if ((int)Math.Distance(
						new Vector2((int)x, (int)y),
						new Vector2((int)_x, (int)_y)
					) <= radius) { DrawPixel(_x, _y, color); } }
			}

			for (int _y = y; _y <= y + radius; _y++) 
			{
				for (int _x = x; _x <= x + radius; _x++) { if ((int)Math.Distance(
						new Vector2((int)x, (int)y),
						new Vector2((int)_x, (int)_y)
					) <= radius) { DrawPixel(_x, _y, color); } }
				for (int _x = x; _x >= x - radius; _x--) { if ((int)Math.Distance(
						new Vector2((int)x, (int)y),
						new Vector2((int)_x, (int)_y)
					) <= radius) { DrawPixel(_x, _y, color); } }
			}
		}

		public Image(int width, int height) 
		{
			this.data = GenImageColor(width, height, Color.Transparent).data;
			this.width = width;
			this.height = height;
			this.mipmaps = 1;
			this.format = PixelFormat.UncompressedR8G8B8A8;
		}

		public Image(int width, int height, Color color) 
		{
			this.data = GenImageColor(width, height, color).data;
			this.width = width;
			this.height = height;
			this.mipmaps = 1;
			this.format = PixelFormat.UncompressedR8G8B8A8;
		}

		public Image(void* data, int width, int height, int mipmaps, int format) 
		{
			this.data = data;
			this.width = width;
			this.height = height;
			this.mipmaps = mipmaps;
			this.format = format;
		}
	}

	public static class PixelFormat 
	{
		public static int UncompressedGrayscale { get { return 1; } }
		public static int UncompressedGrayAlpha { get { return 2; } }
		public static int UncompressedR5G6B5 { get { return 3; } }
		public static int UncompressedR8G8B8 { get { return 4; } }
		public static int UncompressedR5G5B5A1 { get { return 5; } }
		public static int UncompressedR4G4B4A4 { get { return 6; } }
		public static int UncompressedR8G8B8A8 { get { return 7; } }
		public static int UncompressedR32 { get { return 8; } }
		public static int UncompressedR32G32B32 { get { return 9; } }
		public static int UncompressedR32G32B32A32 { get { return 10; } }
		public static int CompressedDxt1RGB { get { return 11; } }
		public static int CompressedDxt1RGBA { get { return 12; } }
		public static int CompressedDxt3RGBA { get { return 13; } }
		public static int CompressedDxt5RGBA { get { return 14; } }
		public static int CompressedEtc1RGB { get { return 15; } }
		public static int CompressedEtc2RGB { get { return 16; } }
		public static int CompressedEtc2EacRGBA { get { return 17; } }
		public static int CompressedPvrtRGB { get { return 18; } }
		public static int CompressedPvrtRGBA { get { return 19; } }
		public static int CompressedAstc4x4RGBA { get { return 20; } }
		public static int CompressedAstc8x8RGBA { get { return 21; } }
	}

	public static class Keyboard 
	{
		public static int Null           { get { return 0; } }
		public static int Apostrophe     { get { return 39; } }
		public static int Comma          { get { return 44; } }
		public static int Minus          { get { return 45; } }
		public static int Period         { get { return 46; } }
		public static int Slash          { get { return 47; } }
		public static int Zero           { get { return 48; } }
		public static int One            { get { return 49; } }
		public static int Two            { get { return 50; } }
		public static int Three          { get { return 51; } }
		public static int Four           { get { return 52; } }
		public static int Five           { get { return 53; } }
		public static int Six            { get { return 54; } }
		public static int Seven          { get { return 55; } }
		public static int Eight          { get { return 56; } }
		public static int Nine           { get { return 57; } }
		public static int Semicolon      { get { return 59; } }
		public static int Equal          { get { return 61; } }
		public static int A              { get { return 65; } }
		public static int B              { get { return 66; } }
		public static int C              { get { return 67; } }
		public static int D              { get { return 68; } }
		public static int E              { get { return 69; } }
		public static int F              { get { return 70; } }
		public static int G              { get { return 71; } }
		public static int H              { get { return 72; } }
		public static int I              { get { return 73; } }
		public static int J              { get { return 74; } }
		public static int K              { get { return 75; } }
		public static int L              { get { return 76; } }
		public static int M              { get { return 77; } }
		public static int N              { get { return 78; } }
		public static int O              { get { return 79; } }
		public static int P              { get { return 80; } }
		public static int Q              { get { return 81; } }
		public static int R              { get { return 82; } }
		public static int S              { get { return 83; } }
		public static int T              { get { return 84; } }
		public static int U              { get { return 85; } }
		public static int V              { get { return 86; } }
		public static int W              { get { return 87; } }
		public static int X              { get { return 88; } }
		public static int Y              { get { return 89; } }
		public static int Z              { get { return 90; } }
		public static int LeftBracket    { get { return 91; } }
		public static int Backslash      { get { return 92; } }
		public static int RightBracket   { get { return 93; } }
		public static int Grave          { get { return 96; } }
		public static int Space          { get { return 32; } }
		public static int Escape         { get { return 256; } }
		public static int Enter          { get { return 257; } }
		public static int Tab            { get { return 258; } }
		public static int Backspace      { get { return 259; } }
		public static int Insert         { get { return 260; } }
		public static int Delete         { get { return 261; } }
		public static int Right          { get { return 262; } }
		public static int Left           { get { return 263; } }
		public static int Down           { get { return 264; } }
		public static int Up             { get { return 265; } }
		public static int PageUp         { get { return 266; } }
		public static int PageDown       { get { return 267; } }
		public static int Home           { get { return 268; } }
		public static int End            { get { return 269; } }
		public static int CapsLock       { get { return 280; } }
		public static int ScrollLock     { get { return 281; } }
		public static int NumLock        { get { return 282; } }
		public static int PrintScreen    { get { return 283; } }
		public static int Pause          { get { return 284; } }
		public static int F1             { get { return 290; } }
		public static int F2             { get { return 291; } }
		public static int F3             { get { return 292; } }
		public static int F4             { get { return 293; } }
		public static int F5             { get { return 294; } }
		public static int F6             { get { return 295; } }
		public static int F7             { get { return 296; } }
		public static int F8             { get { return 297; } }
		public static int F9             { get { return 298; } }
		public static int F10            { get { return 299; } }
		public static int F11            { get { return 300; } }
		public static int F12            { get { return 301; } }
		public static int LeftShift      { get { return 340; } }
		public static int LeftControl    { get { return 341; } }
		public static int LeftAlt        { get { return 342; } }
		public static int LeftSuper      { get { return 343; } }
		public static int RightShift     { get { return 344; } }
		public static int RightControl   { get { return 345; } }
		public static int RightAlt       { get { return 346; } }
		public static int RightSuper     { get { return 347; } }
		public static int Context        { get { return 348; } }
		public static int Keypad0        { get { return 320; } }
		public static int Keypad1        { get { return 321; } }
		public static int Keypad2        { get { return 322; } }
		public static int Keypad3        { get { return 323; } }
		public static int Keypad4        { get { return 324; } }
		public static int Keypad5        { get { return 325; } }
		public static int Keypad6        { get { return 326; } }
		public static int Keypad7        { get { return 327; } }
		public static int Keypad8        { get { return 328; } }
		public static int Keypad9        { get { return 329; } }
		public static int KeypadDecimal  { get { return 330; } }
		public static int KeypadDivide   { get { return 331; } }
		public static int KeypadMultiply { get { return 332; } }
		public static int KeypadSubtract { get { return 333; } }
		public static int KeypadAdd      { get { return 334; } }
		public static int KeypadEnter    { get { return 335; } }
		public static int KeypadEqual    { get { return 336; } }
		public static int Back           { get { return 4; } }
		public static int Menu           { get { return 82; } }
		public static int VolumeUp       { get { return 24; } }
		public static int VolumeDown     { get { return 25; } }
	}

	public static class Mouse 
	{
		public static int Left    { get { return 0; } }
		public static int Right   { get { return 1; } }
		public static int Middle  { get { return 2; } }
		public static int Side    { get { return 3; } }
		public static int Extra   { get { return 4; } }
		public static int Forward { get { return 5; } }
		public static int Back    { get { return 6; } }
	}

	public static class Cursor 
	{
		public static int Default      { get { return 0; } }
		public static int Arrow        { get { return 1; } }
		public static int Ibeam        { get { return 2; } }
		public static int Crosshair    { get { return 3; } }
		public static int PointingHand { get { return 4; } }
		public static int ResizeEW     { get { return 5; } }
		public static int ResizeNS     { get { return 6; } }
		public static int ResizeNWSE   { get { return 7; } }
		public static int ResizeNESW   { get { return 8; } }
		public static int ResizeAll    { get { return 9; } }
		public static int NotAllowed   { get { return 10; } }
	}

	public static class GamepadButton 
	{
		public static int Unknown        { get { return 0; } }
		public static int LeftFaceUp     { get { return 1; } }
		public static int LeftFaceRight  { get { return 2; } }
		public static int LeftFaceDown   { get { return 3; } }
		public static int LeftFaceLeft   { get { return 4; } }
		public static int RightFaceUp    { get { return 5; } }
		public static int RightFaceRight { get { return 6; } }
		public static int RightFaceDown  { get { return 7; } }
		public static int RightFaceLeft  { get { return 8; } }
		public static int LeftTrigger1   { get { return 9; } }
		public static int LeftTrigger2   { get { return 10; } }
		public static int RightTrigger1  { get { return 11; } }
		public static int RightTrigger2  { get { return 12; } }
		public static int MiddleLeft     { get { return 13; } }
		public static int Middle         { get { return 14; } }
		public static int MiddleRight    { get { return 15; } }
		public static int LeftThumb      { get { return 16; } }
		public static int RightThumb     { get { return 17; } }
	}

	public static class GamepadAxis 
	{
		public static int LeftX        { get { return 0; } }
		public static int LeftY        { get { return 1; } }
		public static int RightX       { get { return 2; } }
		public static int RightY       { get { return 3; } }
		public static int LeftTrigger  { get { return 4; } }
		public static int RightTrigger { get { return 5; } }
	}

	public static class Gesture 
	{
		public static int None       { get { return 0; } }
		public static int Tap        { get { return 1; } }
		public static int Doubletap  { get { return 2; } }
		public static int Hold       { get { return 4; } }
		public static int Drag       { get { return 8; } }
		public static int SwipeRight { get { return 16; } }
		public static int SwipeLeft  { get { return 32; } }
		public static int SwipeUp    { get { return 64; } }
		public static int SwipeDown  { get { return 128; } }
		public static int PinchIn    { get { return 256; } }
		public static int PinchOut   { get { return 512; } }
	}

	public static class WindowState 
	{
		public static int VsyncHint        { get { return 0x00000040; } }
		public static int FullscreenMode   { get { return 0x00000002; } }
		public static int Resizable        { get { return 0x00000004; } }
		public static int Undecorated      { get { return 0x00000008; } }
		public static int Hidden           { get { return 0x00000080; } }
		public static int Minimized        { get { return 0x00000200; } }
		public static int Maximized        { get { return 0x00000400; } }
		public static int Unfocused        { get { return 0x00000800; } }
		public static int Topmost          { get { return 0x00001000; } }
		public static int AlwaysRun        { get { return 0x00000100; } }
		public static int Transparent      { get { return 0x00000010; } }
		public static int HighDPI          { get { return 0x00002000; } }
		public static int MousePassthrough { get { return 0x00004000; } }
		public static int MSAA4xHint       { get { return 0x00000020; } }
		public static int InterlacedHint   { get { return 0x00010000; } }
	}
}