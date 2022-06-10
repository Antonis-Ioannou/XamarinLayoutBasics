using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFirstProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public MyFlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new MyFlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class MyFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyFlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public MyFlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MyFlyoutPageFlyoutMenuItem>(new[]
                {
                    new MyFlyoutPageFlyoutMenuItem { Id = 0, Title = "Labels", IconSource="notes.png" ,TargetType = typeof(Labels) },
                    new MyFlyoutPageFlyoutMenuItem { Id = 1, Title = "Entries", TargetType = typeof(Entries)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 2, Title = "Buttons", TargetType = typeof(UsingButtons)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 3, Title = "CheckBoxes", TargetType = typeof(CheckBoxes)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 4, Title = "Images", TargetType = typeof(UsingImages)},
                    new MyFlyoutPageFlyoutMenuItem { Id = 5, Title = "Product Info", TargetType = typeof(ProductPage)}
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}