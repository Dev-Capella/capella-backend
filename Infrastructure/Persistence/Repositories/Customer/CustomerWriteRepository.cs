using Application.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class CustomerWriteRepository: WriteRepository<Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(CapellaDbContext context) : base(context)
    {
    }
}