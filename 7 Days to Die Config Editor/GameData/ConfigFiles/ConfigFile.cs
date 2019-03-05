using GameData.GamePaths;
using System.Collections.Generic;

namespace GameData.ConfigFiles
{
    public abstract class ConfigFile
    {
        private readonly IGamePaths _gamePaths;

        public abstract string Filename { get; }

        public virtual string FullPath => $@"{_gamePaths.ConfigRoot}\{Filename}";

        protected ConfigFile(IGamePaths gamePaths)
        {
            _gamePaths = gamePaths;
        }
    }

    public abstract class ConfigFile<T> : ConfigFile
    {
        public abstract IEnumerable<T> Data { get; }

        protected ConfigFile(IGamePaths gamePaths) : base(gamePaths) { }
    }
}
