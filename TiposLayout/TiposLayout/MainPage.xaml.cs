﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposLayout.XamlViews;
using Xamarin.Forms;

namespace TiposLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.btnStack.Clicked += async (sender, args) => 
                await Navigation.PushAsync(new StackLayoutView());
            this.btnFrame.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new FrameView());
            this.btnScroll.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new XamlViews.ScrollView());
            this.btnFlex.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new FlexLayoutView());
            this.btnAbsolute.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new AbsoluteLayoutView());
        }
    }
}
