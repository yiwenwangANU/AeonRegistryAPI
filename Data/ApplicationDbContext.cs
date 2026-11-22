using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AeonRegistryAPI.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): IdentityDbContext(options)
{
    [Required]
    public string? Name { get; set; }
}