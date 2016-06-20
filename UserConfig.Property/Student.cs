using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace UserConfig.Property
{
    /// <summary>
    /// 学生
    /// </summary>
    public class Student : ConfigurationSection
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return this["name"].ToString(); }
            set { this["name"] = value; }
        }

        /// <summary>
        /// 年龄
        /// </summary>
        [ConfigurationProperty("Age", IsRequired = true)]
        public int Age
        {
            get { return Convert.ToInt32(this["Age"]); }
            set { this["Age"] = value; }
        }

        /// <summary>
        /// 生日
        /// </summary>
        [ConfigurationProperty("birth", IsRequired = false, DefaultValue = "2014-11-8")]
        public DateTime Birth
        {
            get { return Convert.ToDateTime(this["birth"]); }
            set { this["birth"] = value; }
        }

        #region Validator
        [ConfigurationProperty("fileName", DefaultValue = "default.txt", IsRequired = false, IsKey = false)]
        [StringValidator(InvalidCharacters = " ~!@#$%^&*()[]{}/;'\"|\\", MinLength = 1, MaxLength = 60)]
        public string FileName
        {
            get { return (string)this["fileName"]; }
            set { this["fileName"] = value; }
        }

        [ConfigurationProperty("variable", IsRequired = false)]
        [RegexStringValidator("()|([a-zA-Z]+[a-zA-Z0-9]*)")]
        public string Variable
        {
            get { return this["variable"].ToString(); }
            set { this["variable"] = value; }
        }

        [ConfigurationProperty("maxUsers", DefaultValue = (long)10000, IsRequired = false)]
        [LongValidator(MinValue = 1, MaxValue = 10000000, ExcludeRange = false)]
        public long MaxUsers
        {
            get { return (long)this["maxUsers"]; }
            set { this["maxUsers"] = value; }
        }

        [ConfigurationProperty("maxIdleTime", DefaultValue = "0:10:0", IsRequired = false)]
        [TimeSpanValidator(MinValueString = "0:0:30", MaxValueString = "5:00:0", ExcludeRange = false)]
        public TimeSpan MaxIdleTime
        {
            get { return (TimeSpan)this["maxIdleTime"]; }
            set { this["maxIdleTime"] = value; }
        }
        #endregion
    }
}
