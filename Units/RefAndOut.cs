using System;

namespace Units
{
    public class RefAndOut
    {
        public void Out(out int a)
        {
            // nie można wywołać, bo może nie mieć wartości
            // Console.WriteLine(a);

            // nie można wyjść, bo trzeba przypisać wartość
            // return;

            a = 77;
        }

        public void Ref(ref int a)
        {
            Console.WriteLine("aaa " + a);
            a = 77;
        }
    }
}
