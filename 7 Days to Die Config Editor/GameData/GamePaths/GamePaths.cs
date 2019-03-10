namespace GameData.GamePaths
{
    public class GamePaths : IGamePaths
    {
        public string GameRoot => @"7 Days To Die";
        public string DataRoot => $@"{GameRoot}\Data";
        public string ConfigRoot => $@"{DataRoot}\Config";
    }
}
