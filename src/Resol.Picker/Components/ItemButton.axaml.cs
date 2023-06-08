using System.Reactive.Disposables;
using System.Windows.Input;
using Avalonia.Media;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace Resol.Picker.Components;

public partial class ItemButton : ReactiveUserControl<ItemButtonViewModel>
{
    public ItemButton()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.OneWayBind<ItemButtonViewModel, ItemButton, string, IBrush>(ViewModel!,
                    viewModel => viewModel.Color,
                    view => view.Button.Background)
                .DisposeWith(disposables);

            this.BindCommand<ItemButton, ItemButtonViewModel, ICommand, TapScrollableButton>(ViewModel!,
                    viewModel => viewModel.ChangeColor,
                    view => view.Button)
                .DisposeWith(disposables);
        });
    }
}
