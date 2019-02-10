using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Property
    {
        public List<Property> Properties { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Param { get; set; }
        public string Class { get; set; }
    }
}
