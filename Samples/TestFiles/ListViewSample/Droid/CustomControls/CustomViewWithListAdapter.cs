
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListViewSample.Droid
{
    public class CustomViewWithListAdapter : BaseAdapter<RewardDetails>
    {
        /*
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
        */

        List<RewardDetails> items;
        Activity context;
        public CustomViewWithListAdapter(Activity context, List<RewardDetails> items) : base()
        {
            this.context = context;
            this.items = items;
        }

        public override RewardDetails this[int position]
        {
            get 
            { 
                return items[position]; 
            }
        }

        public override int Count
        {
            get 
            {
                return items.Count; 
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];
            View view = convertView;
            try
            {
                if (view == null) // no view to re-use, create new
                {
                    view = context.LayoutInflater.Inflate(Resource.Layout.listviewcellmodel, null);
                }
                view.FindViewById<TextView>(Resource.Id.ShopTitle).Text = item.Title;
                view.FindViewById<TextView>(Resource.Id.ShopAddress).Text = item.Address;
                view.FindViewById<TextView>(Resource.Id.ShopDistance).Text = item.DistanceFromShop;
                //view.FindViewById<ImageView>(Resource.Id.ShopLogo).SetImageURI();
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
            }
            return view;
        }
    }
}
