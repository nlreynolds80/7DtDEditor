using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    public class GamePaths
    {
        public string GameRoot => @"7 Days To Die";
        public string DataRoot => $@"{GameRoot}\Data";
        public string ConfigRoot => $@"{DataRoot}\Config";

        public string EntityClassesFilename => "entityclasses.xml";

        public string EntityClassesPath => $@"{ConfigRoot}\{EntityClassesFilename}";
    }
}
