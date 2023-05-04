﻿using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace RFTech.Core.Contracts.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommand : ICommand
    {
        public Guid BusunessId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
