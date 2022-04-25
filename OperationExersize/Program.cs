using System;

namespace OperationExersize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 4;
            int y = 7;
            int answer = (x + y);
            Console.WriteLine(answer);

            int x1 = 12;
            int y1 = 6;
            int answer1 = (x1 - y1);
            Console.WriteLine(answer1);

            int x2 = 76;
            int y2 = 59;
            int answer2 = (x2 * y2);
            Console.WriteLine(answer2);

            int a = 57;
            int b = 5;
            int quoitent = (a / b);
            int remainder = (a % b);
            Console.WriteLine(quoitent);
            Console.WriteLine(remainder);
            Console.WriteLine($" {a} / {b} is  {quoitent}");
            Console.WriteLine($"the remainder of {a} % {b} is remainder {remainder}");





        }
    }
}
