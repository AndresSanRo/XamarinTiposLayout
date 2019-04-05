using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposLayout.XamlViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Collatz : ContentPage
	{
        int num;
        List<int> steps;

        public Collatz ()
		{
			InitializeComponent ();
            num = 0;            
            this.btnCollatz.Clicked += BtnCollatz_Clicked;
        }

        private void BtnCollatz_Clicked(object sender, EventArgs e)
        {
            if(int.TryParse(this.entryCollatz.Text, out num) && num > 1)
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
                foreach(int s in steps)
                {
                    Label lbl = new Label()
                    {
                        Text = s.ToString(),
                        HorizontalOptions = LayoutOptions.CenterAndExpand
                    };
                    container.Children.Add(lbl);
                }
                this.scrollCollatz.Content = container;
            }
        }
    }
}