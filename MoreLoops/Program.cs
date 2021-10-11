using System;

namespace MoreLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kasutajatunnus ja salasona
            //kui sisestatud kasutajatunnus on "asmin" ja sisestatud salasona on "admin1234"
            //siis konsoolis kuvatatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatatkse "Vale kasutajatunnus voi salasona. Proovi uuesti"

            Console.WriteLine("Sisesta kasuatajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasona:");
            string userPassword = Console.ReadLine();


            //AND voi OR
            //"admin" AND "admin1234" --> true
            //"admin1" AND "admin1234" --> false
            //"admin" AND "admin12345" --> false
            //"admin1" AND "admin123" --> false

            if(userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");

            }
            else
            {
                Console.WriteLine("Vale kasutajatunnus voi salasona. Proovi uuesti.");
            }
        }
    }
}
