using GameData.ConfigFiles;
using System.Collections.Generic;

namespace Services.Repositories
{
    public interface IGameDataRepository
    {
        T GetConfigData<X, T>(ConfigFile<X, T> config) where X : class where T : class;
    }
}
