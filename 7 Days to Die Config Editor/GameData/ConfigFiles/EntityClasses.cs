using System.Collections.Generic;
using Domain;
using GameData.GamePaths;

namespace GameData.ConfigFiles
{
    public class EntityClasses : ConfigFile<Entity>
    {
        public override string Filename => "entityclasses.xml";

        public override IEnumerable<Entity> Data => throw new System.NotImplementedException();

        public EntityClasses(IGamePaths gamePaths) : base(gamePaths) { }
    }
}
