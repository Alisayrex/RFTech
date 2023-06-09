﻿using Zamin.Infra.Data.Sql.Commands;
using RFTech.Core.Contracts.Blogs.Commands;
using RFTech.Core.Domain.Blogs.Entities;
using RFTech.Infra.Data.Sql.Commands.Common;

namespace RFTech.Infra.Data.Sql.Commands.Blogs;

public class BlogCommandRepository
    : BaseCommandRepository<Blog, RFTechCommandDbContext>, IBlogCommandRepository
{
    public BlogCommandRepository(RFTechCommandDbContext dbContext) : base(dbContext)
    {
    }
}
