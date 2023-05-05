using Zamin.Core.Domain.Entities;

namespace RFTech.Core.Domain.Users.Entities
{
    public class ActivityLog : Entity
    {
        #region constructors

        #endregion

        #region properties

        public Guid Id { get; private set; }
        public string ActivityType { get; private set; }
        public DateTime ActivityDate { get; private set; }
        public long UserId { get; private set; }
        public string Details { get; private set; }

        #endregion
    }
}
