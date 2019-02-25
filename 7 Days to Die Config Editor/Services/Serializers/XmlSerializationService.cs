using Services.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Services.Serializers
{
    public class XmlSerializationService : ISerializationService
    {
        public T Deserialize<T>(string source) where T : class
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var sourceStream = source.GetStream())
            using (var xmlTextReader = new XmlTextReader(sourceStream))
            {
                return xmlSerializer.Deserialize(xmlTextReader) as T;
            }
        }

        public string Serialize<T>(T source) where T : class
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var memoryStream = new MemoryStream())
            {
                xmlSerializer.Serialize(memoryStream, source);
                return memoryStream.ReadToString();
            }
        }
    }
}
