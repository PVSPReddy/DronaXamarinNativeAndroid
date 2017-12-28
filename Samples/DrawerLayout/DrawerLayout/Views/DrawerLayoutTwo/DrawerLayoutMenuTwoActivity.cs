
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
//using Android.Support.Compat;
using SupportV7ToolBar = Android.Support.V7.Widget;
using SupportV4DrawerLayout = Android.Support.V4.Widget;
using SupportDesign = Android.Support.Design.Widget;
using Android.Support.V7.App;
//using Android.Support;

namespace DrawerLayout.Views.DrawerLayoutTwo
{
    [Activity(Label = "DrawerLayoutMenuTwoActivity", Theme = "@style/MenuTwoTheme")]
    public class DrawerLayoutMenuTwoActivity : Android.Support.V7.App.AppCompatActivity//Activity
    {
        SupportV4DrawerLayout.DrawerLayout drawerLayout;
        SupportDesign.NavigationView navigationView;
        //SupportV7ToolBar.Toolbar toolbar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.DrawerLayoutMenuTwoAXML);
            drawerLayout = FindViewById<SupportV4DrawerLayout.DrawerLayout>(Resource.Id.MenuTwoDrawerLayout);

            var toolbar = FindViewById<SupportV7ToolBar.Toolbar>(Resource.Id.MenuTwoToolBar);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetDisplayShowTitleEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetHomeAsUpIndicator(Resource.Mipmap.HamBurgerWhite);

            var drawerToggle = new ActionBarDrawerToggle(this, drawerLayout, toolbar, Resource.String.menu_two_drawer_open, Resource.String.menu_two_drawer_close);
            drawerLayout.SetDrawerListener(drawerToggle);
            drawerToggle.SyncState();

            navigationView = FindViewById<SupportDesign.NavigationView>(Resource.Id.MenuTowNavigationView);
            SetupDrawerContent(navigationView);

        }

        void SetupDrawerContent(SupportDesign.NavigationView _navigationView)
        {
            try
            {
                _navigationView.NavigationItemSelected += (object sender, SupportDesign.NavigationView.NavigationItemSelectedEventArgs e) =>
                {
                    e.MenuItem.SetChecked(true);
                    drawerLayout.CloseDrawers();
                };
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            try
            {
                navigationView.InflateMenu(Resource.Menu.menutwo);
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
            }
            return true;
            //return base.OnCreateOptionsMenu(menu);
        }
    }
}
