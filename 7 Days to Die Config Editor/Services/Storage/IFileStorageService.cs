using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Storage
{
    public interface IFileStorageService
    {
        Result<string> Get(string filePath);

        Result Save(string data, string filePath);
    }
}
