using System;
using ListViewSample;
using ListViewSample.Droid;
using A = Android.Views;
using AG = Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Views;
using Android.Support.V4.View;
using System.Collections.Generic;

[assembly : ExportRenderer(typeof(CustomViewCarousel), typeof(CustomViewCarouselRender))]
namespace ListViewSample.Droid
{
    public class CustomViewCarouselRender : ViewRenderer<CustomViewCarousel, A.View>
    {
        public CustomViewCarouselRender(){}

        A.View nativeView;
        ViewPager carouselPager;
        List<ViewValue> views;// = new List<A.View>();

        protected override void OnElementChanged(ElementChangedEventArgs<CustomViewCarousel> e)
        {
            base.OnElementChanged(e);
            views = new List<ViewValue>()
            {
                new ViewValue(){ PageColor = AG.Color.Violet },
                new ViewValue(){ PageColor = AG.Color.Indigo },
                new ViewValue(){ PageColor = AG.Color.Blue },
                new ViewValue(){ PageColor = AG.Color.Green },
                new ViewValue(){ PageColor = AG.Color.Yellow },
                new ViewValue(){ PageColor = AG.Color.Orange },
                new ViewValue(){ PageColor = AG.Color.Red }
            };

            if (Control == null)
            {
                var inflater = LayoutInflater.From(Forms.Context);
                nativeView = inflater.Inflate(Resource.Layout.CustomViewCarouselLayout, null);
                SetNativeControl(nativeView);
            }

            if(e.OldElement != null)
            {
                
            }

            if(e.NewElement != null)
            {
                carouselPager = nativeView.FindViewById<ViewPager>(Resource.Id.carouselPager);
                carouselPager.Adapter = new CustomViewCarouselAdapter(Forms.Context as Android.App.Activity, views);
            }

        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }

    }

    public class ViewValue
    {
        public Android.Graphics.Color PageColor { get; set; }
    }
}

