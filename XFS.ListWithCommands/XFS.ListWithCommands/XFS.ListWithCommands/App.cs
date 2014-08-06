using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XFS.ListWithCommands.ViewModels;
using XFS.ListWithCommands.Pages;
using XFS.ListWithCommands.Models;

namespace XFS.ListWithCommands
{
	public class App
	{
		public static Page GetMainPage()
		{
            return new NavigationPage(new PlayerListPage(new PlayerListViewModel()));
		}

        public static Page GetPlayerDetailPage(Player player)
        {
            return new PlayerDetailPage(player);
        }
	}
}
