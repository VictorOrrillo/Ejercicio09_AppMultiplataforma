using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio09
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void DynamicDemo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DynamicDemo());
        }
        private async void ExplicitControlDemo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExplicitControlDemo());
        }
        private async void ExplicitDemo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExplicitDemo());
        }
        private async void GlobalDemo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlobalDemo());
        }
        private async void ImplicitControlDemo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImplicitControlDemo());
        }
        private async void ImplicitDemo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ImplicitDemo());
        }
        private async void InheritanceDemo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InheritanceDemo());
        }
    }
}
