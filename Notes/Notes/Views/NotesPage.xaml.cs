using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Notes.Models;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Notes.Views
{
    public partial class NotesPage : ContentPage
    {
        public NotesPage()
        {
            InitializeComponent();
            //Position position = new Position(36.9628066, -122.0194722);

            var pin = new Pin()
            {
                Position = new Position(20.2096165, -87.5068955),
                Label = "Some Pin! 1"

            };

            var pin2 = new Pin()
            {
                Position = new Position(20.6537778, -87.1417369),
                Label = "Some Pin! 2",

            };

            var pin3 = new Pin()
            {
                Position = new Position(21.1214886, -86.9194448),
                Label = "Some Pin! 1"

            };

            var pin4 = new Pin()
            {
                Position = new Position(21.2320896, -86.766738),
                Label = "Some Pin! 2",
            };

            var pin5 = new Pin()
            {
                Position = new Position(21.1619147, -86.8516339),
                Label = "Some Pin 5! Cancun"

            };

            var pin6 = new Pin()
            {
                Position = new Position(20.5109726, -86.9529441),
                Label = "Some Pin! 2",

            };

            var pin7 = new Pin()
            {
                Position = new Position(20.2096165, -87.5068955),
                Label = "Some Pin! 1"

            };

            var pin8 = new Pin()
            {
                Position = new Position(20.6537778, -87.1417369),
                Label = "Some Pin! 2",

            };

            var pin9 = new Pin()
            {
                Position = new Position(20.2096165, -87.5068955),
                Label = "Some Pin! 1"

            };

            var pin10 = new Pin()
            {
                Position = new Position(20.6537778, -87.1417369),
                Label = "Some Pin! 2",

            };

            var pin11 = new Pin()
            {
                Position = new Position(20.2096165, -87.5068955),
                Label = "Some Pin! 1"

            };

            var pin12 = new Pin()
            {
                Position = new Position(20.6537778, -87.1417369),
                Label = "Some Pin! 2",

            };

            Circle circle2 = new Circle
            {
                Center = new Position(20.2096165, -87.5068955),
                Radius = new Distance(15000),
                //StrokeColor = Color.FromHex("#74CCF4"),
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#1BA1E2"),
                FillColor = Color.FromHex("#881BA1E2"),
                //FillColor =// = Color.FromHex("#74CCF4")

            };

            Circle circle = new Circle
            {
                Center = new Position(20.6537778, -87.1417369),
                Radius = new Distance(25000),
                //StrokeColor = Color.FromHex("#88FF0000"),
                StrokeColor = Color.FromHex("#1BA1E2"),
                FillColor = Color.FromHex("#881BA1E2"),
                StrokeWidth = 8,
                //FillColor = Color.FromHex("#88FFC0CB")
            };

            MyMap.Pins.Add(pin);
            MyMap.Pins.Add(pin2);

            MyMap.Pins.Add(pin3);
            MyMap.Pins.Add(pin4);
            MyMap.Pins.Add(pin5);
            MyMap.Pins.Add(pin6);
            MyMap.Pins.Add(pin7);
            MyMap.Pins.Add(pin8);
            MyMap.Pins.Add(pin9);
            MyMap.Pins.Add(pin10);
            MyMap.Pins.Add(pin11);
            MyMap.Pins.Add(pin12);

            MyMap.MapElements.Add(circle);
            MyMap.MapElements.Add(circle2);

            //MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.79752, -122.40183), Distance.FromMiles(1.0)));

            //pin.InfoWindowClicked += async (s, args) =>
            //{
            //    string pinName = ((Pin)s).Label;
            //    await DisplayAlert("Info Window Clicked", $"The info window was clicked for {pin}.", "Ok");
            //};

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Retrieve all the notes from the database, and set them as the
            // data source for the CollectionView.
            //collectionView.ItemsSource = await App.Database.GetNotesAsync();
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                // Navigate to the NoteEntryPage, passing the ID as a query parameter.
                Note note = (Note)e.CurrentSelection.FirstOrDefault();
                await Shell.Current.GoToAsync($"{nameof(NoteEntryPage)}?{nameof(NoteEntryPage.ItemId)}={note.ID.ToString()}");
            }
        }

        async void OnAddClicked(object sender, EventArgs e)
        {
            // Navigate to the NoteEntryPage, without passing any data.
            await Shell.Current.GoToAsync(nameof(NoteEntryPage));
        }

        void OnMapClicked(object sender, MapClickedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"MapClick: {e.Position.Latitude}, {e.Position.Longitude}");
        }

    }
}