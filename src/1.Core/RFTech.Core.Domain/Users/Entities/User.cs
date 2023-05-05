using RFTech.Core.Domain.Blogs.Entities;
using RFTech.Core.Domain.Common.ParrotTranslators;
using System.Linq;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace RFTech.Core.Domain.Users.Entities
{
    public class User : AggregateRoot
    {

        #region Constructors

        private User() { }

        #endregion


        #region Properties

        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public string? UserName { get; private set; }

        //PhoneNumber and Email => VO 
        public string? Email { get; private set; }
        public string? PhoneNumber { get; private set; }

        public string Password { get; private set; }
        public bool IsActive { get; private set; }
        public bool IsEmailVerified { get; private set; }
        public bool IsPhoneNumberVerified { get; private set; }
        public UserProfile UserProfile { get; private set; }



        private readonly List<Role> _roles;
        public IReadOnlyCollection<Role> Roles => _roles;

        private readonly List<ActivityLog> _activityLogs;
        public IReadOnlyCollection<ActivityLog> ActivityLogs => _activityLogs;

        #endregion


        #region Methods
        public void UpdateUserProfile(UserProfile userProfile)
        {
            UserProfile = userProfile;
        }

        public void UpdatePassword(string password)
        {
            Password = password;
        }

        public void ResetPassword(string password)
        {
            //ToDo
        }
        public void UpdatePhoneNumber(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
        public void UpdateEmail(string email)
        {
            Email = email;
        }
        public void Activate()
        {
            IsActive = true;
        }

        public void Deactivate()
        {
            IsActive = false;
        }

        public void AssignRole(Role role)
        {
            _roles.Add(role);
        }

        public void RemoveRole(Role role)
        {
            _roles.Remove(role);
        }

      
        public void AddActivityLog(ActivityLog activityLog)
        {
            _activityLogs.Add(activityLog);
        }
        #endregion


        #region Business Rules
        public void ValidateUserStatus()
        {
            if (!IsActive)
            {
                throw new InvalidEntityStateException(ParrotTranslatorKeys.UserIsNotActive);

            }
            if (!IsEmailVerified || !IsPhoneNumberVerified)
            {
                if (!IsEmailVerified)
                    throw new InvalidEntityStateException(ParrotTranslatorKeys.EmailIsNotVerified);
                else
                    throw new InvalidEntityStateException(ParrotTranslatorKeys.PhoneNumberIsNotVerified);

            }

        }

        public void ValidateUserRole(Role role)
        {
            if (!_roles.Contains(role))
            {
                throw new UnauthorizedAccessException(ParrotTranslatorKeys.UserDoesNotHaveRequiredRole);
            }
        }
       
        #endregion
    }
}
