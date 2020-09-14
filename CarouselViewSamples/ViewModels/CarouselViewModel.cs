using CarouselViewSamples.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselViewSamples.ViewModels
{
	public class CarouselViewModel : BaseViewModel
	{
		public ObservableCollection<Item> Items { get; }
		public Command LoadItemsCommand { get; }


		public CarouselViewModel()
		{
			Items = new ObservableCollection<Item>();
			LoadItemsCommand = new Command(async () => await LoadItemsAsync());
		}


		public async Task LoadItemsAsync()
		{
			IsBusy = true;

			try
			{
				Items.Clear();
				var items = await DataStore.GetItemsAsync(true);
				foreach (var item in items)
				{
					Items.Add(item);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
			finally
			{
				IsBusy = false;
			}
		}
	}
}
