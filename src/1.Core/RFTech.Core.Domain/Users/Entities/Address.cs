using System.Diagnostics.Metrics;
using System.IO;
using System.Reflection.Emit;
using Zamin.Core.Domain.Entities;

namespace RFTech.Core.Domain.Users.Entities
{
    public class Address : Entity
    {
        private Address()
        {
        }

        public Address(string? addressLine1, string? addressLine2, string? city, string? province, string? postalCode)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            Province = province;
            PostalCode = postalCode;

        }

        #region Constructors




        #endregion

        #region Properties

        public string? AddressLine1 { get; private set; }
        public string? AddressLine2 { get; private set; }
        public string? City { get; private set; }
        public string? Province { get; private set; }
        public string? PostalCode { get; private set; }

        #endregion

        #region Behaviours

        public void UpdateAddress(string? addressLine1, string? addressLine2, string? city, string? province, string? postalCode)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            Province = province;
            PostalCode = postalCode;
        }

        #endregion

        #region Validations


        #endregion
    }
}
