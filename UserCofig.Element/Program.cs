using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace UserCofig.Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = (Teacher)ConfigurationManager.GetSection("teacher");

            Console.Read();
        }
    }
}
