using System;
using GameLibraryUI.ViewModels;
using GameLibraryUI.Views.Partials;
using ReactiveUI;

namespace GameLibraryUI;

public class AppViewLocator : IViewLocator
{
    public IViewFor ResolveView<T>(T? viewModel, string? contract = null)
        => viewModel switch
           {
               HomeViewModel context => new HomeView { DataContext = context },
               _                     => throw new ArgumentOutOfRangeException(nameof(viewModel))
           };
}