
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
    [Activity(Label = "BasicSingleScreenActivity")]
    public class BasicSingleScreenActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            //this is used only when navigation is done from menu pages or else this code can be directly used in main activty itself
            // Set our view from the "HelloDroidSingleScreenAXML" layout resource
            SetContentView(Resource.Layout.HelloDroidSingleScreenAXML);
            // Get our UI controls from the loaded layout
            EditText phoneNumberText = FindViewById<EditText>(Resource.Id.PhoneNumberText);
            TextView translatedPhoneWord = FindViewById<TextView>(Resource.Id.TranslatedPhoneWord);
            Button translateButton = FindViewById<Button>(Resource.Id.TranslateButton);
            ImageView imageBack = FindViewById<ImageView>(Resource.Id.SingleScreenImageBack);
            // Add code to translate number
            string translatedNumber = string.Empty;
            translateButton.Click += (sender, e) =>
            {
                // Translate user’s alphanumeric phone number to numeric
                translatedNumber = PhonewordTranslatorSingleScreen.ToNumber(phoneNumberText.Text);
                if (string.IsNullOrWhiteSpace(translatedNumber))
                {
                    translatedPhoneWord.Text = string.Empty;
                }
                else
                {
                    translatedPhoneWord.Text = translatedNumber;
                }
            };

            imageBack.Click += (sender, e) =>
            {
                try
                {
                    Finish();
                    //OnBackPressed();
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                }

            };
        }

        public override void OnBackPressed()
        {
            //base.OnBackPressed();
        }
    }
}
