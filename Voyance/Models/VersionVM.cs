using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Models
{
    public class VersionVM : AuditVM
    {
        public string Label { get; set; }
        public bool IsActive { get; set; }
        public int? IdGroup { get; set; }
    }
}
