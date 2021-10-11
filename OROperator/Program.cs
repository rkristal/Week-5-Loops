using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kasutajatunnus ja salasona
            //kui sisestatud kasutajatunnus on "asmin" ja sisestatud salasona on "admin1234"
            //siis konsoolis kuvatatakse "Tere tulemast!"
            //muul juhul konsoolis kuvatatkse "Vale kasutajatunnus voi salasona. Proovi uuesti"


            //OR 

            // true  || true --> true
            // false || true --> true
            // true || false --> true
            // false || false --> false

            Console.WriteLine("Sisesta kasuatajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasona:");
            string userPassword = Console.ReadLine();

            if(userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus voi salasona. Proovi uuesti.");

            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
