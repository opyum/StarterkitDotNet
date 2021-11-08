using System;
using System.Collections.Generic;
using System.Text;

namespace DTOs
{
    public class AdresseDTO : IdDTO
    {
        public string Libelle { get; set; }
        public string CodePostal { get; set; }

    }
}
