using System.Runtime.InteropServices;
namespace Raylib 
{
	public static class Window 
	{
		[DllImport("raylib.dll")] private static extern void InitWindow(int width, int height, string title);
		public static void Initialize(int width, int height, string title) { InitWindow(width, height, title); }

		[DllImport("raylib.dll")] private static extern bool WindowShouldClose();
		public static bool ShouldClose() { return WindowShouldClose(); }

		[DllImport("raylib.dll")] private static extern void CloseWindow();
		public static void Close() { CloseWindow(); }

		[DllImport("raylib.dll")] public static extern void ClearBackground(Color color);
		[DllImport("raylib.dll")] public static extern void ToggleFullscreen();

		[DllImport("raylib.dll")] public static extern void ShowCursor();
	    [DllImport("raylib.dll")] public static extern void HideCursor();
	    [DllImport("raylib.dll")] public static extern bool IsCursorHidden();
	    [DllImport("raylib.dll")] public static extern void EnableCursor();
	    [DllImport("raylib.dll")] public static extern void DisableCursor();
	    [DllImport("raylib.dll")] public static extern bool IsCursorOnScreen();

	    [DllImport("raylib.dll")] public static extern void DrawFPS(int x, int y);
	    [DllImport("raylib.dll")] public static extern void SetTargetFPS(int fps);
	    [DllImport("raylib.dll")] public static extern int GetFPS();
	    [DllImport("raylib.dll")] public static extern float GetFrameTime();
	    [DllImport("raylib.dll")] public static extern double GetTime();

		[DllImport("raylib.dll")] private static extern bool IsWindowReady();
		public static bool IsReady() { return IsWindowReady(); }

		[DllImport("raylib.dll")] private static extern bool IsWindowFullscreen();
		public static bool IsFullscreen() { return IsWindowFullscreen(); }

		[DllImport("raylib.dll")] private static extern bool IsWindowHidden();
		public static bool IsHidden() { return IsWindowHidden(); }

		[DllImport("raylib.dll")] private static extern bool IsWindowMinimized();
		public static bool IsMinimized() { return IsWindowMinimized(); }

		[DllImport("raylib.dll")] private static extern bool IsWindowMaximized();
		public static bool IsMaximized() { return IsWindowMaximized(); }

		[DllImport("raylib.dll")] private static extern bool IsWindowFocused();
		public static bool IsFocused() { return IsWindowFocused(); }

		[DllImport("raylib.dll")] private static extern bool IsWindowResized();
		public static bool IsResized() { return IsWindowResized(); }

		[DllImport("raylib.dll")] private static extern bool IsWindowState(uint flag);
		public static bool IsState(uint flag) { return IsWindowState(flag); }

		[DllImport("raylib.dll")] private static extern void SetWindowState(uint flags);
		public static void SetState(uint flags) { SetWindowState(flags); }

		[DllImport("raylib.dll")] private static extern void ClearWindowState(uint flags);
		public static void ClearState(uint flags) { ClearWindowState(flags); }

		[DllImport("raylib.dll")] private static extern void MaximizeWindow();
		public static void Maximize() { MaximizeWindow(); }

		[DllImport("raylib.dll")] private static extern void MinimizeWindow();
		public static void Minimize() { MinimizeWindow(); }

		[DllImport("raylib.dll")] private static extern void RestoreWindow();
		public static void Restore() { RestoreWindow(); }

		[DllImport("raylib.dll")] private static extern void SetWindowIcon(Image image);
		public static void SetIcon(Image image) { SetWindowIcon(image); }

		[DllImport("raylib.dll")] private static extern void SetWindowTitle(string title);
		public static void SetTitle(string title) { SetWindowTitle(title); }

		[DllImport("raylib.dll")] private static extern void SetWindowPosition(int x, int y);
		public static void SetPosition(int x, int y) { SetWindowPosition(x, y); }

		[DllImport("raylib.dll")] private static extern void SetWindowMonitor(int monitor);
		public static void SetMonitor(int monitor) { SetWindowMonitor(monitor); }

		[DllImport("raylib.dll")] private static extern void SetWindowMinSize(int width, int height);
		public static void SetMinSize(int width, int height) { SetWindowMinSize(width, height); }

		[DllImport("raylib.dll")] private static extern void SetWindowSize(int width, int height);
		public static void SetSize(int width, int height) { SetWindowSize(width, height); }

		[DllImport("raylib.dll")] private static extern Vector2 GetWindowPosition();
		public static Vector2 GetPosition() { return GetWindowPosition(); }

		[DllImport("raylib.dll")] private static extern Vector2 GetWindowScaleDPI();
		public static Vector2 GetScaleDPI() { return GetWindowScaleDPI(); }

		[DllImport("raylib.dll")] public static extern int GetScreenWidth();
		[DllImport("raylib.dll")] public static extern int GetScreenHeight();
		public static Vector2 GetScreenSize() { return new Vector2(GetScreenWidth(), GetScreenHeight()); }

		[DllImport("raylib.dll")] public static extern int GetMonitorCount();
		[DllImport("raylib.dll")] public static extern int GetCurrentMonitor();
		[DllImport("raylib.dll")] public static extern Vector2 GetMonitorPosition(int monitor);
		[DllImport("raylib.dll")] public static extern int GetMonitorWidth(int monitor);
		[DllImport("raylib.dll")] public static extern int GetMonitorHeight(int monitor);
		[DllImport("raylib.dll")] public static extern int GetMonitorPhysicalWidth(int monitor);
		[DllImport("raylib.dll")] public static extern int GetMonitorPhysicalHeight(int monitor);
		[DllImport("raylib.dll")] public static extern int GetMonitorRefreshRate(int monitor);
		[DllImport("raylib.dll")] public static extern string GetMonitorName(int monitor);
		[DllImport("raylib.dll")] public static extern void SetClipboardText(string text);
		[DllImport("raylib.dll")] public static extern string GetClipboardText();
	}
}