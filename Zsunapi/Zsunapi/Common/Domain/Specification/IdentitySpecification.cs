using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zsunapi.Common.Domain.Specification
{
    internal sealed class IdentitySpecification<T> : Specification<T>
    {
        public override Expression<Func<T, bool>> ToExpression()
        {
            return x => true;
        }
    }
}
