using System.IO;
using System.Xml.Serialization;

namespace Common
{
    public class XmlUtil
    {
        private XmlSerializer serializer;
        
        private string file;

        public XmlUtil(XmlSerializer s,string f)
        {
            serializer = s;
            file = f;
        }


        public void Write(object o)
        {
            using (StreamWriter sw = new StreamWriter(file))
            {
                serializer.Serialize(sw, o);
            }
        }

        public object Read()
        {
            using (StreamReader sr = new StreamReader(file))
            {
                return serializer.Deserialize(sr);
            }
        }
    }
}
