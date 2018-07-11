using System;
using System.IO;

namespace OutsideInDevelopment
{
    internal class FileChecker
    {
        internal static bool IsReadableFile(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    File.ReadAllText(path);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else return false;
        }
    }
}