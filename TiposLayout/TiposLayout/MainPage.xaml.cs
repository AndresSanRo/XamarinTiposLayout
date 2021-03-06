﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposLayout.XamlViews;
using TiposLayout.CodeViews;
using Xamarin.Forms;

namespace TiposLayout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.btnStack.Clicked += async (sender, args) => 
                await Navigation.PushAsync(new CodeViews.StackLayoutView());
            this.btnFrame.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new CodeViews.FrameView());
            this.btnScroll.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new CodeViews.ScrollViewPage());
            this.btnFlex.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new CodeViews.FlexLayoutView());
            this.btnAbsolute.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new AbsoluteLayoutView());
            this.btnCollatz.Clicked += async (sender, args) =>
                await Navigation.PushAsync(new CodeViews.Collatz());
        }
    }
}
