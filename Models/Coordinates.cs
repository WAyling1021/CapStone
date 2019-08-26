using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NextLevel.Models
{
    public class Coordinates
    {
        private double latitude;
        private double longitude;

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Coordinates(double Longitude, double Latitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}