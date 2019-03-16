namespace GameData.GamePaths
{
    public class GamePaths : IGamePaths
    {
        public string DataRoot => "Data";
        public string ConfigRoot => $@"{DataRoot}\Config";
    }
}
