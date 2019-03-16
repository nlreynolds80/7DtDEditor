using GameData.ConfigFiles;
using System.Collections.Generic;

namespace Services.Repositories
{
    public interface IGameDataRepository
    {
        T GetConfigData<X, T>(ConfigFile<X, T> config, string pathOverride = null) where X : class where T : class;

        void SaveConfigData<X, T>(ConfigFile<X, T> config, T data, string pathOverride = null) where X : class where T : class;
    }
}
