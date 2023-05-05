using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace RFTech.Infra.Data.Sql.Commands.Common;

public class RFTechCommandDbContext : BaseOutboxCommandDbContext
{
    public DbSet<Blog> Blogs { get; set; }

    public RFTechCommandDbContext(DbContextOptions<RFTechCommandDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
}
