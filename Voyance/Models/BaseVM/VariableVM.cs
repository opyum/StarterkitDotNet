using Commun.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Models
{
    public class VariableVM : IdVM
    {
        [Required]
        public string Token { get; set; }
        public string Value { get; set; }
        [EnumDataType(typeof(TypeVariableEnum))]
        public TypeVariableEnum Type { get; set; }
        public bool IsActive { get; set; }
        public bool IsSensitive { get; set; }
        public MetaEntityTypeEnum MetaEntityType { get; set; }
    }
}
