using Domain;
using Services.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class EntityMapper : IMapper<entity_classesEntity_class, Entity>
    {
        private readonly IMapper<entity_classesEntity_classDrop, Drop> _dropMapper;
        private readonly IMapper<entity_classesEntity_classEffect_group, EffectsGroup> _effectsMapper;
        private readonly IMapper<property, Property> _propertyMapper;

        public EntityMapper(IMapper<entity_classesEntity_classDrop, Drop> dropMapper, IMapper<entity_classesEntity_classEffect_group, EffectsGroup> effectsMapper, IMapper<property, Property> propertyMapper)
        {
            _dropMapper = dropMapper;
            _effectsMapper = effectsMapper;
            _propertyMapper = propertyMapper;
        }

        public entity_classesEntity_class Convert(Entity domainSource)
        {
            var xmlEntity = new entity_classesEntity_class()
            {
                name = domainSource.Name,
                extends = domainSource.Extends,
                property = domainSource.Properties.Count > 0 ? domainSource.Properties.Select(p => _propertyMapper.Convert(p)).ToArray() : null,
                effect_group = domainSource.Effects.Count > 0 ? domainSource.Effects.Select(e => _effectsMapper.Convert(e)).ToArray() : null,
                drop = domainSource.Drops.Count > 0 ? domainSource.Drops.Select(d => _dropMapper.Convert(d)).ToArray() : null
            };
            return xmlEntity;
        }

        public Entity Convert(entity_classesEntity_class xmlSource)
        {
            var entity = new Entity()
            {
                Name = xmlSource.name,
                Extends = xmlSource.extends,
                Properties = xmlSource.property?.Select(p => _propertyMapper.Convert(p))?.ToList() ?? new List<Property>(),
                Effects = xmlSource.effect_group?.Select(e => _effectsMapper.Convert(e))?.ToList() ?? new List<EffectsGroup>(),
                Drops = xmlSource.drop?.Select(d=>_dropMapper.Convert(d))?.ToList() ?? new List<Drop>()
            };
            return entity;
        }
    }
}
