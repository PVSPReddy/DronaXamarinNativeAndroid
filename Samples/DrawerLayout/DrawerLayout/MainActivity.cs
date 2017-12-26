using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

//using Android.Support.Compat;
using SupportV7ToolBar = Android.Support.V7.Widget;
using SupportV4DrawerLayout = Android.Support.V4.Widget;
using SupportDesign = Android.Support.Design.Widget;
using Android.Views;
using System;
using DrawerLayout.Views.DrawerLayoutOne;
//using Android.Support;

namespace DrawerLayout
{
    [Activity(Label = "DrawerLayout", MainLauncher = true)]
    public class MainActivity : Activity
    {
        //protected SupportV4DrawerLayout.DrawerLayout drawerLayout;
        //protected SupportDesign.NavigationView navigationView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            try
            {
                var drawerIntent = new Intent(this, typeof(DrawerLayoutMenuOneActivity));
                StartActivity(drawerIntent);
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }
}

