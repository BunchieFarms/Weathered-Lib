using Weathered_Lib.Extensions;

namespace Weathered_Lib.Models
{
    public class DataItems
    {
        public double Value { get; set; }
        public string Attribute { get; set; }
        public DataItems() { }
        public DataItems(double value, string attribute = "")
        {
            Value = value.ConvertMissing();
            Attribute = attribute;
        }
    }
}
