
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
//using Android.Support;


namespace DrawerLayout.Views.DrawerLayoutOne
{
    [Activity(Label = "DrawerLayoutMenuOneActivity")]
    public class DrawerLayoutMenuOneActivity : Android.Support.V7.App.AppCompatActivity//Activity//AppCompactActivity
    {
        protected SupportV4DrawerLayout.DrawerLayout drawerLayout;
        protected SupportDesign.NavigationView navigationView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Id.DrawerLayoutMenuOne);
            drawerLayout = FindViewById<SupportV4DrawerLayout.DrawerLayout>(Resource.Id.DrawerLayoutMenuOne);
            navigationView = FindViewById<SupportDesign.NavigationView>(Resource.Id.DrawerLayoutMenuOneNavigationView);
            var toolBar = FindViewById<SupportV7ToolBar.Toolbar>(Resource.Id.DrawerLayoutMenuOneToolBar);

            SetSupportActionBar(toolBar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetDisplayShowTitleEnabled(false);
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetHomeAsUpIndicator(Resource.Mipmap.HamBurgerWhite);



            //SetSupportActionBar(toolbar);  
            //SupportActionBar.SetDisplayHomeAsUpEnabled(true);  
            //SupportActionBar.SetDisplayShowTitleEnabled(false);  
            //SupportActionBar.SetHomeButtonEnabled(true);  
            //SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_menu); 

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
