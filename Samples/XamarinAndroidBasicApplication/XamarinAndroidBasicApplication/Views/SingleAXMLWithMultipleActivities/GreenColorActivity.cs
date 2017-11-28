
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
using Android.Graphics;

namespace XamarinAndroidBasicApplication
{
    [Activity(Label = "GreenColorActivity")]
    public class GreenColorActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SingleAXMLForMultiActivities);

            ImageView backImage = FindViewById<ImageView>(Resource.Id.ColorSetsImageBack);
            backImage.Click += (sender, e) =>
            {
                try
                {
                    Finish();
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                }
            };

            View greenColorView = FindViewById<View>(Resource.Id.ColorSetsView);
            greenColorView.SetBackgroundColor(Color.DarkGreen);


            greenColorView.SetBackgroundColor(Color.Violet);
            greenColorView.SetBackgroundColor(Color.Indigo);
            greenColorView.SetBackgroundColor(Color.Blue);
            greenColorView.SetBackgroundColor(Color.Yellow);
            greenColorView.SetBackgroundColor(Color.Orange);
            greenColorView.SetBackgroundColor(Color.Red);

            TextView greenText = FindViewById<TextView>(Resource.Id.ColorSetsName);
            greenText.Text = "Green Color";

        }
    }
}
