using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void plus()
        {
            Console.WriteLine("Введите первое число");
           int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine( a + b);
        }
        static void minus()
        {
            Console.WriteLine("Введите первое число");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine(a - b);
        }
        static void del()
        {
            Console.WriteLine("Введите первое число");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine(a / b);
        }
        static void multiply()
        {
            Console.WriteLine("Введите первое число");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine(a * b);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие: 1 сложение, 2 вычитание, 3 умножение, 4 деление");
            int res = Int32.Parse(Console.ReadLine());
            switch (res)
            {
                case 1:
                    {
                        plus();
                        
                    }
                    break;

                case 2:
                    {
                        minus();
                        break;
                    }
                case 3:
                    {
                        multiply();
                        break;
                    }
                case 4:
                    {
                        minus();
                        break;
                    }

            }

            Console.ReadKey();
        }
    }
}
