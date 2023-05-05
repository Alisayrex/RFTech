using RFTech.Core.Domain.Common.ParrotTranslators;
using System.Security;
using Zamin.Core.Domain.Entities;

namespace RFTech.Core.Domain.Users.Entities
{
    public class Role : Entity
    {
        #region Constructors

        private Role() { }

        public Role(string name, string title)
        {
            Name = name;
            Title = title;
            _permissions = new List<Permission>();
        }
        #endregion

        #region Properties

        public string Name { get; private set; }
        public string Title { get; private set; }

        private readonly List<Permission> _permissions;
        public IReadOnlyCollection<Permission> Permissions => _permissions;


        #endregion

        #region Behaviours

        public void AssignPermission(Permission permission)
        {
            _permissions.Add(permission);
        }

        public void RemovePermission(Permission permission)
        {
            _permissions.Remove(permission);
        }
        #endregion

        #region Validations
        public void ValidateUserPermission(Permission permission)
        {
            if (!_permissions.Contains(permission))
            {
                throw new UnauthorizedAccessException(ParrotTranslatorKeys.UserDoesNotHaveRequiredPermission);
            }
        }

        #endregion


    }
}
