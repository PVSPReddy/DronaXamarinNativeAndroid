
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace FragmentSamples.Views.FragmentSampleOne
{
    public class DetailsFragment : Fragment
    {
        public int shownPlayId
        {
            get 
            { 
                return Arguments.GetInt("_currentPlayId", 0);
            }
        }

        public static DetailsFragment NewInstance(int playId)
        {
            var detailsFragment = new DetailsFragment { Arguments = new Bundle() };
            try
            {
                detailsFragment.Arguments.PutInt("_currentPlayId", playId);
            }
            catch(Exception ex)
            {
                
            }
            return detailsFragment;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            if(container == null)
            {
                // Currently in a layout without a container, so no reason to create our view.
                return null;
            }

            var scroller = new ScrollView(Activity);
            var text = new TextView(Activity);
            var padding = Convert.ToInt32(TypedValue.ApplyDimension(ComplexUnitType.Dip, 4, Activity.Resources.DisplayMetrics));
            text.SetPadding(padding, padding, padding,   padding);
            text.TextSize = 24;
            text.Text = Shakespear.Dialogue[shownPlayId];
            scroller.AddView(text);
            return scroller;


            //return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}
