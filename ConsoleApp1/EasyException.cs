using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EasyException
    {
        public static void ReadFile(string path)
        {
            var reader = new StreamReader(path);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }
    }
}
