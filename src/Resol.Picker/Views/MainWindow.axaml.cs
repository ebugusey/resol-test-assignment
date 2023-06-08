using System.Reactive.Disposables;
using Avalonia.ReactiveUI;
using ReactiveUI;
using Resol.Picker.Components;

namespace Resol.Picker.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            this.OneWayBind<MainWindowViewModel, MainWindow, PicklistViewModel, PicklistViewModel?>(ViewModel!,
                    viewModel => viewModel.Items,
                    view => view.Picklist.ViewModel)
                .DisposeWith(disposables);
        });
    }
}
