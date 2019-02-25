using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Services.Extensions
{
    public static class StringExtensions
    {
        public static Stream GetStream(this string source)
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
