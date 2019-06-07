using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Navigation
{
    public partial class Page1Xaml : ContentPage
    {
        public Page1Xaml()
        {
            InitializeComponent();
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2Xaml());
        }
    }
}
