using FluentNHibernate.Mapping;

namespace EnterprisePatterns.Api.Customers.Infrastructure.Persistence.NHibernate.Mapping
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.Id).Column("customer_id");
            Map(x => x.FirstName).Column("first_name");
            Map(x => x.LastName).Column("last_name");
            Map(x => x.IdentityDocument).Column("identity_document");
            Map(x => x.Active).CustomType<bool>().Column("active");
        }
    }
}
