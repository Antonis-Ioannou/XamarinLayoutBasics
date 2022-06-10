using System.ComponentModel;
using Xamarin.Forms;
using XamarinFirstProject.ViewModels;

namespace XamarinFirstProject.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}