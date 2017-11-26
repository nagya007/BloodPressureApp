using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace BloodPressureLogApp
{
    class XmlHandler
    {
        LogDbContext context;
        DbSet<User> users;
        DbSet<Entry> entries;
        public XmlHandler()
        {
            context = new LogDbContext();
            this.users = context.Users;
            this.entries = context.Entries;
        }
        public string LastError;
        List<User> userList = users.ToList();
        public bool WriteToXml(string filePath,DbSet<User> user)
        {
            try
            {
                using (FileStream fs =new FileStream(filePath,FileMode.Create))
                {
                    XmlSerializer xSerializer = new XmlSerializer(typeof(User));
                    xSerializer.Serialize(fs, users);
                    return true;
                }
            }
            catch (XmlException ex)
            {

                LastError = $"Xml deserialize:{ex.Message}";
                return false;
            }
        }

    }
}
