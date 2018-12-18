using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc orcus = new Orc("Sebixonus");

            orcus.LevelUp(1);
            Console.ReadKey();
            orcus.LevelUp(1);
            Console.ReadKey();
            orcus.LevelUp(10);
            Console.ReadKey();
            orcus.LevelUp(8);
            Console.ReadKey();
            orcus.LevelDown(1);
            Console.ReadKey();
            orcus.LevelUp(20);
            Console.ReadKey();
            orcus.LevelUp(20);
            Console.ReadKey();
            orcus.LevelUp(20);


            Console.ReadKey();
        }
    }
}
