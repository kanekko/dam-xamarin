using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RefitMVVM.Models
{
    public class BaseModels : INotifyPropertyChanged
    {
        public BaseModels()
        { }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
