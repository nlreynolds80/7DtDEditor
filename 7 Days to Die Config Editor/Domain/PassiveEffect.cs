using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class PassiveEffect
    {
        public string Name { get; set; }
        public string Operation { get; set; }
        public string Value { get; set; }
        public string Tags { get; set; }
        public string MatchAllTags { get; set; }
    }
}
