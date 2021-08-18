using Code_Challenge.Models;
using System.Collections.Generic;

namespace Code_Challenge.Services
{
    public interface IGpsPositionService
    {
        IEnumerable<GpsPosition> GetAll(int truckId);
    }

    public class GpsPositionService : IGpsPositionService
    {
        public IEnumerable<GpsPosition> GetAll(int truckId)
        {
            //this should return data from a repository
            return new List<GpsPosition>();
        }
    }
}
