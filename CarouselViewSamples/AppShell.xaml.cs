using System;
using System.Collections.Generic;
using CarouselViewSamples.ViewModels;
using CarouselViewSamples.Views;
using Xamarin.Forms;

namespace CarouselViewSamples
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
		}

	}
}
