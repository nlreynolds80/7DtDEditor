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

        public MapperFactory(IMapper<entity_classes, Entities> entitiesMapper)
        {
            _entitiesMapper = entitiesMapper;
        }

        public IMapper<X, T> GetMapper<X, T>(ConfigFile<X, T> config)
        {
            switch (config)
            {
                case EntityClasses c:
                    return (IMapper<X, T>)_entitiesMapper;
                default:
                    throw new ArgumentException(
                        message: "No mapper supported for config",
                        paramName: nameof(config));
            }
        }
    }
}
