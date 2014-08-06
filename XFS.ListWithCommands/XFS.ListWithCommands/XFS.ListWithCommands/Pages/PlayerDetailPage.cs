using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XFS.ListWithCommands.Models;
using XFS.ListWithCommands.UIComponents;

namespace XFS.ListWithCommands.Pages
{
    public class PlayerDetailPage : ContentPage
    {
        // Trying a non VM view, for if data is always the same as soon as you load the page? 
        // Possible advantages: faster coding, better performance due to no bindingz
        public PlayerDetailPage(Player player)
        {
            LoadPlayer(player);
        }

        private void LoadPlayer(Player player)
        {
            HeaderLabel header = new HeaderLabel(player.Handle);
            Label realNameLabel = new Label { Text = player.Name };
            Label WCSPointsLabel = new Label { Text = string.Format("Points: {0}", 123) };

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children =
                {
                    header, realNameLabel, WCSPointsLabel
                }
            };

        }
    }
}
