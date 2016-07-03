using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>{ 1, 5, 2, 6, 3, 9, 10, 11, 0 };
            InversionCounter inv = new InversionCounter(list);
            int nr;
            nr = inv.GetInversion();
            Console.WriteLine(nr);
        }
    }
}
