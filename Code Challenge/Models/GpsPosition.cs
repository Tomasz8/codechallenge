using System;

namespace Code_Challenge.Models
{
    public class GpsPosition: BaseModel
    {
        public DateTime Timestamp { get; set; }
        
        public int TruckId { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public double DistanceFromPrevious { get; set; }
    }
}
