using Microsoft.EntityFrameworkCore;
using Zamin.Infra.Data.Sql.Queries;

namespace RFTech.Infra.Data.Sql.Queries.Common;

public class RFTechQueryDbContext : BaseQueryDbContext
{
    public RFTechQueryDbContext(DbContextOptions options) : base(options)
    {
    }
}
