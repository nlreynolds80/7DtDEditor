using GameData.GamePaths;

namespace GameData.ConfigFiles
{
    public class EntityClasses : ConfigFile
    {
        public override string Filename => "entityclasses.xml";

        public EntityClasses(IGamePaths gamePaths) : base(gamePaths) { }
    }
}
