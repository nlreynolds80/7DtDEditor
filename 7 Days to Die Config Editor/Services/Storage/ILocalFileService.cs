using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Storage
{
    public interface ILocalFileService
    {
        string Get(string filePath);
        void Save(string data, string filePath);
    }
}
