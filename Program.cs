using Raylib_cs;

static class Game {
    public const int Width = 600;
    public const int Height = 600;
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
            SlotManager.Render();


            Raylib.DrawFPS(0,0);
        Raylib.EndDrawing();
    }
}