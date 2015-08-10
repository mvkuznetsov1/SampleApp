using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;

namespace SampleApp.Droid
{
	[Activity(Label = "ActivityImageList")]
	public class ActivityImageList : ListActivity
	{
		protected override void OnCreate (Bundle bundle)
		{	
			base.OnCreate(bundle);
			var items = new List<Tuple<string, int>>();
			items.Add(new Tuple<string, int>("Lorem ipsum dolor sit amet quam", Resource.Drawable.p2));
			items.Add(new Tuple<string, int>("Consectetuer adipiscing elit Aenean massa", Resource.Drawable.p3));
			items.Add(new Tuple<string, int>("Aenean commodo ligula eget dolor.", Resource.Drawable.p4));
			items.Add(new Tuple<string, int>("Cum sociis natoque penatibus et magnis dis parturient montes", Resource.Drawable.p5));
			items.Add(new Tuple<string, int>("Nascetur ridiculus mus. Donec quam felis", Resource.Drawable.p6));
			items.Add(new Tuple<string, int>("Ultricies nec, pellentesque eu, pretium quis", Resource.Drawable.p7));
			/*items.Add(new Tuple<string, int>("Sem. Nulla consequat massa quis enim. Donec pede", Resource.Drawable.p8));
			items.Add(new Tuple<string, int>("Justo, fringilla vel, aliquet nec, vulputate eget", Resource.Drawable.p9));
			items.Add(new Tuple<string, int>("Arcu. In enim justo, rhoncus ut, imperdiet a", Resource.Drawable.p10));
			items.Add(new Tuple<string, int>("Venenatis vitae, justo. Nullam dictum felis", Resource.Drawable.p11));
			items.Add(new Tuple<string, int>("Eu pede mollis pretium. Integer", Resource.Drawable.p12));
			items.Add(new Tuple<string, int>("Tincidunt. Cras dapibus. Vivamus elementum", Resource.Drawable.p13));
			items.Add(new Tuple<string, int>("Semper nisi. Aenean vulputate", Resource.Drawable.p14));
*/
			this.ListAdapter = new ImageListAdapter(this, items);
		}
	}
}

