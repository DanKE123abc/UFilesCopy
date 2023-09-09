using System.IO;
using System.Security.Cryptography;
using UFilesCopy.Base;

namespace UFilesCopy.Code
{
    public class DirectoryManager
    {
        public static void CopyDirectory(string sourceDir, string destDir)
        {
            string[] files = Directory.GetFiles(sourceDir, "*", SearchOption.AllDirectories);
            int totalFiles = files.Length;
            int copiedFiles = 0;

            Directory.CreateDirectory(destDir);

            foreach (string file in files)
            {
                string relativePath = file.Substring(sourceDir.Length + 1);
                string destFile = Path.Combine(destDir, relativePath);
                string destDirOfFile = Path.GetDirectoryName(destFile);

                if (File.Exists(destFile))
                {
                    using (var sourceStream = File.OpenRead(file))
                    using (var destStream = File.OpenRead(destFile))
                    {
                        var sourceHash = MD5.Create().ComputeHash(sourceStream);
                        var destHash = MD5.Create().ComputeHash(destStream);

                        if (ByteArraysEqual(sourceHash, destHash))
                        {
                            continue;
                        }
                    }
                }

                Directory.CreateDirectory(destDirOfFile);
                File.Copy(file, destFile, true);

                copiedFiles++;
                float progress = (float)copiedFiles / totalFiles * 100;
                EventCenter.instance.EventTrigger(sourceDir, progress);
            }
        }

        private static bool ByteArraysEqual(byte[] a, byte[] b)
        {
            if (a == null && b == null)
            {
                return true;
            }

            if (a == null || b == null || a.Length != b.Length)
            {
                return false;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
