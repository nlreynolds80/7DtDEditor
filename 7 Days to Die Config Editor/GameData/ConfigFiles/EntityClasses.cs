using System.Collections.Generic;
using Domain;
using GameData.GamePaths;

namespace GameData.ConfigFiles
{
    public class EntityClasses : ConfigFile<entity_classes, Entities>
    {
        public override string Filename => "entityclasses.xml";

        public EntityClasses(IGamePaths gamePaths) : base(gamePaths) { }
    }
}
