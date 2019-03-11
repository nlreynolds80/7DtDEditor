using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using GameData.ConfigFiles;
using GameData.Mappers;

namespace Services.Factories
{
    public class MapperFactory : IMapperFactory
    {
        private readonly IMapper<entity_classes, Entities> _entitiesMapper;
        private readonly IMapper<entitygroups, EntityGroups> _entityGroupsMapper;

        public MapperFactory(IMapper<entity_classes, Entities> entitiesMapper, IMapper<entitygroups, EntityGroups> entityGroupsMapper)
        {
            _entitiesMapper = entitiesMapper;
            _entityGroupsMapper = entityGroupsMapper;
        }

        public IMapper<X, T> GetMapper<X, T>(ConfigFile<X, T> config)
        {
            switch (config)
            {
                case EntityClassesFile c:
                    return (IMapper<X, T>)_entitiesMapper;
                case EntityGroupsFile c:
                    return (IMapper<X, T>)_entityGroupsMapper;
                default:
                    throw new ArgumentException(
                        message: "No mapper supported for config",
                        paramName: nameof(config));
            }
        }
    }
}
