using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Notes.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        //async void OnButtonClicked(object sender, EventArgs e)
        protected override void OnAppearing()
        {
            // Launch the specified URL in the system browser.
            //await Launcher.OpenAsync("https://aka.ms/xamarin-quickstart");
            base.OnAppearing();

            //(BindingContext as ProductDetailsViewModel).SkeletonCommand.Execute(null);
        }
    }
}