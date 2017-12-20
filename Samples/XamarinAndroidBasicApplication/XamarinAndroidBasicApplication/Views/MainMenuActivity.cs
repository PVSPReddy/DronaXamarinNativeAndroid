
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

namespace XamarinAndroidBasicApplication
{
    [Activity(Label = "MainMenuActivity")]
    public class MainMenuActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MainMenuActivityAXML);

            TextView singlePageScreen = FindViewById<TextView>(Resource.Id.MenuBasicSinglePageScreen);
            singlePageScreen.Click += SinglePageButtonClicked;

            TextView multiPageScreen = FindViewById<TextView>(Resource.Id.MenuBasicMultiPageScreen);
            multiPageScreen.Click += MultiPageButtonClicked;

            TextView SingleAXMLMultiScreens = FindViewById<TextView>(Resource.Id.SingleAXMLFromMultipleActivites);
            SingleAXMLMultiScreens.Click += SingleAXMLMultiScreensClicked;
        }

        #region for single page Button Click event
        void SinglePageButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var singleScreenIntent = new Intent(this, typeof(BasicSingleScreenActivity));
                StartActivity(singleScreenIntent);
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
        #endregion

        #region for multi page Button Click event
        void MultiPageButtonClicked(object sender, EventArgs e)
        {
            try
            {
                //var multiScreenIntent = new Intent(this, typeof(BasicMultiScreenActivity));
                //StartActivity(multiScreenIntent);
                StartActivity(typeof(BasicMultiScreenActivity));
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
        #endregion

        #region for Single AXML for Multi Screen Button Click event
        void SingleAXMLMultiScreensClicked(object sender, EventArgs e)
        {
            try
            {
                var SingleAXMLMultiScreenIntent = new Intent(this, typeof(VioletColorActivity));
                StartActivity(SingleAXMLMultiScreenIntent);
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
        #endregion






    }
}
