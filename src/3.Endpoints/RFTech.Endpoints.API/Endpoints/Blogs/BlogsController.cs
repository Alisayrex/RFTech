using Microsoft.AspNetCore.Mvc;
using RFTech.Core.Contracts.Blogs.Commands.CreateBlog;
using Zamin.EndPoints.Web.Controllers;

namespace RFTech.Endpoints.API.Blogs;

[Route("api/[controller]")]
[ApiController]

public class BlogsController : BaseController
{
    [HttpPost("[action]")]
    public async Task<IActionResult> CreateBlog(CreateBlogCommand createBlog) => await Create(createBlog);
}
