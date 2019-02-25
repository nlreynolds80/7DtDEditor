using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    public static class GamePaths
    {
        public static string GameRoot => @"7 Days To Die";
        public static string DataRoot => $@"{GameRoot}\Data";
        public static string ConfigRoot => $@"{DataRoot}\Config";

        public static string EntityClassesFilename => "entityclasses.xml";

        public static string EntityClassesPath => $@"{ConfigRoot}\{EntityClassesFilename}";
    }
}
