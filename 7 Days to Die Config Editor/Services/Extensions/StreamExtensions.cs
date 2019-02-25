using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Services.Extensions
{
    public static class StreamExtensions
    {
        public static string ReadToString(this Stream source)
        {
            using (var streamReader = new StreamReader(source))
            {
                return streamReader.ReadToEnd();
            }
        }

    }
}
