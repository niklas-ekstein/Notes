using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Notes.Models;
using Notes.Utils;
using System.Collections.ObjectModel;

namespace Notes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage2 : ContentPage
    {
        private static List<CountryModel> _countries;
        private CountryModel _selectedCountry;

        public RegistrationPage2()
        {
            InitializeComponent();
            LoadCountries();
            VisibleCountries = new ObservableCollection<CountryModel>(_countries);
            CommonCountriesList.SetBinding(Picker.ItemsSourceProperty, new Binding(nameof(VisibleCountries), source: this));

            BCountry.IsEnabled = false;
            BDate.IsEnabled = false;
            BGender.IsEnabled = false;
        }

        public ObservableCollection<CountryModel> VisibleCountries { get; }

        public CountryModel SelectedCountry
        {
            get => _selectedCountry;
            set
            {
                _selectedCountry = value;
                OnPropertyChanged(nameof(SelectedCountry));
            }
        }

        private void LoadCountries()
        {
            //this is not Task, because it's really fast
            //var phoneNumberUtil = PhoneNumberUtil.GetInstance();
            _countries = new List<CountryModel>();
            var isoCountries = CountryUtils.GetCountriesByIso3166();
            _countries.AddRange(isoCountries.Select(c => new CountryModel
            {
                //CountryCode = phoneNumberUtil.GetCountryCodeForRegion(c.TwoLetterISORegionName).ToString(),
                CountryName = c.EnglishName,
                FlagUrl = $"https://hatscripts.github.io/circle-flags/flags/{c.TwoLetterISORegionName.ToLower()}.svg",
            }));
        }

        private void CommonCountriesList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            SelectedCountry = e.SelectedItem as CountryModel;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await B1.RelRotateTo(360, 1000);
            B1.BackgroundColor = Color.LightBlue;
            B1.TextColor = Color.White;

            B2.BackgroundColor = Color.White;
            B2.TextColor = Color.Black;
        }

        private async void Button_Clicked2(object sender, EventArgs e)
        {
            //await B1.RelRotateTo(360, 1000);
            B2.BackgroundColor = Color.LightBlue;
            B2.TextColor = Color.White;

            B1.BackgroundColor = Color.White;
            B1.TextColor = Color.Black;
        }


    }
}