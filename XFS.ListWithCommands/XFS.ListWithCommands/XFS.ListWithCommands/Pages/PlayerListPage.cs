using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XFS.ListWithCommands.Cells;
using XFS.ListWithCommands.ViewModels;

namespace XFS.ListWithCommands.Pages
{
    public class PlayerListPage : ContentPage
    {
        public PlayerListViewModel ViewModel { get; private set; }
        public PlayerListPage(PlayerListViewModel vm)
        {
            vm.Navigation = Navigation;
            BindingContext = ViewModel = vm;
            LoadPlayerList();
        }

        private void LoadPlayerList()
        {
            this.Title = ViewModel.Title;
            ListView ranking = new ListView();
            ranking.ItemTemplate = new DataTemplate(typeof(PlayerListItemCell));
            ranking.SetBinding(ListView.ItemsSourceProperty, PlayerListViewModel.PROPERTYNAME_Players);

            ranking.ItemTapped += (sender, e) => { ViewModel.PlayerSelectedCommand.Execute(e.Item); };
            ranking.RowHeight = 100;
            Content = ranking;
        }
    }
}
