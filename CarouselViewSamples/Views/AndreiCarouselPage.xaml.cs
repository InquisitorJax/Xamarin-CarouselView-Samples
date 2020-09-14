using CarouselViewSamples.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselViewSamples.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AndreiCarouselPage : ContentPage
	{
		CarouselViewModel _viewModel;

		public AndreiCarouselPage()
		{
			InitializeComponent();

			BindingContext = _viewModel = new CarouselViewModel();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			await _viewModel.LoadItemsAsync();
		}

	}
}