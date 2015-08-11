using System;
using System.ComponentModel;

namespace SampleApp
{
	public class ImageListViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;	

		public string Text { get; set; }
		public string Image { get; set; }
		public ImageListViewModel ()
		{
		}
	}
}

