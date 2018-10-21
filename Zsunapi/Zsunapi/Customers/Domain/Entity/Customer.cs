using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zsunapi.Customers.Domain.Entity
{
    public class Customer
    {
        public virtual long Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string IdentityDocument { get; set; }
        public virtual bool Active { get; set; }

        public Customer()
        {
        }
    }
}
