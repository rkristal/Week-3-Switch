using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada tema lemmikvarv
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline"
            //kui kasutaja sisestab " sinine",konsool kuvab "oled töökas"
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber"
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled (userColor) ükssarvik"


            Console.WriteLine("Sisest oma lemmikvärv");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled tookas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sober.");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ukssarvik");
                    break;


            }




            Console.WriteLine("Kena paeva!");

        }
    }
}
