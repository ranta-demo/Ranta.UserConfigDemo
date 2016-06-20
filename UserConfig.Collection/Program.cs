using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace UserConfig.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Students student = (Students)ConfigurationManager.GetSection("students");

            Console.Read();
        }
    }
}
