using System;

namespace Resol.Picker.Models;

public class Item
{
    private const Color ColorMin = Color.Orange;
    private const Color ColorMax = Color.DeepSkyBlue;

    public Color Color { get; private set; }

    public Item()
    {
        Color = GetRandomColor();
    }

    public void ChangeColor()
    {
        Color = GetRandomColor();
    }

    private static Color GetRandomColor()
    {
        var colorIndex = Random.Shared.Next((int)ColorMin, (int)ColorMax);
        return (Color)colorIndex;
    }
}
