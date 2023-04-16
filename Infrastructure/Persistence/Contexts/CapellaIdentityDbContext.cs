using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Contexts;

public class CapellaIdentityDbContext : IdentityDbContext<AppUser,AppRole, string>
{
    public CapellaIdentityDbContext(DbContextOptions<CapellaIdentityDbContext> options) : base(options)
    {
        
    }
}