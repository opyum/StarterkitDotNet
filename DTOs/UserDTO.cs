using System;
using System.Text.Json.Serialization;

namespace DTOs
{
    public class UserDTO : IdDTO
    {
        public string DisplayName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string UserPrincipalName { get; set; }
        public string SamAccountName { get; set; }
        public Guid? AzureObjectIdentifier { get; set; }
    }
}