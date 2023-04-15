using Application.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class CustomerReadRepository: ReadRepository<Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(CapellaDbContext context) : base(context)
    {
    }
}