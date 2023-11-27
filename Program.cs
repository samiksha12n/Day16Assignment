using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16AssignmentPart1
{
    internal class Program
    {
        public delegate int ArithmeticOperation(int n1, int n2);
        static void Main(string[] args)
        {
            Operations calc= new Operations();
            Console.WriteLine("Choose the Operation");
            Console.WriteLine("Enter first number");
            int number1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int number2=int.Parse(Console.ReadLine());
            Console.WriteLine("1.Addition 2.Substraction 3.Multiplication 4.Division");
            int op=int.Parse(Console.ReadLine());
            switch(op)
            {
                case 1:
                    {
                        ArithmeticOperation del = new ArithmeticException(calc.Add(number1,number2));
                        Console.WriteLine("After Addition : \t"+del);
                        break;
                    }
                case 2:
                    {
                        ArithmeticOperation del = new ArithmeticException(calc.Sub);
                        Console.WriteLine("After substraction: \t"+del);
                        break;
                    }
                case 3:
                    {
                        ArithmeticOperation del = new ArithmeticException(calc.Multi(number1, number2));
                        Console.WriteLine("After Multiplication:\t"+del);
                        break;
                    }
                case 4:
                    {
                        ArithmeticOperation del = new ArithmeticException(calc.Div(number1, number2));
                        Console.WriteLine("After division: \t" + del);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice!!!");
                        break;
                    }
            }
            Console.ReadKey();
            
        }
    }
}
