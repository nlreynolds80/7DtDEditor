using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class GamePaths
    {
        public static string GameRoot { get; } = @"7 Days To Die";
        public static string DataRoot { get; } = $@"{GameRoot}\Data";
        public static string ConfigRoot { get; } = $@"{DataRoot}\Config";

        public static string EntityClassesFilename { get; } = "entityclasses.xml";

        public static string EntityClassesPath { get; } = $@"{ConfigRoot}\{EntityClassesFilename}";
    }
}
