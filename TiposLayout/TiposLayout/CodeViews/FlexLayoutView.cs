using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TiposLayout.CodeViews
{
	public class FlexLayoutView : ContentPage
	{
        public FlexLayoutView()
        {
            StackLayout mainStack = new StackLayout();
            mainStack.Margin = new Thickness(0, 40, 0, 0);
            Label header = new Label()
            {
                Text = "Flex",
                FontSize = 40,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            FlexLayout flex = new FlexLayout()
            {
                AlignItems = FlexAlignItems.Center,
                Direction = FlexDirection.Column,
                JustifyContent = FlexJustify.Start
            };
            StackLayout container = new StackLayout();
            Label lbl = new Label();
            lbl.Text = "Control 1 en flex";
            Button btn = new Button();
            btn.Text = "Boton nuevo";
            Image img = new Image()
            {
                Source = "https://pbs.twimg.com/media/CrmcAkBW8AA-gTX.jpg",
                WidthRequest = 200,
                HeightRequest = 200
            };
            Entry entry = new Entry();
            entry.Text = "Caja de texto";
            container.Children.Add(lbl);
            container.Children.Add(btn);
            container.Children.Add(img);
            container.Children.Add(entry);
            flex.Children.Add(container);
            mainStack.Children.Add(header);
            mainStack.Children.Add(flex);
            this.Content = mainStack;            
        }
	}
}