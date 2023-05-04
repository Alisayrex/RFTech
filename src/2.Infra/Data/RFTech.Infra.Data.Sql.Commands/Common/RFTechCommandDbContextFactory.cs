using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RFTech.Infra.Data.Sql.Commands.Common;

public class RFTechCommandDbContextFactory : IDesignTimeDbContextFactory<RFTechCommandDbContext>
{
    public RFTechCommandDbContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<RFTechCommandDbContext>();

        builder.UseSqlServer("Server =.; Database=RFTechDb;User Id = sa;Password=1qaz!QAZ; MultipleActiveResultSets=true; Encrypt = false");

        return new RFTechCommandDbContext(builder.Options);
    }
}
