using Domain;
using GameData.GamePaths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData.ConfigFiles
{
    public class EntityGroupsFile : ConfigFile<entitygroups, EntityGroups>
    {
        public override string Filename => "entitygroups.xml";

        public EntityGroupsFile(IGamePaths gamePaths) : base(gamePaths) { }
    }
}
