﻿using RFTech.Core.Contracts.Blogs.Commands;
using RFTech.Core.Contracts.Blogs.Commands.CreateBlog;
using RFTech.Core.Domain.Blogs.Entities;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;

namespace RFTech.Core.ApplicationService.Blogs.Commands.CreateBlog;

public class CreateBlogCommandHandler : CommandHandler<CreateBlogCommand>
{

    private readonly IBlogCommandRepository _blogCommandRepository;

    public CreateBlogCommandHandler(ZaminServices zaminServices, IBlogCommandRepository blogCommandRepository)
        : base(zaminServices)
    {
        _blogCommandRepository = blogCommandRepository;
    }

    public override Task<CommandResult> Handle(CreateBlogCommand command)
    {
        throw new NotImplementedException();
    }

    //public override async Task<CommandResult> Handle(CreateBlogCommand request)
    ////{
    ////    BlogPost blog = new(request.BusunessId, request.Title, request.Description);

    ////    await _blogCommandRepository.InsertAsync(blog);

    ////    await _blogCommandRepository.CommitAsync();

    //    return await OkAsync();
    //}
}
