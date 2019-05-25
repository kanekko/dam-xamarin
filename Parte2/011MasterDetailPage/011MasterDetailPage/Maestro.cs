using System;

using Xamarin.Forms;

namespace MasterDetailPage
{
    public class Maestro : ContentPage
    {
        public Maestro()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

