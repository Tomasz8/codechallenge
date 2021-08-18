using Code_Challenge.Models;
using System.Linq;

namespace Code_Challenge.Services
{
    public interface ITruckPlanService
    {
        double CalculateDistance(TruckPlan truckPlan);
    }

    public class TruckPlanService : ITruckPlanService
    {
        private readonly IGpsPositionService _gpsPositionService;

        public TruckPlanService(IGpsPositionService gpsPositionService)
        {
            _gpsPositionService = gpsPositionService;
        }

        public double CalculateDistance(TruckPlan truckPlan)
        {
            return _gpsPositionService
                .GetAll(truckPlan.TruckId)
                .Where(x => x.Timestamp.CompareTo(truckPlan.TimeStart) >= 0 && x.Timestamp.CompareTo(truckPlan.TimeStop) <= 0)
                .Sum(s => s.DistanceFromPrevious);
        }
    }
}
