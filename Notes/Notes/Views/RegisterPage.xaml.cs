using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            B1.IsEnabled = false;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Shell.Current.GoToAsync("RegistionPage2");
            //await Shell.Current.GoToAsync($"//{nameof(RegistrationPage2)}");
            await Shell.Current.GoToAsync("RegistrationPage2");
        }
    }
}