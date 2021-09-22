using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Models
{
    public class ConfigFilesVariableVM
    {
        public int LineIdentifier { get; set; }
        public ConfigFilesVM ConfigFile { get; set; }
        public List<VariableVM> ListVariable { get; set; }

    }
}
