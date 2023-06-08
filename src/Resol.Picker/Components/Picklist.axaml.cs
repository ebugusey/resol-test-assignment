using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ReactiveUI;
using Resol.Picker.Models;

namespace Resol.Picker.Components;

public partial class Picklist : ReactiveUserControl<PicklistViewModel>
{
    public Picklist()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.OneWayBind<PicklistViewModel, Picklist, IEnumerable<ItemButtonViewModel>, IEnumerable>(ViewModel!,
                    viewModel => viewModel.Items,
                    view => view.ItemsList.Items)
                .DisposeWith(disposables);

            this.BindCommand<Picklist, PicklistViewModel, ICommand, Button>(ViewModel!,
                    viewModel => viewModel.AddItem,
                    view => view.AddItemButton)
                .DisposeWith(disposables);
            this.BindCommand<Picklist, PicklistViewModel, ICommand, Button>(ViewModel!,
                    viewModel => viewModel.RemoveItem,
                    view => view.RemoveItemButton)
                .DisposeWith(disposables);
        });
    }
}

public class PicklistViewModel : ReactiveViewModel
{
    private readonly Items _items;
    public IEnumerable<ItemButtonViewModel> Items => _items
        .Select(x => new ItemButtonViewModel(x));

    public ICommand AddItem { get; }
    public ICommand RemoveItem { get; }

    public PicklistViewModel(Items items)
    {
        _items = items;

        AddItem = ReactiveCommand.Create(() =>
        {
            _items.Add();
            this.RaisePropertyChanged(nameof(Items));
        });
        RemoveItem = ReactiveCommand.Create(() =>
        {
            _items.Remove();
            this.RaisePropertyChanged(nameof(Items));
        });
    }
}
