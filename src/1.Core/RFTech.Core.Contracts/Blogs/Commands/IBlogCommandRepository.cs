using Zamin.Core.Contracts.Data.Commands;
using RFTech.Core.Domain.Blogs.Entities;

namespace RFTech.Core.Contracts.Blogs.Commands;

public interface IBlogCommandRepository : ICommandRepository<Blog>
{
}
