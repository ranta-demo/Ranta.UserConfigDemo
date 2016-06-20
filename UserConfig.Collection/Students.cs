using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace UserConfig.Collection
{
    public class Students : ConfigurationSection
    {
        private static readonly ConfigurationProperty property =
            new ConfigurationProperty(string.Empty, typeof(StudentCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);

        [ConfigurationProperty("", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
        public StudentCollection StudentCollection
        {
            get
            {
                return (StudentCollection)base[property];
            }
        }
    }

    public class StudentCollection : ConfigurationElementCollection
    {
        public StudentCollection() :
            base(StringComparer.OrdinalIgnoreCase)
        {
        }

        public Student this[string name]
        {
            get
            {
                return (Student)base.BaseGet(name);
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new Student();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((Student)element).Name;
        }
    }

    public class Student : ConfigurationElement
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
}
