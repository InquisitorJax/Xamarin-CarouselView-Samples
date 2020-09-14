using System;
using System.Collections.Generic;

namespace CarouselViewSamples.Models
{
	public class Item
	{
		public Item()
		{
			SubItems = new List<SubItem>
			{
				new SubItem { Text = "Sub Item 1"},
				new SubItem { Text = "Sub Item 2"},
			};
		}
		public string Id { get; set; }
		public string Text { get; set; }
		public string Description { get; set; }

		public List<SubItem> SubItems{ get; set; }
	}

	public class SubItem
	{
		public string Text { get; set; }
	}

}