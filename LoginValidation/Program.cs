using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnuse ja salasõna
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "Admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."
            //kasutajal on kolm katset

            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Sisest kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string userPassword = Console.ReadLine();

                if(userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine("Palun proovi uuesti.");
                }
                if (i == 3)
                {
                    Console.WriteLine("Sinu sisselogimis katsed on läbi.");
                }
            }



        }
    }
}
