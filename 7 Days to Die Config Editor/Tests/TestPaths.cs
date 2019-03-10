using GameData.GamePaths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class TestPaths : IGamePaths
    {
        public string GameRoot => null;

        public string DataRoot => null;

        public string ConfigRoot => $@"..\..\TestData";
    }
}
