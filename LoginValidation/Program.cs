using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kasutajatunnus ja salasona
            //kui sisestatud kasutajatunnus on "asmin" ja sisestatud salasona on "admin1234"
            //siis konsoolis kuvatatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatatkse "Vale kasutajatunnus voi salasona. Proovi uuesti"
            //kasutajal kolm katset
            int i = 0;
            while (i < 3)

            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("Sisesta salasona:");
                string userPassword = Console.ReadLine();

                if (userName != "admin" || userPassword != "admin1234")


                {
                    i++;
                    Console.WriteLine($"Vale kasutajatunnus voi salasona. Proovi uuesti. {3 - i} katset on jaanud.");

                }
                else
                {
                    Console.WriteLine("Tere tulemast!");
                }



            }
        }
    }
}
