using Domain;
using Services.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Services.Storage
{
    public class LocalFileService : IFileStorageService
    {
        public Result<string> Get(string filePath)
        {
            try
            {
                using (var file = File.OpenRead(filePath))
                {
                    return Result.Ok(file.ReadToString());
                }
            }
            catch(Exception ex)
            {
                return Result.Fail<string>(ex.Message);
            }
        }

        public Result Save(string data, string filePath)
        {
            try
            {
                using (var file = File.OpenWrite(filePath))
                using (var streamWriter = new StreamWriter(file))
                {
                    streamWriter.Write(data);
                    streamWriter.Flush();
                }
                return Result.Ok();
            }
            catch(Exception ex)
            {
                return Result.Fail(ex.Message);
            }
        }
    }
}
