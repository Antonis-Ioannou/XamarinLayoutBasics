using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFirstProject
{
    public class CommandViewModel : INotifyPropertyChanged
    {
        public ICommand IncreaseCommand { get; }

        public CommandViewModel()
        {
            IncreaseCommand = new Command<string>(IncreaseCount);
        }

        int count = 0;

        void IncreaseCount(string i)
        {
            App.Current.Resources["MainColour"] = Color.Red;
            App.Current.Resources["SecondColour"] = Color.Orange;
            if (int.TryParse(i, out int int2))
            {
                count += int2;
                OnPropertyChanged(nameof(DisplayCount));
            }
        }

        public string DisplayCount => $"You cliced {count} times(s)";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
