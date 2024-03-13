using System;

namespace Weathered_Lib.Models
{
    public class PirateWeatheredRequest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateOnly Date { get; set; }

        public PirateWeatheredRequest(double latitude, double longitude, DateOnly date)
        {
            Latitude = latitude;
            Longitude = longitude;
            Date = date;
        }
    }
}
