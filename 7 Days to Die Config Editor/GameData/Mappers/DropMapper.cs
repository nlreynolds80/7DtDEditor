using Domain;

namespace GameData.Mappers
{
    public class DropMapper : IMapper<entity_classesEntity_classDrop, Drop>
    {
        public entity_classesEntity_classDrop Convert(Drop domainSource)
        {
            var drop = new entity_classesEntity_classDrop()
            {
                name = domainSource.Name,
                @event = domainSource.Event,
                count = domainSource.Count,
                tool_category = domainSource.ToolCategory,
                tag = domainSource.Tag
            };
            return drop;
        }

        public Drop Convert(entity_classesEntity_classDrop xmlSource)
        {
            var drop = new Drop(xmlSource.name)
            {
                Event = xmlSource.@event,
                Count = xmlSource.count,
                ToolCategory = xmlSource.tool_category,
                Tag = xmlSource.tag
            };
            return drop;
        }
    }
}
