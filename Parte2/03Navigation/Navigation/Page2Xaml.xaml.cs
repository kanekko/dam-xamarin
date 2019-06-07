using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Navigation
{
    public partial class Page2Xaml : ContentPage
    {
        public Page2Xaml()
        {
            InitializeComponent();
        }

        async void onNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3Xaml());
        }

        async void onPreviousPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}
