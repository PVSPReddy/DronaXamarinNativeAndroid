
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
    [Activity(Label = "BasicMultiScreenActivity")]
    public class BasicMultiScreenActivity : Activity
    {
        static readonly List<string> phoneNumbers = new List<string>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            //this is used only when navigation is done from menu pages or else this code can be directly used in main activty itself
            // Set our view from the "HelloDroidMultiScreenAXML" layout resource
            SetContentView(Resource.Layout.HelloDroidMultiScreenAXML);
            // Get our UI controls from the loaded layout
            EditText phoneNumberText = FindViewById<EditText>(Resource.Id.MultiScreenPhoneNumberText);
            TextView translatedPhoneWord = FindViewById<TextView>(Resource.Id.MultiScreenTranslatedPhoneWord);
            Button translateButton = FindViewById<Button>(Resource.Id.MultiScreenTranslateButton);
            Button translationHistoryButton = FindViewById<Button>(Resource.Id.TranslationHistoryButton);
            ImageView imageBack = FindViewById<ImageView>(Resource.Id.MultiScreenImageBack);
            // Add code to translate number
            string translatedNumber = string.Empty;
            translateButton.Click += (sender, e) =>
            {
                // Translate user’s alphanumeric phone number to numeric
                translatedNumber = PhonewordTranslatorSingleScreen.ToNumber(phoneNumberText.Text);
                if (string.IsNullOrWhiteSpace(translatedNumber))
                {
                    translatedPhoneWord.Text = "";
                }
                else
                {
                    translatedPhoneWord.Text = translatedNumber;
                    phoneNumbers.Add(translatedNumber);
                    translationHistoryButton.Enabled = true;
                }
            };
            translationHistoryButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(TranslationHistoryActivity));
                intent.PutStringArrayListExtra("phone_numbers", phoneNumbers);
                StartActivity(intent);
            };

            imageBack.Click += (sender, e) =>
            {
                try
                {
                    //Finish();
                    OnBackPressed();
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                }

            };
        }
    }
}
