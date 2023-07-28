using System;
using System.Drawing;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
public class Program : GameWindow
{
    public Program(int width, int height, string title)
        : base(GameWindowSettings.Default, new NativeWindowSettings() { Size = (width, height), Title = title }) {}
    public static void Main(string[] args)
    {
        using (Program game = new Program(800, 600, "Game"))
        {
            game.Run();
        }
    }

    protected override void OnUpdateFrame(FrameEventArgs args)
    {
        base.OnUpdateFrame(args);

        if (KeyboardState.IsKeyDown(Keys.Escape))
        {
            Close();
        }
    }
}