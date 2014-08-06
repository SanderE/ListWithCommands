using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XFS.ListWithCommands.Base;
using XFS.ListWithCommands.ListItems;
using XFS.ListWithCommands.Models;
using XFS.ListWithCommands.Pages;

namespace XFS.ListWithCommands.ViewModels
{
    public class PlayerListViewModel : BaseViewModel
    {
        public PlayerListViewModel()
        {
            Title = "Rankings";
            Players = new List<PlayerListItem>() { new PlayerListItem(new Player(1) { Handle = "Player1", Name = "RealNamePlayer1" }),
                new PlayerListItem(new Player(1) { Handle = "Player2", Name = "RealNamePlayer2" }),
                new PlayerListItem(new Player(1) { Handle = "Player3", Name = "RealNamePlayer3" }),
                new PlayerListItem(new Player(1) { Handle = "Player4", Name = "RealNamePlayer4" }),
                new PlayerListItem(new Player(1) { Handle = "Player5", Name = "RealNamePlayer5" }),
                new PlayerListItem(new Player(1) { Handle = "Player6", Name = "RealNamePlayer6" }),
                new PlayerListItem(new Player(1) { Handle = "Player7", Name = "RealNamePlayer7" }),
                new PlayerListItem(new Player(1) { Handle = "Player8", Name = "RealNamePlayer8" }),
                new PlayerListItem(new Player(1) { Handle = "Player9", Name = "RealNamePlayer9" }),
                new PlayerListItem(new Player(1) { Handle = "Player10", Name = "RealNamePlayer10" }),
                new PlayerListItem(new Player(1) { Handle = "Player11", Name = "RealNamePlayer11" }),
                new PlayerListItem(new Player(1) { Handle = "Player12", Name = "RealNamePlayer12" })};
        }

        public string Title /* One-way data-bindable property generated with propdb1 snippet. Keep on one line - see http://goo.gl/Yg6QMd for why. */ { get { return _Title; } set { if (_Title != value) { _Title = value; RaisePropertyChanged(PROPERTYNAME_Title); } } } private string _Title; public const string PROPERTYNAME_Title = "Title";

        public List<PlayerListItem> Players /* One-way data-bindable property generated with propdb1 snippet. Keep on one line - see http://goo.gl/Yg6QMd for why. */ { get { return _Players; } set { if (_Players != value) { _Players = value; RaisePropertyChanged(PROPERTYNAME_Players); } } } private List<PlayerListItem> _Players; public const string PROPERTYNAME_Players = "Players";

        public Command PlayerSelectedCommand /* Data-bindable command with parameter that calls PlayerSelected(), generated with cmdp snippet. Keep on one line - see http://goo.gl/Yg6QMd for why. */ { get { if (_PlayerSelectedCommand == null) _PlayerSelectedCommand = new Command(PlayerSelected); return _PlayerSelectedCommand; } } private Command _PlayerSelectedCommand; public const string COMMANDNAME_PlayerSelectedCommand = "PlayerSelectedCommand";

        private void PlayerSelected(object parameter)
        {
            PlayerListItem player = (PlayerListItem)parameter;
            Navigation.PushAsync(App.GetPlayerDetailPage(player.Player));
        }
    }
}
