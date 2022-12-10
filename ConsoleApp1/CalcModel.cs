using System;

namespace Calc
{
    public class CalcModel: CalcModelVariable, Model
    {
        public CalcModel() 
        {

        }

        public double result()
        {
            switch (calc)
            {
                case '+':
                    return x + y;
                case '-':
                    return x - y;
                case '/':
                    if (y != 0)
                        return x / y;
                    else
                        Console.WriteLine("Ошибка деления на ноль!");
                    return 0;                 
                case '*':
                    return x * y;
                case '^':
                    return Math.Pow(x, y);
                default:
                    Console.WriteLine("Операции несуществует!");
                    return 0;
            }
        }

        public void setX(double value)
        {
            x = value;
        }

        public void setY(double value)
        {
            y = value;
        }

        public void setCalc(char value)
        {
            calc = value;
        }
    }
}
