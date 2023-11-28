/*using System.Collections.Generic;
using System.IO;
using backend.Models;
using GeoJSON.Net.Feature;
using Newtonsoft.Json;

namespace backend.Models
{
    

    public class GeoJsonFeature
	{
		public int Id { get; set; }
		public string Type { get; set; }
		public Geometry Geometry { get; set; }
		public Properties Properties { get; set; }
		public Style Style { get; set; }

	}
	public class Geometry
	{
		public string Type { get; set; }
		public List<double> Coordinates { get; set; }
	}

    public class Properties
    {
        public string Name { get; set; }
        public int Mcc { get; set; }
        public int Mnc { get; set; }
        public int Area { get; set; }
        public long CellId { get; set; }
        public string SysSubtype { get; set; }
        public string PCI { get; set; }
        public string Bandwidth { get; set; }
        public int EARFCN { get; set; }
        public string MaxRSRP { get; set; }
        public string Direction { get; set; }
        public string Height { get; set; }
        public string UplinkFreq { get; set; }
        public string DownlinkFreq { get; set; }
        public string FreqBand { get; set; }
        public string Time { get; set; }
    }
    public class Style
    {
        public string StrokeWidth { get; set; }
        public double FillOpacity { get; set; }
    }


}
*/

using Newtonsoft.Json;
using System.Collections.Generic;

namespace backend.Models
{
    public class GeoJsonFeatureCollection
    {
        public List<GeoJsonFeature> Features { get; set; }
    }

    public class GeoJsonFeature
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public Geometry Geometry { get; set; }
        public Properties Properties { get; set; }
        public Style Style { get; set; }
    }

    public class Geometry
    {
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
    }

    public class Properties
    {
        public string Name { get; set; }
        public int Mcc { get; set; }
        public int Mnc { get; set; }
        public int Area { get; set; }
        public long Cell_Id { get; set; }
        public string Sys_Subtype { get; set; }
        public string PCI { get; set; }
        public string Bandwidth { get; set; }
        public int EARFCN { get; set; }
        public string Max_RSRP { get; set; }
        public string Direction { get; set; }
        public string Height { get; set; }
        public string Uplink_Freq { get; set; }
        public string Downlink_Freq { get; set; }
        public string Freq_Band { get; set; }
        public string Time { get; set; }
    }

    public class Style
    {
        [JsonProperty("stroke-width")] // This attribute is used to map the property to the JSON key
        public string StrokeWidth { get; set; }

        [JsonProperty("fill-opacity")]
        public double FillOpacity { get; set; }
    }
}
