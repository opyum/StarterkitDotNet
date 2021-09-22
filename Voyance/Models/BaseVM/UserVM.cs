using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Models
{
    public class UserVM : AuditVM
    {
        public string DisplayName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string UserPrincipalName { get; set; }
        public string SamAccountName { get; set; }
        public Guid? AzureObjectIdentifier { get; set; }
        public string FullName { get { return LastName + " " + FirstName; } }
    }
}
