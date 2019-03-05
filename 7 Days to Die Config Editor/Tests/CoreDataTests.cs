using Domain;
using GameData.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Serializers;
using Services.Storage;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class CoreDataTests
    {
        //private T Deserialize<T>(string pathToXml) where T : class
        //{
        //    var xmlSerializer = new XmlSerializer(typeof(T));
        //    using (var xmlTextReader = new XmlTextReader(pathToXml))
        //    {
        //        return xmlSerializer.Deserialize(xmlTextReader) as T;
        //    }
        //}

        //private void Serialize<T>(T source, string path) where T : class
        //{
        //    var xmlSerializer = new XmlSerializer(typeof(T));
        //    using (var file = File.OpenWrite(path))
        //    {
        //        xmlSerializer.Serialize(file, source);
        //    }
        //}

        private EntityMapper GetEntityMapper()
        {
            var dropMapper = new DropMapper();
            var passiveEffectMapper = new PassiveEffectMapper();
            var effectRequirementMapper = new EffectRequirementMapper();
            var triggeredEffectMapper = new TriggeredEffectMapper(effectRequirementMapper);
            var effectsMapper = new EffectsGroupMapper(passiveEffectMapper, triggeredEffectMapper);
            var propertyMapper = new PropertyMapper();
            return new EntityMapper(dropMapper, effectsMapper, propertyMapper);
        }

        [TestMethod]
        public void Scratches()
        {
            //Arrange
            var pathToXml = @"../../TestData/entityclasses.xml";

            //Act
            var xmlSerializationService = new XmlSerializationService();
            var generalFileService = new GeneralFileService();
            var xml = generalFileService.Get(pathToXml);
            var entityClasses = xmlSerializationService.Deserialize<entity_classes>(xml);

            var entityMapper = GetEntityMapper();

            var entities = new List<Entity>();
            foreach (var item in entityClasses.Items)
            {
                var entity = item as entity_classesEntity_class;
                if (entity != null)
                {
                    entities.Add(entityMapper.Convert(entity));
                }
            }

            //Assert
            Assert.IsNotNull(entities);
            Assert.IsTrue(entities.Count > 0);
        }
    }
}
