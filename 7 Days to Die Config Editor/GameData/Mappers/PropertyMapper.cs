using Domain;
using System.Linq;

namespace GameData.Mappers
{
    public class PropertyMapper : IMapper<property, Property>
    {
        public property Convert(Property domainSource)
        {
            var xmlProperty = new property()
            {
                @class = domainSource.Class,
                name = domainSource.Name,
                param1 = domainSource.Param,
                value = domainSource.Value,
                property1 = domainSource.Properties.Count > 0 ? domainSource.Properties.Select(p => Convert(p)).ToArray() : null
            };
            return xmlProperty;
        }

        public Property Convert(property xmlSource)
        {
            var property = new Property(xmlSource.name)
            {
                Class = xmlSource.@class,
                Param = xmlSource.param1,
                Value = xmlSource.value
            };
            property.SetProperties(xmlSource.property1?.Select(p=>Convert(p))?.ToList());
            return property;
        }
    }
}
