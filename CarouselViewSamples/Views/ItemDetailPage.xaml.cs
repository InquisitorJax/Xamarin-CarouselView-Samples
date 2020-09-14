using System.ComponentModel;
using Xamarin.Forms;
using CarouselViewSamples.ViewModels;

namespace CarouselViewSamples.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}
	}
}