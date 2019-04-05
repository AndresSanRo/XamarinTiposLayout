using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TiposLayout.CodeViews
{
	public class Collatz : ContentPage
	{
        int num;
        List<int> steps;
        Entry entryCollatz;
        ScrollView scrollCollatz;
        public Collatz ()
		{
            Random r = new Random();
            StackLayout mainStack = new StackLayout()
            {
                Margin = new Thickness(0, 40, 0, 0)
            };
            Label header = new Label()
            {
                Text = "Collatz",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                FontSize = 40
            };
            mainStack.Children.Add(header);
            ScrollView scrollBtns = new ScrollView()
            {               
                BackgroundColor = Color.Bisque,
                Orientation = ScrollOrientation.Horizontal
            };
            FlexLayout flex = new FlexLayout()
            {
                Direction = FlexDirection.Row              
            };                                  
            for (int i = 0; i < 30; i++)
            {
                Button btnCollatz = new Button()
                {
                    BackgroundColor = Color.OrangeRed,
                    WidthRequest = 50,
                    HeightRequest = 50,
                    TextColor = Color.Black,
                    Text = r.Next(2, 100).ToString()
                };
                btnCollatz.Clicked += BtnCollatz_Clicked;
                flex.Children.Add(btnCollatz);
            }
            scrollBtns.Content = flex;
            mainStack.Children.Add(scrollBtns);
            scrollCollatz = new ScrollView()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.Bisque
            };                        
            mainStack.Children.Add(scrollCollatz);
            this.Content = mainStack;
        }

        private void BtnCollatz_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (int.TryParse(btn.Text, out num) && num > 1)
            {
                steps = new List<int>();
                while (num != 1)
                {
                    if ((num % 2) == 0)
                    {
                        num = num / 2;
                        steps.Add(num);
                    }
                    else
                    {
                        num = (num * 3) + 1;
                        steps.Add(num);
                    }
                }
                StackLayout container = new StackLayout();
                foreach (int s in steps)
                {
                    Label lbl = new Label()
                    {
                        Text = s.ToString(),
                        HorizontalOptions = LayoutOptions.CenterAndExpand
                    };
                    container.Children.Add(lbl);
                }
                scrollCollatz.Content = container;
            }
        }
    }
}