using Domain;
using Services.Extensions;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Services.Serializers
{
    public class XmlSerializationService : ISerializationService
    {
        public Result<T> Deserialize<T>(string source) where T : class
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                using (var sourceStream = source.GetStream())
                using (var xmlTextReader = new XmlTextReader(sourceStream))
                {
                    return Result.Ok((T)xmlSerializer.Deserialize(xmlTextReader));
                }
            }
            catch(Exception ex)
            {
                return Result.Fail<T>(ex.Message);
            }
        }

        public Result<string> Serialize<T>(T source) where T : class
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                using (var memoryStream = new MemoryStream())
                {
                    xmlSerializer.Serialize(memoryStream, source);
                    return Result.Ok(memoryStream.ReadToString());
                }
            }
            catch(Exception ex)
            {
                return Result.Fail<string>(ex.Message);
            }
        }
    }
}
