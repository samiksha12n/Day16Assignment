using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16AssignmentPart1
{
    internal class Program
    {
        internal delegate int ArithmeticOperation(int n1, int n2);
        static void Main(string[] args)
        {
            Operations Opertations= new Operations();
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
                        ArithmeticOperation del = new ArithmeticException(Opertations.Add( number1,number2));
                    }
            }
            
        }
    }
}
