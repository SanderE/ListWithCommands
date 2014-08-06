using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XFS.ListWithCommands.Base;
using XFS.ListWithCommands.Models;

namespace XFS.ListWithCommands.ListItems
{
    public class PlayerListItem: BaseViewModel
    {
        public Player Player { get; private set; }

        public PlayerListItem(Player player)
        {
            Player = player;
            Name = Player.Handle;
            Position = 1;
            WCSPoints = 12;
        }

        public int Position /* One-way data-bindable property generated with propdb1 snippet. Keep on one line - see http://goo.gl/Yg6QMd for why. */ { get { return _Position; } set { if (_Position != value) { _Position = value; RaisePropertyChanged(PROPERTYNAME_Position); } } } private int _Position; public const string PROPERTYNAME_Position = "Position";
        public string Name /* One-way data-bindable property generated with propdb1 snippet. Keep on one line - see http://goo.gl/Yg6QMd for why. */ { get { return _Name; } set { if (_Name != value) { _Name = value; RaisePropertyChanged(PROPERTYNAME_Name); } } } private string _Name; public const string PROPERTYNAME_Name = "Name";
        public int WCSPoints /* One-way data-bindable property generated with propdb1 snippet. Keep on one line - see http://goo.gl/Yg6QMd for why. */ { get { return _WCSPoints; } set { if (_WCSPoints != value) { _WCSPoints = value; RaisePropertyChanged(PROPERTYNAME_WCSPoints); } } } private int _WCSPoints; public const string PROPERTYNAME_WCSPoints = "WCSPoints";


        public Command AddPointsCommand /* Data-bindable command that calls AddPoints(), generated with cmd snippet. Keep on one line - see http://goo.gl/Yg6QMd for why. */ { get { if (_AddPointsCommand == null) _AddPointsCommand = new Command(AddPoints); return _AddPointsCommand; } } private Command _AddPointsCommand; public const string COMMANDNAME_AddPointsCommand = "AddPointsCommand";

        private void AddPoints()
        {
            WCSPoints++;
        }
    }
}
