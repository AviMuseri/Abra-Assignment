using System.IO;
using System;

namespace WebAppAbra.Models
{
    public class LocationModel
    {
        public StreetModel Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public CoordinatesModel Coordinates { get; set; }
        public TimeZoneModel Timezone { get; set; }
    }
}

