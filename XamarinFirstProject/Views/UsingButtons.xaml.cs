using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFirstProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsingButtons : ContentPage
    {
        public ICommand ButtonCommand => new Command<string>(CommandButtonClick);

        public UsingButtons()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            lblMessage.Text = "Save Success";
        }

        public void CommandButtonClick(string str)
        {
            lblMessage.Text = str;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Alert","You have been alerted","OK");
        }
    }
}