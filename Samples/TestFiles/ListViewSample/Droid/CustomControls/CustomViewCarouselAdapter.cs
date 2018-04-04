using System;
using System.Collections.Generic;
using Android.App;
using Android.Support.V4.View;
using A = Android.Views;
using Xamarin.Forms;
using Java.Lang;
using Android.Widget;
using Android.Runtime;
using Android.Views;

namespace ListViewSample.Droid
{
    public class CustomViewCarouselAdapter : PagerAdapter
    {
        List<ViewValue> items;
        Activity context;
        List<RewardDetails> rewardsData;

        public CustomViewCarouselAdapter(Activity context, List<ViewValue> items)
        {
            this.items = items;
            this.context = context;
            #region for populating data 
            rewardsData = new List<RewardDetails>()
            {
                new RewardDetails()
                {
                    Title="Tropical Smoothie Cafe",
                    Address="13000 Folsom Blvd, Folsom, CA 95630. USA",
                    Offer="Enjoy ONE Potion of our Delicious Sliders / Sandwiches",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="POINTS",
                    OfferValue="200"
                },
                new RewardDetails()
                {
                    Title="Keva Smoothie - Devanation Dezavala",
                    Address="13000 Folsom Blvd, Folsom, CA 95630. USA",
                    Offer="Order For Rs 300  And Get A Sandwich Free",
                    ValidTill="Valid until 29/05/2017",
                    IsOffer1Null = true,
                    IsOffer2Null = false,
                    OfferType="",
                    OfferValue=""
                },
                new RewardDetails()
                {
                    Title="Marco Moderen Cafe",
                    Address="Lot G146, Ground Floor (Old Wing), 1Utamas",
                    Offer="Monsoon Top Up Sale: Get Upto 5% OFF",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="OFFER",
                    OfferValue="5%"
                },
                new RewardDetails()
                {
                    Title="Keva Smoothie - Devanation Dezavala",
                    Address="13000 Folsom Blvd, Folsom, CA 95630. USA",
                    Offer="Enjoy ONE Potion of our Delicious Sliders / Sandwiches",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="POINTS",
                    OfferValue="200"
                },
                new RewardDetails()
                {
                    Title="Marco Moderen Cafe",
                    Address="Lot G146, Ground Floor (Old Wing), 1Utamas",
                    Offer="Monsoon Top Up Sale: Get Upto 5% OFF",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="OFFER",
                    OfferValue="5%"
                },
                new RewardDetails()
                {
                    Title="Keva Smoothie - Devanation Dezavala",
                    Address="13000 Folsom Blvd, Folsom, CA 95630. USA",
                    Offer="Enjoy ONE Potion of our Delicious Sliders / Sandwiches",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="POINTS",
                    OfferValue="200"
                },
                new RewardDetails()
                {
                    Title="Marco Moderen Cafe",
                    Address="Lot G146, Ground Floor (Old Wing), 1Utamas",
                    Offer="Monsoon Top Up Sale: Get Upto 5% OFF",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="OFFER",
                    OfferValue="5%"
                },
                new RewardDetails()
                {
                    Title="Keva Smoothie - Devanation Dezavala",
                    Address="13000 Folsom Blvd, Folsom, CA 95630. USA",
                    Offer="Enjoy ONE Potion of our Delicious Sliders / Sandwiches",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="POINTS",
                    OfferValue="200"
                },
                new RewardDetails()
                {
                    Title="Marco Moderen Cafe",
                    Address="Lot G146, Ground Floor (Old Wing), 1Utamas",
                    Offer="Monsoon Top Up Sale: Get Upto 5% OFF",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="OFFER",
                    OfferValue="5%"
                },
                new RewardDetails()
                {
                    Title="Keva Smoothie - Devanation Dezavala",
                    Address="13000 Folsom Blvd, Folsom, CA 95630. USA",
                    Offer="Enjoy ONE Potion of our Delicious Sliders / Sandwiches",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="POINTS",
                    OfferValue="200"
                },
                new RewardDetails()
                {
                    Title="Marco Moderen Cafe",
                    Address="Lot G146, Ground Floor (Old Wing), 1Utamas",
                    Offer="Monsoon Top Up Sale: Get Upto 5% OFF",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="OFFER",
                    OfferValue="5%"
                },
                new RewardDetails()
                {
                    Title="Keva Smoothie - Devanation Dezavala",
                    Address="13000 Folsom Blvd, Folsom, CA 95630. USA",
                    Offer="Enjoy ONE Potion of our Delicious Sliders / Sandwiches",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="POINTS",
                    OfferValue="200"
                },
                new RewardDetails()
                {
                    Title="Marco Moderen Cafe",
                    Address="Lot G146, Ground Floor (Old Wing), 1Utamas",
                    Offer="Monsoon Top Up Sale: Get Upto 5% OFF",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="OFFER",
                    OfferValue="5%"
                },
                new RewardDetails()
                {
                    Title="Keva Smoothie - Devanation Dezavala",
                    Address="13000 Folsom Blvd, Folsom, CA 95630. USA",
                    Offer="Enjoy ONE Potion of our Delicious Sliders / Sandwiches",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="POINTS",
                    OfferValue="200"
                },
                new RewardDetails()
                {
                    Title="Marco Moderen Cafe",
                    Address="Lot G146, Ground Floor (Old Wing), 1Utamas",
                    Offer="Monsoon Top Up Sale: Get Upto 5% OFF",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="OFFER",
                    OfferValue="5%"
                },
                new RewardDetails()
                {
                    Title="Keva Smoothie - Devanation Dezavala",
                    Address="13000 Folsom Blvd, Folsom, CA 95630. USA",
                    Offer="Enjoy ONE Potion of our Delicious Sliders / Sandwiches",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="POINTS",
                    OfferValue="200"
                },
                new RewardDetails()
                {
                    Title="Marco Moderen Cafe",
                    Address="Lot G146, Ground Floor (Old Wing), 1Utamas",
                    Offer="Monsoon Top Up Sale: Get Upto 5% OFF",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="OFFER",
                    OfferValue="5%"
                },
                new RewardDetails()
                {
                    Title="Keva Smoothie - Devanation Dezavala",
                    Address="13000 Folsom Blvd, Folsom, CA 95630. USA",
                    Offer="Enjoy ONE Potion of our Delicious Sliders / Sandwiches",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="POINTS",
                    OfferValue="200"
                },
                new RewardDetails()
                {
                    Title="Marco Moderen Cafe",
                    Address="Lot G146, Ground Floor (Old Wing), 1Utamas",
                    Offer="Monsoon Top Up Sale: Get Upto 5% OFF",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="OFFER",
                    OfferValue="5%"
                },
                new RewardDetails()
                {
                    Title="Keva Smoothie - Devanation Dezavala",
                    Address="13000 Folsom Blvd, Folsom, CA 95630. USA",
                    Offer="Enjoy ONE Potion of our Delicious Sliders / Sandwiches",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="POINTS",
                    OfferValue="200"
                },
                new RewardDetails()
                {
                    Title="Marco Moderen Cafe",
                    Address="Lot G146, Ground Floor (Old Wing), 1Utamas",
                    Offer="Monsoon Top Up Sale: Get Upto 5% OFF",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="OFFER",
                    OfferValue="5%"
                },
                new RewardDetails()
                {
                    Title="Keva Smoothie - Devanation Dezavala",
                    Address="13000 Folsom Blvd, Folsom, CA 95630. USA",
                    Offer="Enjoy ONE Potion of our Delicious Sliders / Sandwiches",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="POINTS",
                    OfferValue="200"
                },
                new RewardDetails()
                {
                    Title="Marco Moderen Cafe",
                    Address="Lot G146, Ground Floor (Old Wing), 1Utamas",
                    Offer="Monsoon Top Up Sale: Get Upto 5% OFF",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="OFFER",
                    OfferValue="5%"
                },
                new RewardDetails()
                {
                    Title="Keva Smoothie - Devanation Dezavala",
                    Address="13000 Folsom Blvd, Folsom, CA 95630. USA",
                    Offer="Enjoy ONE Potion of our Delicious Sliders / Sandwiches",
                    ValidTill="Valid until 27/05/2017",
                    IsOffer1Null = false,
                    IsOffer2Null = true,
                    OfferType="POINTS",
                    OfferValue="200"
                }
            };
            #endregion
        }

        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public override bool IsViewFromObject(A.View view, Java.Lang.Object @object)
        {
            return view == @object;
        }

        public override Java.Lang.Object InstantiateItem(A.ViewGroup container, int position)
        {
            /*
            var imageView = new ImageView(context);
            var inflater = LayoutInflater.From(Forms.Context);
            A.View view = inflater.Inflate(Resource.Layout.CarouselCellOneLayout, null);
            var colorView = view.FindViewById<A.View>(Resource.Id.colorViewSampleBox);
            colorView.SetBackgroundColor(items[position].PageColor);
            */

            var inflater = LayoutInflater.From(Forms.Context);
            A.View view = inflater.Inflate(Resource.Layout.listviewpagemodel, null);
            var lvLayout = view.FindViewById<Android.Widget.ListView>(Resource.Id.ListViewLayout);
            lvLayout.Adapter = new CustomViewWithListAdapter(Forms.Context as Android.App.Activity, rewardsData);




            //imageView.SetImageResource(treeCatalog[position].imageId);
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(view);
            return view;
        }

        public override void DestroyItem(A.ViewGroup container, int position, Java.Lang.Object @object)
        {
            var pager = (ViewPager)container;
            pager.RemoveView((A.ViewGroup)@object);
        }

    }
}

