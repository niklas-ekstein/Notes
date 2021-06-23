using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace Notes.Views
{
    public class CustomMap : Map
    {
        public List<CustomPin> CustomPins { get; set; }
    }
}
