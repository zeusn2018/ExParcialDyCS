using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zsunapi.Customers.Infrastructure.Persistence.NHibernate;
using Zsunapi.Customers.Domain.Repository;

namespace Zsunapi.Customers.Infrastructure.Persistence.NHibernate.Repository
{
    class CustomerNHibernateRepository : BaseNHibernateRepository<Customer>, ICustomerRepository
    {
        public CustomerNHibernateRepository(UnitOfWorkNHibernate unitOfWork) : base(unitOfWork)
        {
        }
    }
}
