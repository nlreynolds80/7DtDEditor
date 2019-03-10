using System.Collections.Generic;
using Domain;
using GameData.GamePaths;

namespace GameData.ConfigFiles
{
    public class EntityClassesFile : ConfigFile<entity_classes, Entities>
    {
        public override string Filename => "entityclasses.xml";

        public EntityClassesFile(IGamePaths gamePaths) : base(gamePaths) { }
    }
}
