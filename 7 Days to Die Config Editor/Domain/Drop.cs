using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Drop
    {
        public string Name { get; }
        public string Event { get; set; }
        public string Count { get; set; }
        public string ToolCategory { get; set; }
        public string Tag { get; set; }

        public Drop(string name)
        {
            Name = name;
        }
    }
}
