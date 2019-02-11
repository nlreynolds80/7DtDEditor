using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Property
    {
        public List<Property> Properties { get; private set; } = new List<Property>();
        public string Name { get; }
        public string Value { get; set; }
        public string Param { get; set; }
        public string Class { get; set; }

        public Property(string name)
        {
            Name = name;
        }

        public void SetProperties(List<Property> properties)
        {
            Properties = properties ?? new List<Property>();
        }
    }
}
