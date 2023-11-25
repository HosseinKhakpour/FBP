using DoubleCode.Domain.Base;
using Microsoft.AspNetCore.Identity;

namespace Fara.Services.Identity.Domain.Entity.User;


public class User : IdentityUser<int>
{
    public bool IsBlocked { get; set; }

}
