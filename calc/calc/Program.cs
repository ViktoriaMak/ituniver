using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Calculator
    {
        public double FirstNum;
        public double SecondNum;
        public char Operator;

        public Calculator(double fn, char op, double sn)
        {
            FirstNum = fn;
            Operator = op;
            SecondNum = sn;            
        }
               
        public void Count()
        {
          
                double count;
                if (Operator == '+')
                {
                    count = FirstNum + SecondNum;
                    Console.WriteLine("Сумма = " + count);
                }
                else if (Operator == '-')
                {
                    count = FirstNum - SecondNum;
                    Console.WriteLine("Разность = " + count);
                }
                else if (Operator == '*')
                {
                    count = FirstNum * SecondNum;
                    Console.WriteLine("Произведение = " + count);
                }
                else if (Operator == '/')
                {
                    count = FirstNum / SecondNum;
                    Console.WriteLine("Частное = " + count);
                }
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите первое число: ");
                double a = Double.Parse(Console.ReadLine());
                Console.WriteLine("Введите оператор: ");
                char b = Char.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                double c = Double.Parse(Console.ReadLine());
                Calculator calculator = new Calculator(a, b, c);
                calculator.Count();
            
            Console.ReadKey();
        }
    }
}
