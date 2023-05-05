using RFTech.Core.Contracts.Blogs.Commands;
using RFTech.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace RFTech.Infra.Data.Sql.Commands.Blogs;

public class BlogCommandRepository
    : BaseCommandRepository<Blog, RFTechCommandDbContext>, IBlogCommandRepository
{
    public BlogCommandRepository(RFTechCommandDbContext dbContext) : base(dbContext)
    {
    }
}
