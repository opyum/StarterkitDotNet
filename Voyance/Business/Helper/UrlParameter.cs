using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Business
{
    public class UrlParameter
    {
        public UrlParameter()
        {

        }
        public UrlParameter(string name, string value)
        {
            PropertyName = name;
            PropertyValue = value;
        }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
    }
}
