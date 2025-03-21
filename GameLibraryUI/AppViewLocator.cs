using System;
using GameLibraryUI.Models;
using GameLibraryUI.ViewModels;
using GameLibraryUI.Views.Partials;
using ReactiveUI;

namespace GameLibraryUI;

public class AppViewLocator : IViewLocator
{
    public IViewFor ResolveView<T>(T? viewModel, string? contract = null)
        => viewModel switch
           {
               HomeViewModel context    => new HomeView { DataContext    = context },
               LibraryViewModel context => new LibraryView { DataContext = context },
               LibraryViewTypeModel { ViewType: LibraryViewType.Grid } context => new LibraryGridView
                                                                                  { DataContext = context },
               LibraryViewTypeModel { ViewType: LibraryViewType.List } context => new LibraryListView
                                                                                  { DataContext = context },
               GameViewModel context => new GameView { DataContext = context },
               _                     => throw new ArgumentOutOfRangeException(nameof(viewModel))
           };
}