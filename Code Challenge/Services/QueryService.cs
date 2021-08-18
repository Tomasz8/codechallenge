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

        //this should be parametrized (age, country, month, year)
        public double DistanceDrivers50GermanyFeb2018()
        {
            var drivers50 = _driverRepository.GetAll(x => x.Age == 50);
            var truckPlans = _truckPlanRepository
                                .GetAll(x => x.Date.Year == 2018 && x.Date.Month == 2
                                            && x.Country.Equals("Germany", StringComparison.CurrentCultureIgnoreCase)
                                            && drivers50.Select(x => x.Id).Contains(x.DriverId));
            return truckPlans.Sum(x => _truckPlanService.CalculateDistance(x));                                        

        }
    }
}
