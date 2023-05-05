using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace RFTech.Core.Domain.Blogs.Entities
{
    public class BlogPost : AggregateRoot
    {
        #region Constructors
        private BlogPost() { }


        #endregion


        #region Properties

        public Title Title { get; private set; }
        public string Body { get; private set; }
        public long AuthorId { get; private set; }
        public DateTime PublishDate { get; private set; }
        public DateTime? ModifyDate { get; private set; }
        public bool IsPublished { get; private set; }
        public bool IsDeleted { get; private set; }
        public List<int>? Tags { get; private set; }
        public BlogStatistic BlogStatistic { get; private set; }
        public Category? Category { get; private set; }
        public BlogSetting BlogSetting { get; private set; }

        private readonly List<BlogSubscription?> _blogSubscriptions;
        public IReadOnlyCollection<BlogSubscription?> BlogSubscriptions => _blogSubscriptions;




        #endregion


        #region Business Rules

        #endregion


    }
}
