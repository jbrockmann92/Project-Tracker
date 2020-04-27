using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace TrackingApp.Models
{
    class Weather
    {
        public string Date { get; set; }
        public int TempF { get; set; }
        public int TempC { get; set; }
        public string Summary { get; set; }

    }
}