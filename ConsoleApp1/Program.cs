using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Presenter p = new Presenter(new CalcModel(), new View());
            p.buttonClick();
            p.buttonClick();
            p.buttonClick();
            p.buttonClick();

            Console.ReadKey();
        }
    }
}
