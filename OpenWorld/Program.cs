using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stores all of the objects, environments, and beings, maybe more objective knowledge as well
            var Being1 = new Being();
            Console.WriteLine(Being1.getSenses());

            Console.ReadKey();
        }
    }
}
