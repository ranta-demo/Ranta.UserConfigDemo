using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace UserConfig.Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = (Student)ConfigurationManager.GetSection("Student");

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Birth);

            Console.Read();
        }
    }
}
