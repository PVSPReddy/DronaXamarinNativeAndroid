using System;
using System.Collections.Generic;
using Android.Views;
using ListViewSample;
using ListViewSample.Droid;
//using LS = ListViewSample.Droid.Resources.Resource;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using A = Android.Views;

[assembly : ExportRenderer(typeof(CustomViewWithList), typeof(CustomViewWithListRender))]
namespace ListViewSample.Droid
{
    public class CustomViewWithListRender : ViewRenderer<CustomViewWithList, A.View>
    {
        public CustomViewWithListRender(){}
        Android.Widget.ListView lvLayout;
        A.View nativeView;
        List<RewardDetails> rewardsData;

        protected override void OnElementChanged(ElementChangedEventArgs<CustomViewWithList> e)
        {
            base.OnElementChanged(e);

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

            if(Control == null)
            {
                var inflater = LayoutInflater.From(Forms.Context);
                nativeView = inflater.Inflate(Resource.Layout.listviewpagemodel, null);
                SetNativeControl(nativeView);
                //return;
            }
            if(e.OldElement != null)
            {
                
            }
            if(e.NewElement != null)
            {
                try
                {
                    lvLayout = nativeView.FindViewById<Android.Widget.ListView>(Resource.Id.ListViewLayout);
                    lvLayout.Adapter = new CustomViewWithListAdapter(Forms.Context as Android.App.Activity, rewardsData);
                }
                catch(Exception ex)
                {
                    var msg = ex.Message;
                }
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            //if (e.PropertyName == lvLayout.ItemsProperty.PropertyName)
            //{
            try
            {
                //if (e.PropertyName == "items")
                //{
                //    //lvLayout.Adapter = new CustomViewWithListAdapter(Forms.Context as Android.App.Activity, rewardsData);
                //}
                //System.Diagnostics.Debug.WriteLine(e.PropertyName);
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
            }
            //}
        }
    }

    public class RewardDetails
    {

        public string Title { get; set; }

        public string Address { get; set; }

        public string Offer { get; set; }

        public string ValidTill { get; set; }

        public bool IsOffer1Null { get; set; }

        public bool IsOffer2Null { get; set; }

        public string OfferValue { get; set; }

        public string OfferType { get; set; }

        public string DistanceFromShop { get; set; }

        public string ShopLogo { get; set; }

        public string ShopCoverImage { get; set; }

    }
}

