using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFirstProject
{
    public class ItemInfoViewModel : INotifyPropertyChanged
    {
        public ICommand SubmitCommand => new Command(Submit);

        public string ItemName { get; set; }

        public decimal ItemPrice { get; set; }

        public string _message { get; set; }

        public string Message { get { return _message; }
                                set { _message = value;
                                OnProperyChanged();
                                }}

        public event PropertyChangedEventHandler PropertyChanged;

        void OnProperyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
            {
                return;
            }

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Submit()
        {
            Message = $"Saved Item Name: {this.ItemName} & Price: {this.ItemPrice}";
        }
    }
}
