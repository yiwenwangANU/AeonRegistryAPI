using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace AeonRegistryAPI.Models;

public class ApplicationUser : IdentityUser
{
    [Required]
    public string Name { get; set; } = string.Empty;
}
