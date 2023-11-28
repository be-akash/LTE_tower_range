using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GeoJSON.Net.Feature;
using Newtonsoft.Json;
using backend.Models;
using Microsoft.Net.Http.Headers;

namespace backend.Controllers
{
    
    [Route("api/[controller]")]
	[ApiController]
	public class GeoJsonController : ControllerBase
	{
        private readonly string filePath = "Data/telekom_bs_bonn.geojson";
        [HttpGet]
		public IActionResult GetGeoJsonData()
		{
            
			string json = System.IO.File.ReadAllText(filePath);
			var featureCollection = JsonConvert.DeserializeObject<GeoJsonFeatureCollection>(json);
			var geoJsonFeatures = featureCollection.Features;
            /*foreach (var feature in geoJsonFeatures)
            {
                Console.WriteLine(JsonConvert.SerializeObject(feature));
            }*/
            DateTime currentTime = DateTime.Now;

            // Format the current time as a string
            string formattedTime = currentTime.ToString("yyyy-MM-dd HH:mm:ss");

            // Print the message along with the current time
            Console.WriteLine($"Fetched at {formattedTime}");
            /*Console.WriteLine("Fetched");*/
            //var featureCollection = JsonConvert.DeserializeObject<FeatureCollection<GeoJsonFeature>>(json);
            Response.ContentType = "application/vnd.geo+json";
            /*var contentDispositionHeader = new ContentDispositionHeaderValue("attachment")
            {
                FileName = "telekom_bs_bonn.geojson"
            };
            Response.Headers.Add(HeaderNames.ContentDisposition, contentDispositionHeader.ToString());*/

            return Ok(geoJsonFeatures);
        }
        [HttpGet("{id}")]
        public IActionResult GetGeoJsonFeatureById(int id)
        {
            string json = System.IO.File.ReadAllText(filePath);
            var featureCollection = JsonConvert.DeserializeObject<GeoJsonFeatureCollection>(json);
            // Find the feature with the specified ID
            var geoJsonFeature = featureCollection.Features.Find(feature => feature.Id == id);
            Response.ContentType = "application/vnd.geo+json";

            if (geoJsonFeature == null)
            {
                return Ok(new { });
            }

            return Ok(geoJsonFeature);


        }

    }
}
