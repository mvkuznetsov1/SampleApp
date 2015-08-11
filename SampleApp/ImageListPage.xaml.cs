using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace SampleApp
{
	public partial class ImageListPage : ContentPage
	{
		public ObservableCollection<ImageListViewModel> items { get; set; }
		public ImageListPage ()
		{

			items = new ObservableCollection<ImageListViewModel> ();
			InitializeComponent ();
			lstView.ItemsSource = items;
			items.Add (new ImageListViewModel{ Text="Lorem ipsum dolor sit amet quam", Image="p2.jpg"});
			items.Add (new ImageListViewModel{ Text="Consectetuer adipiscing elit Aenean massa", Image="p3.jpg"});
			items.Add (new ImageListViewModel{ Text="Aenean commodo ligula eget dolor.", Image="p2.jpg"});
			items.Add (new ImageListViewModel{ Text="Cum sociis natoque penatibus et magnis dis parturient montes", Image="p3.jpg"});
			items.Add (new ImageListViewModel{ Text="Nascetur ridiculus mus. Donec quam felis", Image="p4.jpg"});
			items.Add (new ImageListViewModel{ Text="Ultricies nec, pellentesque eu, pretium quis", Image="p5.jpg"});

		}
	}
}

