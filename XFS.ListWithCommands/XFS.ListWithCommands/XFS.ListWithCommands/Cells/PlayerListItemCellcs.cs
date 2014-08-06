using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XFS.ListWithCommands.ListItems;

namespace XFS.ListWithCommands.Cells
{
    public class PlayerListItemCell: ViewCell
    {
        public PlayerListItemCell()
        {
            LoadPlayerListItemCell();
        }

        private void LoadPlayerListItemCell()
        {
            Label positionLabel = new Label();
            positionLabel.SetBinding(Label.TextProperty, PlayerListItem.PROPERTYNAME_Position);
            positionLabel.HorizontalOptions = LayoutOptions.Start;

            Label nameLabel = new Label();
            nameLabel.SetBinding(Label.TextProperty, PlayerListItem.PROPERTYNAME_Name);
            nameLabel.HorizontalOptions = LayoutOptions.Start;

            Label pointsLabel = new Label();
            pointsLabel.SetBinding(Label.TextProperty, PlayerListItem.PROPERTYNAME_WCSPoints);
            pointsLabel.HorizontalOptions = LayoutOptions.EndAndExpand;

            Button increasePointsButton = new Button { Text = "Points++" };
            increasePointsButton.SetBinding(Button.CommandProperty, PlayerListItem.COMMANDNAME_AddPointsCommand);

            StackLayout stack = new StackLayout { 
                Orientation = StackOrientation.Horizontal,
                Padding = new Thickness(50, 0),
                Children =
                {
                    positionLabel, nameLabel, pointsLabel
                }
            };

            View = new StackLayout { 
                Orientation = StackOrientation.Vertical,
                Padding = new Thickness(30, 5),
                Children = { stack, increasePointsButton }
            };
        }
    }
}
