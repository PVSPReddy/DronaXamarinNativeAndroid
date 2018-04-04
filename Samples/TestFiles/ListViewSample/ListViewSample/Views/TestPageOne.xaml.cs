using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewSample.Views
{
    public partial class TestPageOne : ContentPage
    {
        public TestPageOne()
        {
            InitializeComponent();
        }

        private void NextButtonClicked(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }
}
