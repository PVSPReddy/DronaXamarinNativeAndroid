using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Collections.Generic;

namespace XamarinAndroidBasicApplication
{
    [Activity(Label = "XamarinAndroidBasicApplication", MainLauncher = true)]
    public class MainActivity : Activity
    {
        //static readonly List<string> phoneNumbers = new List<string>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            /*
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            */


            /*
            // Set our view from the "HelloDroidSingleScreenAXML" layout resource
            SetContentView(Resource.Layout.HelloDroidSingleScreenAXML);
            // Get our UI controls from the loaded layout
            EditText phoneNumberText = FindViewById<EditText>(Resource.Id.PhoneNumberText);
            TextView translatedPhoneWord = FindViewById<TextView>(Resource.Id.TranslatedPhoneWord);
            Button translateButton = FindViewById<Button>(Resource.Id.TranslateButton);
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
            */

            /*
            // Set our view from the "HelloDroidMultiScreenAXML" layout resource
            SetContentView(Resource.Layout.HelloDroidMultiScreenAXML);
            // Get our UI controls from the loaded layout
            EditText phoneNumberText = FindViewById<EditText>(Resource.Id.MultiScreenPhoneNumberText);
            TextView translatedPhoneWord = FindViewById<TextView>(Resource.Id.MultiScreenTranslatedPhoneWord);
            Button translateButton = FindViewById<Button>(Resource.Id.MultiScreenTranslateButton);
            Button translationHistoryButton = FindViewById<Button>(Resource.Id.TranslationHistoryButton);
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
            */

            //this code is to call menu page of the application
            var intent = new Intent(this, typeof(MainMenuActivity));
            StartActivity(intent);


        }
    }
}

