using System;
using ReactiveUI;

namespace HexLaunch.ViewModels;

public abstract class ViewPartialBase(IScreen screen) : ViewModelBase, IRoutableViewModel
{
    public string? UrlPathSegment { get; } = Guid.NewGuid().ToString()[..5];
    public IScreen HostScreen     { get; } = screen;
}