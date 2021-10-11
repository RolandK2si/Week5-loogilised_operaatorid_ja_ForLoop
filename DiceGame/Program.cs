using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid
            //programm kontrollib, kumb mängija viskas parema tulemuse
            //mängija, kes sai parema tulemuse on võitja
            //*täringuid visatakse kolm korda
            //programm kuulutab võitja

            Random rnd = new Random();

            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);

                Console.WriteLine($"Arvuti viskas {cpuRandom}, kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mängu võitnud");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }
            if(userScore > cpuScore)
            {
                Console.WriteLine("Kasutaja on võitja. Palju õnne!");
            }
            else if(userScore < cpuScore)
            {
                Console.WriteLine("Arvuti on võitja. Palju õnne!");
            }
            else
            {
                Console.WriteLine("Tulemus on viik!");
            }
            
           
        }
    }
}
