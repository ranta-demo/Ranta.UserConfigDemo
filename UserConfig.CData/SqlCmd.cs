using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace UserConfig.CData
{
    public class SqlCmd : ConfigurationSection
    {
        [ConfigurationProperty("data", IsRequired = true)]
        public string Command
        {
            get { return this["data"].ToString(); }
            set { this["data"] = value; }
        }

        protected override bool SerializeElement(System.Xml.XmlWriter writer, bool serializeCollectionKey)
        {
            if (writer != null)
                writer.WriteCData(Command);
            return true;
        }

        protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey)
        {
            Command = reader.ReadElementContentAsString();
        }
    }
}
