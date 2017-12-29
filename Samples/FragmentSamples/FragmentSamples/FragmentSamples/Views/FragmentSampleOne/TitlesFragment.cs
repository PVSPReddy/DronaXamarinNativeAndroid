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
    public class TitlesFragment : Android.App.ListFragment
    {
        int currentPlayId;
        bool isTabletPane;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            // Create your fragment here
            var adapter = new ArrayAdapter<string>(Activity, Android.Resource.Layout.SimpleListItemChecked, Shakespear.Titles);
            ListAdapter = adapter;

            if (savedInstanceState != null)
            {
                currentPlayId = savedInstanceState.GetInt("current_play_id", 0);
            }
            var detailsFrame = Activity.FindViewById<View>(Resource.Id.frameLayoutDetailsFragmentOne);
            isTabletPane = detailsFrame != null && detailsFrame.Visibility == ViewStates.Visible;

            if (isTabletPane)
            {
                ListView.ChoiceMode = (Android.Widget.ChoiceMode)(int)ChoiceMode.Single;
                ShowDetails(currentPlayId);
            }
            base.OnActivityCreated(savedInstanceState);
        }

        public override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);
            ShowDetails(position);
        }

        private void ShowDetails(int _currentPlayId)
        {
            try
            {
                if(isTabletPane)
                {
                    // We can display everything in place with fragments.
                    // Have the list highlight this item and show the data.
                    ListView.SetItemChecked(_currentPlayId, true);
                    // Check what fragment is shown, replace if needed.
                    var details = FragmentManager.FindFragmentById(Resource.Id.frameLayoutDetailsFragmentOne) as DetailsFragment;
                    if(details == null || details.shownPlayId != _currentPlayId)
                    {
                        // Make new fragment to show this selection.
                        details = DetailsFragment.NewInstance(_currentPlayId);
                        // Execute a transaction, replacing any existing
                        // fragment with this one inside the frame.
                        var fragmentTransaction = FragmentManager.BeginTransaction();
                        fragmentTransaction.Replace(Resource.Id.frameLayoutDetailsFragmentOne, details);
                        fragmentTransaction.SetTransition(FragmentTransit.FragmentFade);
                        fragmentTransaction.Commit();
                    }
                }
                else
                {
                    // Otherwise we need to launch a new Activity to display
                    // the dialog fragment with selected text.
                    var intent = new Intent();
                    intent.SetClass(Activity, typeof(DetailsActivity));
                    intent.PutExtra("currentPlayId", _currentPlayId);
                    StartActivity(intent);
                }
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
            }
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}
