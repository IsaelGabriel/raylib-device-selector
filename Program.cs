using Raylib_cs;

static class Game {
    const int Width = 600;
    const int Height = 600;
    const string Title = "Device Selector";

    const int TargetFPS = 60;

    static readonly Color ClearColor = Color.DarkPurple;

    static void Main() {
        Raylib.InitWindow(Width, Height, Title);

        Raylib.SetTargetFPS(TargetFPS);

        while(!Raylib.WindowShouldClose()) { 
            Raylib.ClearBackground(ClearColor);
            Render();
        }

        Raylib.CloseWindow();
    }

    static void Render() {
        Raylib.BeginDrawing();
            Raylib.DrawFPS(0,0);
        Raylib.EndDrawing();
    }
}