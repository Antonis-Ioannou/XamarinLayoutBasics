using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFirstProject.ViewModels;

namespace XamarinFirstProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>(OpenBrowser);

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void TapGestureRecognizer_TappedRegister(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register());
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "123")
            {
                Navigation.PushAsync(new HomePage());
            }
            else
            {
                DisplayAlert("Ops...", "UserName or Password is incoreect!", "Ok");
            }
        }

        void OpenBrowser(string url)
        {
            Launcher.OpenAsync(url);
        }
    }
}