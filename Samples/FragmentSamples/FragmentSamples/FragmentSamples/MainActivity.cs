using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using FragmentSamples.Views.FragmentSampleOne;

namespace FragmentSamples
{
    [Activity(Label = "FragmentSamples", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);

            var intent = new Intent(this, typeof(FragmentSampleOneActivity));
            StartActivity(intent);
        }
    }
}

