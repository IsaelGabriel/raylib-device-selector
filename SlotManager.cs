using System.Numerics;
using Raylib_cs;

static class SlotManager {



    const int Margin = 32;

    const int SlotQuantity = 4;

    static readonly int columns = (int) Math.Ceiling(Math.Sqrt(SlotQuantity));
    static readonly int rows = (int) Math.Ceiling((double) SlotQuantity / columns);


    static readonly Vector2 slotSize = new(){
        X = (Game.Width - (columns + 1) * Margin) / columns,
        Y = (Game.Height - (rows + 1) * Margin) / rows
    };



    public static void Render() {
        for(int i = 0; i < SlotQuantity; i++) {
            Vector2 position = new() {
                X = Margin + i % columns * (slotSize.X + Margin),
                Y = Margin + (float) Math.Floor((double) i / columns) * (slotSize.Y + Margin)
            };


            Raylib.DrawRectangle((int) position.X, (int) position.Y, (int) slotSize.X, (int) slotSize.Y, Color.RayWhite);
           
            
        }
    }
}