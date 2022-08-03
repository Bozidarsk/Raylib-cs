using System.Runtime.InteropServices;
namespace Raylib 
{
	public static class Input 
	{
		[DllImport("raylib.dll")] public static extern bool IsKeyPressed(int key);
		[DllImport("raylib.dll")] public static extern bool IsKeyDown(int key);
		[DllImport("raylib.dll")] public static extern bool IsKeyReleased(int key);
		[DllImport("raylib.dll")] public static extern bool IsKeyUp(int key);
		[DllImport("raylib.dll")] public static extern void SetExitKey(int key);
		[DllImport("raylib.dll")] public static extern int GetKeyPressed();
		[DllImport("raylib.dll")] public static extern int GetCharPressed();

		[DllImport("raylib.dll")] public static extern bool IsGamepadAvailable(int gamepad);
		[DllImport("raylib.dll")] public static extern string GetGamepadName(int gamepad);
		[DllImport("raylib.dll")] public static extern bool IsGamepadButtonPressed(int gamepad, int button);
		[DllImport("raylib.dll")] public static extern bool IsGamepadButtonDown(int gamepad, int button);
		[DllImport("raylib.dll")] public static extern bool IsGamepadButtonReleased(int gamepad, int button);
		[DllImport("raylib.dll")] public static extern bool IsGamepadButtonUp(int gamepad, int button);
		[DllImport("raylib.dll")] public static extern int GetGamepadButtonPressed();
		[DllImport("raylib.dll")] public static extern int GetGamepadAxisCount(int gamepad);
		[DllImport("raylib.dll")] public static extern float GetGamepadAxisMovement(int gamepad, int axis);
		[DllImport("raylib.dll")] public static extern int SetGamepadMappings(string mappings);

		[DllImport("raylib.dll")] public static extern bool IsMouseButtonPressed(int button);
		[DllImport("raylib.dll")] public static extern bool IsMouseButtonDown(int button);
		[DllImport("raylib.dll")] public static extern bool IsMouseButtonReleased(int button);
		[DllImport("raylib.dll")] public static extern bool IsMouseButtonUp(int button);
		[DllImport("raylib.dll")] public static extern int GetMouseX();
		[DllImport("raylib.dll")] public static extern int GetMouseY();
		[DllImport("raylib.dll")] public static extern Vector2 GetMousePosition();
		[DllImport("raylib.dll")] public static extern Vector2 GetMouseDelta();
		[DllImport("raylib.dll")] public static extern void SetMousePosition(int x, int y);
		[DllImport("raylib.dll")] public static extern void SetMouseOffset(int offsetX, int offsetY);
		[DllImport("raylib.dll")] public static extern void SetMouseScale(float scaleX, float scaleY);
		[DllImport("raylib.dll")] public static extern float GetMouseWheelMove();
		[DllImport("raylib.dll")] public static extern void SetMouseCursor(int cursor);

		[DllImport("raylib.dll")] public static extern int GetTouchX();
		[DllImport("raylib.dll")] public static extern int GetTouchY();
		[DllImport("raylib.dll")] public static extern Vector2 GetTouchPosition(int index);
		[DllImport("raylib.dll")] public static extern int GetTouchPointId(int index);
		[DllImport("raylib.dll")] public static extern int GetTouchPointCount();

		[DllImport("raylib.dll")] public static extern void SetGesturesEnabled(uint flags);
		[DllImport("raylib.dll")] public static extern bool IsGestureDetected(int gesture);
		[DllImport("raylib.dll")] public static extern int GetGestureDetected();
		[DllImport("raylib.dll")] public static extern float GetGestureHoldDuration();
		[DllImport("raylib.dll")] public static extern Vector2 GetGestureDragVector();
		[DllImport("raylib.dll")] public static extern float GetGestureDragAngle();
		[DllImport("raylib.dll")] public static extern Vector2 GetGesturePinchVector();
		[DllImport("raylib.dll")] public static extern float GetGesturePinchAngle();
	}
}