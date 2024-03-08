using System;

namespace Weathered_Lib.Models
{
    public class PastWeekData
    {
        public DateTime Date { get; set; }
        public DataItems Temp_Mean { get; set; }
        public DataItems Temp_Max { get; set; }
        public DataItems Temp_Min { get; set; }
        public DataItems SeaLevelPress_Mean { get; set; }
        public DataItems StationPress_Mean { get; set; }
        public DataItems Visi_Mean { get; set; }
        public DataItems Dewp_Mean { get; set; }
        public DataItems WndSpd_Mean { get; set; }
        public DataItems WndSpd_Max { get; set; }
        public DataItems WndSpd_Gust { get; set; }
        public DataItems Precip_Total { get; set; }
        public DataItems Snow_Depth { get; set; }

        public PastWeekData() { }

        public PastWeekData(StationGSOD day)
        {
            Date = day.Date;
            Temp_Mean = new DataItems(day.Temp_Mean, day.Temp_Mean_Attribute);
            Temp_Max = new DataItems(day.Temp_Max, day.Temp_Max_Attribute);
            Temp_Min = new DataItems(day.Temp_Min, day.Temp_Min_Attribute);
            SeaLevelPress_Mean = new DataItems(day.SeaLevelPress_Mean, day.SeaLevelPress_Mean_Attribute);
            StationPress_Mean = new DataItems(day.StationPress_Mean, day.StationPress_Mean_Attribute);
            Visi_Mean = new DataItems(day.Visi_Mean, day.Visi_Mean_Attribute);
            Dewp_Mean = new DataItems(day.Dewp_Mean, day.Dewp_Mean_Attribute);
            WndSpd_Mean = new DataItems(day.WndSpd_Mean, day.WndSpd_Mean_Attribute);
            WndSpd_Max = new DataItems(day.WndSpd_Max);
            WndSpd_Gust = new DataItems(day.WndSpd_Gust);
            Precip_Total = new DataItems(day.Precip_Total, day.Precip_Total_Attribute);
            Snow_Depth = new DataItems(day.Snow_Depth);
        }
    }
}
