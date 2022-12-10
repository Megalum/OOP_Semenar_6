using System;

namespace Calc
{
    class View
    {
        public double getValue(string title)
        {            
            Console.Write(title);
            string imp = Console.ReadLine();
            return Convert.ToDouble(imp);
        }

        public char getCalc(string title)
        {
            Console.Write(title);
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return c;
        }

        public void print(double data, string title)
        {
            Console.WriteLine($"{title} {data}");
        }
    }
}
