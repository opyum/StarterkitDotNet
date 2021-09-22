using Commun.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Models
{
    public class MessageVM 
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public string InnerException { get; set; }
        public SeverityEnum Severity { get; set; }
    }
}
