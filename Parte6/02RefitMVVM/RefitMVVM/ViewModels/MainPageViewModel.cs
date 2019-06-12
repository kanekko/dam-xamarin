using System;
using System.Threading;
using RefitMVVM.Models;
using RefitMVVM.Service;

namespace RefitMVVM.ViewModels
{
    public class MainPageViewModel : BaseModels
    {
        public string Title { get; set; }
        private int number { get; set; }

        public int Number
        {
            get { return number; }
            set { number = value;  OnPropertyChanged(); }
        }

        public MainPageViewModel()
        {
            Title = "Main Page";
            Timer timer = new Timer((e) =>
            {
                GetNumber();
            }, null, 0, 3000);
        }

        public async void GetNumber()
        {
            var service = RefitServiceGenerator.GetService();
            Number = await service.GetNumber();
        }
    }
}
