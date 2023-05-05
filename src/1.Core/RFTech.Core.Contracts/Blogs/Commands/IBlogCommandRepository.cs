using RFTech.Core.Domain.Blogs.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace RFTech.Core.Contracts.Blogs.Commands;

public interface IBlogCommandRepository : ICommandRepository<BlogPost>
{
}
