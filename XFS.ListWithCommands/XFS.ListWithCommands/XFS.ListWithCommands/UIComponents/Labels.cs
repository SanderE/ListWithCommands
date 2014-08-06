using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XFS.ListWithCommands.UIComponents
{
    public class HeaderLabel : Label
    {
        public HeaderLabel(string text)
        {
            Text = text;
            Font = Font.BoldSystemFontOfSize(50);
            HorizontalOptions = LayoutOptions.Center;
        }
    }
}
