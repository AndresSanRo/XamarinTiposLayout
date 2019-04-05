using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TiposLayout.CodeViews
{
	public class ScrollViewPage : ContentPage
	{
		public ScrollViewPage ()
		{
            StackLayout mainStack = new StackLayout();
            Label header = new Label()
            {
                Text = "Scroll botones",
                HorizontalOptions = LayoutOptions.FillAndExpand,
                TextColor = Color.Blue
            };
            ScrollView scroll = new ScrollView();
            scroll.Orientation = ScrollOrientation.Vertical;
            //Creamos otro stacklayout para meter todos los elementos dentro del scroll
            StackLayout container = new StackLayout();
            container.BackgroundColor = Color.YellowGreen;
            container.VerticalOptions = LayoutOptions.FillAndExpand;
            //Generamos controles dinamicamente sobre el layout
            for (int i = 1; i <= 30; i++)
            {
                Button btn = new Button();
                btn.Text = "Btn " + i.ToString();
                btn.HorizontalOptions = LayoutOptions.CenterAndExpand;
                container.Children.Add(btn);
            }
            //Añadimos los elementos
            mainStack.Children.Add(header);
            scroll.Content = container;
            mainStack.Children.Add(scroll);
            this.Content = mainStack;
		}
	}
}