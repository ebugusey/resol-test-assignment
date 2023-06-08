using Resol.Picker.Components;
using Resol.Picker.Models;

namespace Resol.Picker.Views;

public class MainWindowViewModel : ReactiveViewModel
{
    public PicklistViewModel Items { get; }

    public MainWindowViewModel()
    {
        var items = new Items();
        items.Add();
        items.Add();
        items.Add();
        items.Add();
        items.Add();

        Items = new PicklistViewModel(items);
    }
}
