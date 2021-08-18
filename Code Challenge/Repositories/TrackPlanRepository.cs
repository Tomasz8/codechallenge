using Code_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Code_Challenge.Repositories
{
    public interface ITruckPlanRepository
    {
        IEnumerable<TruckPlan> GetAll(Expression<Func<TruckPlan, bool>> predicate);
    }

    public class TrackPlanRepository : ITruckPlanRepository, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TruckPlan> GetAll(Expression<Func<TruckPlan, bool>> predicate)
        {
            //gets data from repository
            throw new NotImplementedException();
        }
    }
}
