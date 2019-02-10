using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TriggeredEffect
    {
        public string Trigger { get; set; }
        public string Action { get; set; }
        public string Buff { get; set; }
        public string Target { get; set; }
        public string CVar { get; set; }
        public string Operation { get; set; }
        public string Value { get; set; }
        public string Event { get; set; }
    }
}
