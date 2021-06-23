using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Notes.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Notes.Views;
using System.Runtime.CompilerServices;

namespace Notes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            //MessagingCenter.Send<LoginPage>(this,
            //    (UsernameTxt.Text == "admin") ? "admin" : "user"
            //);

            await Shell.Current.GoToAsync($"//{nameof(NoteEntryPage)}");
        }

        private async void Button_Clicked2(object sender, EventArgs e)
        {
            //MessagingCenter.Send<LoginPage>(this,
            //    (UsernameTxt.Text == "admin") ? "admin" : "user"
            //);
            //ShowPopupCommand = new Command(async _ => await ExecuteShowPopupCommand());
            await Shell.Current.GoToAsync("RegisterPage");
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage/RegisterPage");
        }
    }
}