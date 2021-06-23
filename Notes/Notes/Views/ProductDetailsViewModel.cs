using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace Notes
{
    public class ProductDetailsViewModel : BaseViewModel
    {
        private ObservableCollection<FooObject> _images;
        private int _currentImage = 1;
        private LayoutState _mainState;

        public LayoutState MainState
        {
            get => _mainState;
            set => SetProperty(ref _mainState, value);
        }

        public ProductDetailsViewModel()
        {
            //LoadImages();
            //UpdateCurrentImage();
        }

        public ObservableCollection<FooObject> Images
        {
            get { return _images; }
            set
            {
                _images = value; //.Add("guitar1.jpg"); // = "guitar1.jpg"; //value;
                //_images = "Views\Images\guitar1.jpg";
                OnPropertyChanged();
            }
        }

        //public ObservableCollection<FooObject> ItemList { get; set; } = new ObservableCollection<FooObject> //Tagit bort public här..
        //{
        //    new FooObject { Foo = "hej.jpg" }, // IMAGE LÄNK HÄR....
        //    new FooObject { Foo = "hej.jpg" },
        //    new FooObject { Foo = "Hast.jpg" },
        //};

        public int CurrentImage
        {
            get { return _currentImage; }
            set
            {
                _currentImage = 1; // value;
                OnPropertyChanged();
            }
        }

        public ICommand RefreshCommand => new Command(async () => await OnRefreshAsync());

        private async Task OnRefreshAsync()
        {
            //MainState = LayoutState.Loading;
            //IsBusy = true;
            //await Task.Delay(300);
            //IsBusy = false;
            //MainState = LayoutState.None;
            await Shell.Current.GoToAsync("NoteEntryPage");
        }

        public ObservableCollection<FooObject> ItemList { get; set; } = new ObservableCollection<FooObject>
        {
            new FooObject { Foo = "hej.jpg" }, // IMAGE LÄNK HÄR....
            new FooObject { Foo = "exb2.jpg" },
            new FooObject { Foo = "hej.jpg" },
            //new FooObject { Foo = "Bar3" },
            //new FooObject { Foo = "Barmitzwa" },
        };

        //void LoadImages()
        //{
        //    Images = new ObservableCollection<FooObject>
        //    {

        //        new FooObject { Foo = "Hast.jpg" }, // IMAGE LÄNK HÄR....
        //        new FooObject { Foo = "Hast.jpg" },
        //        new FooObject { Foo = "Hast.jpg" }
        //        //Device.RuntimePlatform == Device.UWP ? "Assets/guitar1.jpg" : "guitar1.jpg",
        //        //Device.RuntimePlatform == Device.UWP ? "Assets/guitar2.jpg" : "guitar2.jpg",
        //        //Device.RuntimePlatform == Device.UWP ? "Assets/guitar3.jpg" : "guitar3.jpg"
        //    };
        //}

        void UpdateCurrentImage()
        {
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                CurrentImage++;

                if (CurrentImage == Images.Count) CurrentImage = 0;

                return true;
            });
        }
    }
}