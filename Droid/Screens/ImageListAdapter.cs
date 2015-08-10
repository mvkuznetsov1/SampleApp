using System;
using Android.App;
using System.Collections.Generic;
using Android.Views;
using Android.Widget;

namespace SampleApp.Droid
{
	public class ImageListAdapter  : ArrayAdapter <Tuple<string,int>> 
	{
		Activity context;

		public ImageListAdapter(Activity context, IList<Tuple<string, int>> objects)
			: base(context, Android.Resource.Id.Text1, objects)
		{
			this.context = context;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var view = this.context.LayoutInflater.Inflate(Android.Resource.Layout.ActivityListItem, null);
			var item = GetItem(position);

			view.FindViewById<TextView> (Android.Resource.Id.Text1).Text = item.Item1;
			view.FindViewById<ImageView>(Android.Resource.Id.Icon).SetImageResource(item.Item2);

			return view;
		}
	}
}

