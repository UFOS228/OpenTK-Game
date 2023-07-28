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

    protected override void OnLoad()
    {
        base.OnLoad();

        GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

        //Code goes here
    }
    protected override void OnUpdateFrame(FrameEventArgs args)
    {
        base.OnUpdateFrame(args);

        if (KeyboardState.IsKeyDown(Keys.Escape))
        {
            Close();
        }

        GL.Clear(ClearBufferMask.ColorBufferBit);
        GL

        GL.DrawArrays(PrimitiveType.Quads, 100, 5);

        SwapBuffers();
    }
    protected override void OnResize(ResizeEventArgs e)
    {
        base.OnResize(e);

        GL.Viewport(0, 0, e.Width, e.Height);
    }
}