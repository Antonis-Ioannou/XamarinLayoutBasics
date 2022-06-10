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
    public partial class CommandsExample : ContentPage
    {
        public CommandViewModel VM => ((CommandViewModel)BindingContext);
        public CommandsExample()
        {
            InitializeComponent();

            //VM.IncreaseCommand.Execute("10");
        }
    }
}