using System.IO;

namespace Docu.IO
{
    public class XmlLoader : IXmlLoader
    {
        public string LoadFrom(string xmlFileName)
        {
            using (StreamReader sr = new StreamReader(xmlFileName, true))
            {
                return sr.ReadToEnd();
            }
        }
    }
}
