using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Models
{
    public class ApplicationVM : AuditVM
    {
        [Required(AllowEmptyStrings = false, ErrorMessage ="Merci de saisir un libellé")]
        [StringLength(50)]
        [Display(Name = "Libellé")]
        public string Label { get; set; }
        public bool IsActive { get; set; }
        public int? IdGroup { get; set; }
    }
}
