using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            CustomPin pin = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(20.2096165, -87.5068955),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            CustomPin pin2 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(20.6537778, -87.1417369),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            CustomPin pin3 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(21.1214886, -86.9194448),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            CustomPin pin4 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(21.2320896, -86.766738),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            CustomPin pin5 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(21.5227905, -87.3836554),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            CustomPin pin6 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(20.5109726, -86.9529441),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            CustomPin pin7 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(20.2096165, -87.5068955),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            CustomPin pin8 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(20.6537778, -87.1417369),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            CustomPin pin9 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(20.2096165, -87.5068955),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            CustomPin pin10 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(20.6537778, -87.1417369),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            CustomPin pin11 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(20.2096165, -87.5068955),
                Label = "Xamarin San Francisco Office",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            CustomPin pin12 = new CustomPin
            {
                Type = PinType.Place,
                Position = new Position(21.1619147, -86.8516339),
                Label = "Cancun",
                Address = "394 Pacific Ave, San Francisco CA",
                Name = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            Circle circle10 = new Circle
            {
                Center = new Position(20.6537778, -87.1417369),
                Radius = new Distance(10000),
                StrokeColor = Color.FromHex("#88FF0000"),
                StrokeWidth = 1,
                FillColor = Color.FromHex("#88FFC0CB")
            };

            Circle circle12 = new Circle
            {
                Center = new Position(21.1619147, -86.8516339),
                Radius = new Distance(1500),
                StrokeColor = Color.FromHex("#1BA1E2"),
                FillColor = Color.FromHex("#881BA1E2"),
                StrokeWidth = 1,
            };

            Circle circle11 = new Circle
            {
                Center = new Position(37.79752, -122.40183),
                Radius = new Distance(2500),
                StrokeColor = Color.FromHex("#1BA1E2"),
                FillColor = Color.FromHex("#881BA1E2"),
                StrokeWidth = 4,
            };

            Circle circle5 = new Circle
            {
                Center = new Position(21.5227905, -87.3836554),
                Radius = new Distance(2500),
                StrokeColor = Color.FromHex("#1BA1E2"),
                FillColor = Color.FromHex("#881BA1E2"),
                StrokeWidth = 8,
            };


            // Add the Circle to the map's MapElements collection
            customMap.MapElements.Add(circle10);
            customMap.MapElements.Add(circle11);
            customMap.MapElements.Add(circle5);
            customMap.MapElements.Add(circle12);


            customMap.CustomPins = new List<CustomPin> { pin };
            customMap.Pins.Add(pin);
            customMap.Pins.Add(pin2);
            customMap.Pins.Add(pin3);
            customMap.Pins.Add(pin4);
            customMap.Pins.Add(pin5);
            customMap.Pins.Add(pin6);
            customMap.Pins.Add(pin7);
            customMap.Pins.Add(pin8);
            customMap.Pins.Add(pin9);
            customMap.Pins.Add(pin10);
            customMap.Pins.Add(pin11);
            customMap.Pins.Add(pin12);

            //Position position = new Position(36.9628066, -122.0194722);

            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(17.7640158, -90.3009449), Distance.FromMiles(300.0)));
        }
    }
}
