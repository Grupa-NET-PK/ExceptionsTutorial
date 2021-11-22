using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HardException
    {
        public void DisplayValues()
        {
            foreach (var elem in values)
            {
                Console.WriteLine(elem);
            }
        }

        public HardException(int[] values) 
        {
            this.values = values.ToList();
        }

        public HardException()
        {
        }

        private List<int> values;
    }
}
