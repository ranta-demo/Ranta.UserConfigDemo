using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace UserCofig.Element
{
    public class Teacher : ConfigurationSection
    {
        [ConfigurationProperty("basic", IsRequired = true)]
        public BasicInfo BasicInfo
        {
            get { return (BasicInfo)this["basic"]; }
            set { this["basic"] = value; }
        }

        [ConfigurationProperty("extend", IsRequired = false)]
        public ExtendedInfo ExtendInfo
        {
            get { return (ExtendedInfo)this["extend"]; }
            set { this["extend"] = value; }
        }
    }

    public class BasicInfo : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return this["name"].ToString(); }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("age", IsRequired = true)]
        public int Age
        {
            get { return Convert.ToInt32(this["age"]); }
            set { this["age"] = value; }
        }
    }

    public class ExtendedInfo : ConfigurationElement
    {
        [ConfigurationProperty("phone", IsRequired = false)]
        public string Phone
        {
            get { return this["phone"].ToString(); }
            set { this["phone"] = value; }
        }
    }
}
