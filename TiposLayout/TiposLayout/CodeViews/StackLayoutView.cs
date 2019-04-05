using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TiposLayout.CodeViews
{
	public class StackLayoutView : ContentPage
	{
		public StackLayoutView ()
		{
            StackLayout mainStack = new StackLayout();
            mainStack.Margin = new Thickness(0, 40, 0, 0);
            Label hearder = new Label()
            {
                FontSize = 40,
                TextColor = Color.OrangeRed,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Text = "Labelaso"
            };            
            Button btn = new Button()
            {
                HorizontalOptions = LayoutOptions.Start,
                BorderWidth = 2,
                BorderColor = Color.Red,
                Text = "Botonaso"
            };
            Image img = new Image()
            {
                Source = "https://a.wattpad.com/cover/83694295-288-k169785.jpg",
                WidthRequest = 200,
                HeightRequest = 200
            };
            mainStack.Children.Add(hearder);
            mainStack.Children.Add(btn);
            mainStack.Children.Add(img);
            //Indicamos el contenido de la clase contentpage
            this.Content = mainStack;
        }
	}
}