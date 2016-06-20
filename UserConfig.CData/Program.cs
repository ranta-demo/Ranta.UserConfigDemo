using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace UserConfig.CData
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlCmd cmd = (SqlCmd)ConfigurationManager.GetSection("sqlcmd");

            Console.Read();
        }
    }
}
