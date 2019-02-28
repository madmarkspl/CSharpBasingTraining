using System;
using Units;

namespace TrainingTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square();
            IShape[] shapes = { sq, new Triangle() };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Area());
            }

            RefAndOut aa = new RefAndOut();
            int x = 7;
            aa.Ref(ref x);
            Console.WriteLine(x);


            Console.ReadKey();
        }

        public struct MyStruct
        {
            public int value0;
            public double value1;
            public Square value2;
        }

    }
}
