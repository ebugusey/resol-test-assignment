using System.Windows.Input;
using ReactiveUI;
using Resol.Picker.Models;

namespace Resol.Picker.Components;

public class ItemButtonViewModel : ReactiveViewModel
{
    private readonly Item _item;

    public string Color => _item.Color.ToString();

    public ICommand ChangeColor { get; }

    public ItemButtonViewModel(Item item)
    {
        _item = item;

        ChangeColor = ReactiveCommand.Create(() =>
        {
            _item.ChangeColor();
            this.RaisePropertyChanged(nameof(Color));
        });
    }
}
