using Commun.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Models
{
    public class ConfigFilesVM : IdVM
    {
        public string Path { get; set; }
        public string Extension { get; set; }
        public string FileName { get; set; }
        public string FullName { get { return (Path + "/" + FileName + Extension).Replace("//", "/"); } }
    }
}
