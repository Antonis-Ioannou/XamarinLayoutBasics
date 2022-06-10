using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFirstProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsingImages : ContentPage
    {
        public UsingImages()
        {
            InitializeComponent();
            imageLogo.Source = ImageSource.FromFile("stormTrooper.png");
        }
    }
}