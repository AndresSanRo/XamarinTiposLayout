﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposLayout.XamlViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FrameView : ContentPage
	{
		public FrameView ()
		{
			InitializeComponent ();
		}
	}
}