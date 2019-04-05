using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TiposLayout.CodeViews
{
	public class FrameView : ContentPage
	{
		public FrameView ()
		{
            StackLayout mainStack = new StackLayout()
            {
                Margin = new Thickness(0, 40, 0, 0)
            };
            Label header = new Label()
            {
                Text = "Frame View",
                TextColor = Color.Red,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            Frame frame = new Frame()
            {
                BorderColor = Color.Fuchsia
            };
            Label lbl = new Label()
            {
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec eu congue magna, ac mattis dolor. Vestibulum tristique metus tellus, a imperdiet dui condimentum vitae. Pellentesque fringilla dolor non ligula efficitur, id gravida magna ornare. Praesent aliquet dictum nisl vel tincidunt. Nam posuere ultrices velit eu viverra. Ut pellentesque nunc non maximus efficitur. Quisque at convallis orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce suscipit ornare pretium. Suspendisse quis pellentesque mi. Phasellus interdum enim sagittis, rutrum dolor at, suscipit lectus. Aenean quis risus non lectus placerat bibendum quis sit amet sapien."
            };
            mainStack.Children.Add(header);
            mainStack.Children.Add(frame);
            frame.Content = lbl;
            this.Content = mainStack;
        }
	}
}