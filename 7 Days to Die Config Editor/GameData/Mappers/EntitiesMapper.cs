using Domain;
using System.Linq;

namespace GameData.Mappers
{
    public class EntitiesMapper : IMapper<entity_classes, Entities>
    {
        private readonly IMapper<entity_classesEntity_class, Entity> _entityMapper;

        public EntitiesMapper(IMapper<entity_classesEntity_class, Entity> entityMapper)
        {
            _entityMapper = entityMapper;
        }

        public entity_classes Convert(Entities domainSource)
        {
            var entity_classes = new entity_classes();
            entity_classes.Items = domainSource.Select(e => _entityMapper.Convert(e.Value)).ToArray();
            return entity_classes;
        }

        public Entities Convert(entity_classes xmlSource)
        {
            var entities = new Entities();
            entities.AddRange(xmlSource.Items.Select(i => _entityMapper.Convert((entity_classesEntity_class)i)));
            return entities;
        }
    }
}
