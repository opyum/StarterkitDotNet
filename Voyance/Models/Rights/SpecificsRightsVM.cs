using Commun.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Models
{
    public class SpecificsRightsVM : IdVM
    {
        public MetaEntityTypeEnum MetaEntityType { get; set; }
        public string MetaEntityTypeString { get { return MetaEntityType.ToString(); } }
        public EnvironnementVM Environnement { get; set; }
        public bool CanRead { get; set; }
        public bool CanWrite { get; set; }
        public bool CanClone { get; set; }
        public bool CanDelete { get; set; }
        public RoleVM Role { get; set; }
    }
}
