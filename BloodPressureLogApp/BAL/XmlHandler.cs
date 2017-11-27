using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data.Entity;

namespace BloodPressureLogApp.BAL
{
  public class XmlHandler
    {
        public XmlHandler(){}
        public string LastError;
        

        public bool WriteToXml<T>(string filePath, T userData) where T : class
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    XmlSerializer xSerializer = new XmlSerializer(typeof(T));
                    xSerializer.Serialize(fs, userData);
                    return true;
                }
            }
            catch (System.Xml.XmlException ex)
            {

                LastError = $"Xml deserialize:{ex.Message}";
                return false;
            }
        }
    }
}
