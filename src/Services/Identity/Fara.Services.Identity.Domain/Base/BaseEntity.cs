using System.ComponentModel.DataAnnotations;

namespace Fara.Services.Identity.Domain.Base;

public class BaseEntity
{
    [Key]
    public long Id { get; set; }
    public bool IsDeleted { get; set; }

}
