using System.Collections.Generic;
using System;
using MongoDB.Bson;
using System.Linq;

namespace Weathered_Lib.Models
{
    public class PastWeekStationData
    {
        public ObjectId _id { get; set; } = ObjectId.GenerateNewId();
        public string StationNumber { get; set; }
        public string StationName { get; set; }
        public string Region { get; set; } = "";
        public string Country { get; set; } = "";
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Elevation { get; set; }
        public DateTime LastUpdate { get; set; }
        public List<PastWeekData> PastWeekData { get; set; } = new List<PastWeekData>();

        public PastWeekStationData() { }

        public PastWeekStationData(List<StationGSOD> station)
        {
            StationNumber = station[0].StationNumber;
            StationName = station[0].StationName;
            Latitude = station[0].Latitude;
            Longitude = station[0].Longitude;
            Elevation = station[0].Elevation;

            int commaIndex = station[0].StationName.IndexOf(',');
            if (commaIndex > -1)
            {
                string regionCountry = station[0].StationName.Substring(commaIndex + 1).Trim();
                string[] splitRegCo = regionCountry.Split(' ');
                if (splitRegCo.Length > 1)
                {
                    Region = splitRegCo[0];
                    Country = splitRegCo[1];
                }
                else
                {
                    Country = splitRegCo[0];
                }
            }

            foreach (StationGSOD day in station)
                PastWeekData.Add(new PastWeekData(day));

            LastUpdate = station.Select(x => x.Date).Max();
        }
    }
}
