using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib, mis hinde kasutaja sai
            //kui kasutaja sai "A", konsool kuvab"Suureparane!"
            //"B", konsool kuvab "Vaga hea!";
            //"C", konsool kuvab "Hea!";
            //"D", konsool kuvab "Rahuldav!;
            //"E", konsool kuvab "Kasin!";
            //"F", konsool kuvab "Puudulik!";
            //kui kasutaja sisestab midagi muud siis konsool kuvab "vale vaartus"


            Console.WriteLine("Sisesta oma hinne:");
            //char = character

            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Suureparane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Vaga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }

            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin!");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik!");
            }

            else
            {
                Console.WriteLine("Vale vaartus!");
            }

        }
    }
}
