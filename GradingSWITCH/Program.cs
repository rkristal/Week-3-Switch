using System;

namespace GradingSWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma hinne:");

            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch(userResult)
            {
                case 'A':
                    Console.WriteLine("Suureparane!");
                    break;
                case 'B':
                    Console.WriteLine("Vaga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav!");
                    break;
                case 'E':
                    Console.WriteLine("Kasin!");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik!");
                    break;
                default:
                    Console.WriteLine("Vale vaartus");
                    break;








            }
        }
    }
}
