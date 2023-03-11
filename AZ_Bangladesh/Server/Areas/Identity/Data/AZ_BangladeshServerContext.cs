using AZ_Bangladesh.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AZ_Bangladesh.Server.Data;

public class AZ_BangladeshServerContext : IdentityDbContext<ApplicationUser>
{
    public AZ_BangladeshServerContext(DbContextOptions<AZ_BangladeshServerContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
