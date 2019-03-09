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
        public string Get(string filePath)
        {
            var userIsolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly();
            using (var userIsolatedStorageStream = new IsolatedStorageFileStream(filePath, FileMode.OpenOrCreate, userIsolatedStorageFile))
            {
                return userIsolatedStorageStream.ReadToString();
            }
        }

        public void Save(string data, string filePath)
        {
            var userIsolatedStorageFile = IsolatedStorageFile.GetUserStoreForAssembly();
            using (var userIsolatedStorageStream = new IsolatedStorageFileStream(filePath, FileMode.Create, userIsolatedStorageFile))
            using (var streamWriter = new StreamWriter(userIsolatedStorageStream))
            {
                streamWriter.Write(data);
                streamWriter.Flush();
            }
        }
    }
}
