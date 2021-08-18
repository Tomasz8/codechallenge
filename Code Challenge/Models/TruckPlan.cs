using System;

namespace Code_Challenge.Models
{
    public class TruckPlan: BaseModel
    {
        public int DriverId { get; set; }
        
        public int TruckId { get; set; }
        
        public DateTime Date { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeStop { get; set; }

        public string Country { get; set; }
    }
}
