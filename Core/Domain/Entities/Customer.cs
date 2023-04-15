using Domain.Entities.Common;

namespace Domain.Entities;

public class Customer: BaseEntity
{
    public string Email { get; set; }

    public string Password { get; set; }
}