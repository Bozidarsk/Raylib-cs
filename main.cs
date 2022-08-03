using System;
using System.Collections;
using System.Collections.Generic;
using Raylib;

class main 
{
	public static void Main(string[] args) 
	{
		Window.Initialize(800, 450, "raylib [core] example - basic window");
		Window.SetTitle("title");

		// Image icon = Image.Import("icon.png");
		Image icon = new Image(100, 100, new Color(0x5f41d9));
		icon.DrawDisk(50, 50, 49, Color.Red);
		Window.SetIcon(icon);

		while (!Window.ShouldClose())
		{
		    Graphics.BeginDrawing();

		    Window.ClearBackground(Color.LightGray);
		    Graphics.DrawText("Congrats! You created your first window!", 0, 0, 20, Color.Gray);
		    Graphics.DrawCircle(20, 20, 19, Color.Gold);

		    Graphics.EndDrawing();

		    if (Input.IsKeyPressed(Keyboard.A)) { Console.WriteLine("A"); }
		}

		Window.Close();
	}
}