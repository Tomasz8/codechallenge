using Code_Challenge.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge.Services
{
    public class QueryService
    {
        private readonly ITruckPlanService _truckPlanService;

        private readonly ITruckPlanRepository _truckPlanRepository;

        private readonly IDriverRepository _driverRepository;

        public QueryService(ITruckPlanService truckPlanService, ITruckPlanRepository truckPlanRepository, IDriverRepository driverRepository)
        {
            _truckPlanService = truckPlanService;
            _truckPlanRepository = truckPlanRepository;
            _driverRepository = driverRepository;
        }

        //can be called as DistanceForDrivers(50, "Germany", 2018, 2)
        public double DistanceForDrivers(int age, string country, int year, int month)
        {
            var drivers50 = _driverRepository.GetAll(x => x.Age == age);
            var truckPlans = _truckPlanRepository
                                .GetAll(x => x.Date.Year == year && x.Date.Month == month
                                            && x.Country.Equals(country, StringComparison.CurrentCultureIgnoreCase)
                                            && drivers50.Select(x => x.Id).Contains(x.DriverId));
            return truckPlans.Sum(x => _truckPlanService.CalculateDistance(x));                                        

        }
    }
}
