using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Units;

namespace TrainingTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Orc orc = new Orc(40);
            Orc orc2 = new Orc(50);
            Orc orc3 = new Orc(50);


            orc.Shout();
            orc2.Shout("Alliance");
            orc3.Shout(2019);
            Console.WriteLine(orc._hitPoints);
            Console.WriteLine(orc2._hitPoints);

            Console.ReadKey();
        }
    }
}
