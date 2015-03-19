using System.IO;

namespace Docu.IO
{
    public class FileSystemOutputWriter : IOutputWriter
    {
        public void WriteFile(string fileName, string content)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false, System.Text.Encoding.UTF8))
            {
                sw.Write(content);
            }
        }

        public void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }

        public bool Exists(string directory)
        {
            return Directory.Exists(directory);
        }
    }
}
