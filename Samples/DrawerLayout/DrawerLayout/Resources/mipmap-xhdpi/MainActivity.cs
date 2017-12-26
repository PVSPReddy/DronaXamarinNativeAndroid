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
//using Android.Support;

namespace DrawerLayout
{
    [Activity(Label = "DrawerLayout",Theme = "@style/MyTheme", MainLauncher = true)]
    public class MainActivity : Android.Support.V7.App.AppCompatActivity//Activity
    {
        protected SupportV4DrawerLayout.DrawerLayout drawerLayout;
        protected SupportDesign.NavigationView navigationView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ///////Set our view from the "main" layout resource
            ////SetContentView(Resource.Layout.Main);
            //var singleScreenIntent = new Intent(this, typeof(DrawerLayoutMenuOneActivity));
            //StartActivity(singleScreenIntent);
            try
            {
                SetContentView(Resource.Layout.DrawerLayoutMenuOneAXML);
                drawerLayout = FindViewById<SupportV4DrawerLayout.DrawerLayout>(Resource.Id.DrawerLayoutMenuOne);
                navigationView = FindViewById<SupportDesign.NavigationView>(Resource.Id.DrawerLayoutMenuOneNavigationView);
                var toolBar = FindViewById<SupportV7ToolBar.Toolbar>(Resource.Id.DrawerLayoutMenuOneToolBar);

                SetSupportActionBar(toolBar);
                SupportActionBar.SetDisplayHomeAsUpEnabled(true);
                SupportActionBar.SetDisplayShowTitleEnabled(false);
                SupportActionBar.SetHomeButtonEnabled(true);
                SupportActionBar.SetHomeAsUpIndicator(Resource.Mipmap.HamBurgerWhite);
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
                System.Console.Write(ex.StackTrace);
            }

        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            //return base.OnOptionsItemSelected(item);
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    drawerLayout.OpenDrawer(Android.Support.V4.View.GravityCompat.Start);
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}

