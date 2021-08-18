using Code_Challenge.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Code_Challenge.Repositories
{
    public interface IDriverRepository
    {
        IEnumerable<Driver> GetAll(Expression<Func<Driver, bool>> predicate);
    }

    public class DriverRepository : IDriverRepository
    {
        public IEnumerable<Driver> GetAll(Expression<Func<Driver, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
