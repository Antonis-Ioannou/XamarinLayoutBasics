using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFirstProject.Services;
using XamarinFirstProject.Views;

namespace XamarinFirstProject
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            //MainPage = new AppShell();
            //MainPage = new Labels();
            //MainPage = new Entries();
            //MainPage = new UsingButtons();
            //MainPage = new UsingImages();
            //MainPage = new NavigationPage(new LoginPage());
            MainPage = new MyFlyoutPage();
            //MainPage = new ItemInfo();
            //MainPage = new BindingExample();
            //MainPage = new CommandsExample();
            //MainPage = new ProductPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
