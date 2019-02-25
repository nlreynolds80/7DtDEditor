using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Services.Serializers
{
    class XmlSerializationService : ISerializationService
    {
        public T Deserialize<T>(string source) where T : class
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var sourceStream = StringToStream(source))
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
                return StreamToString(memoryStream);
            }
        }

        private string StreamToString(Stream source)
        {
            using(var streamReader = new StreamReader(source))
            {
                return streamReader.ReadToEnd();
            }
        }

        private Stream StringToStream(string source)
        {
            var memoryStream = new MemoryStream();
            var streamWriter = new StreamWriter(memoryStream);
            streamWriter.Write(source);
            streamWriter.Flush();
            memoryStream.Position = 0;
            return memoryStream;
        }
    }
}
