using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace BloodPressureLogApp.BAL
{
    public class UserOutput : IXmlSerializable
    {
        public User User { get; set; }
        public List<Entry> AllUserData { get; set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("user");
            writer.WriteElementString("username", User.UserName);
            writer.WriteElementString("name", User.Name);
            writer.WriteEndElement();

            writer.WriteStartElement("entries");
            foreach (var entry in AllUserData)
            {
                writer.WriteStartElement("entry");
                writer.WriteElementString("date", entry.Date.ToString("yyyy-MM-dd HH:mm:ss"));
                writer.WriteElementString("sys", entry.Sys.ToString());
                writer.WriteElementString("dia", entry.Dia.ToString());
                writer.WriteElementString("pulse", entry.Pulse.ToString());
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }
    }
}
