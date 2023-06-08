using ReactiveUI;

namespace Resol.Picker;

public abstract class ReactiveViewModel : ReactiveObject, IActivatableViewModel
{
    public ViewModelActivator Activator { get; } = new();
}
