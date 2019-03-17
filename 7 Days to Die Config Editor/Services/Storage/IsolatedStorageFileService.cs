using Domain;
using Services.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Text;

namespace Services.Storage
{
    public class IsolatedStorageFileService : IFileStorageService
    {
        public Result<string> Get(string filePath)
        {
            try
            {
                var userIsolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly();
                using (var userIsolatedStorageStream = new IsolatedStorageFileStream(filePath, FileMode.OpenOrCreate, userIsolatedStorageFile))
                {
                    return Result.Ok(userIsolatedStorageStream.ReadToString());
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
                var userIsolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly();
                using (var userIsolatedStorageStream = new IsolatedStorageFileStream(filePath, FileMode.Create, userIsolatedStorageFile))
                using (var streamWriter = new StreamWriter(userIsolatedStorageStream))
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
