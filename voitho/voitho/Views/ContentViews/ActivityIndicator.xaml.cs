﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace voitho.Views.ContentViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ActivityIndicator : ContentView
	{
		public ActivityIndicator ()
		{
			InitializeComponent ();
		}
	}
}