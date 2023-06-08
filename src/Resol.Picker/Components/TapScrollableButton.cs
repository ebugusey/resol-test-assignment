using System;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Styling;

namespace Resol.Picker.Components;

public class TapScrollableButton : Button, IStyleable
{
    Type IStyleable.StyleKey => typeof(Button);

    protected override void OnPointerPressed(PointerPressedEventArgs e)
    {
        base.OnPointerPressed(e);

        e.Handled = false;
    }
}
