﻿using System.IO;

namespace Installer.Core.FileSystem
{
    public static class FileSystemMixin
    {
        public static string GetBcdFullFilename(this Volume self)
        {
            return Path.Combine(self.RootDir.Name, "EFI", "Microsoft", "Boot", "BCD");
        }
    }
}