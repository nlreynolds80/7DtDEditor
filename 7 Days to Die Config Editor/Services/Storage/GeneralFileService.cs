using Services.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Services.Storage
{
    public class GeneralFileService : ILocalFileService
    {
        public string Get(string filePath)
        {
            using (var file = File.OpenRead(filePath))
            {
                return file.ReadToString();
            }
        }

        public void Save(string data, string filePath)
        {
            using (var file = File.OpenWrite(filePath))
            using (var streamWriter = new StreamWriter(file))
            {
                streamWriter.Write(data);
                streamWriter.Flush();
            }
        }
    }
}
