using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mangus osaleb kaks mangijat - arvuti (cpu) ja kasutaja (user);
            //molemad mangijad viskavad taringuid
            //programm kontrollib, kumb mangija viskas rohkem
            //mangija kes viskab rohkem, ongi mangu voitja
            // taringuid visatakse kolm korda
            //programm kuulutab voitjat

            Random rnd = new Random();
           
            //int i = 0;
            
            //while(i < 3)
            for (int i = 0; i < 3; i++)

            {

                // arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise 
                int userRandom = rnd.Next(1, 7);


                int cpuScore = 0;
                int userScore = 0;
              

                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja on mangu voitnud. Palju onne!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti on mangu voitnud.");
                    cpuScore = cpuScore + 1;

                }
                else
                {
                   
                    Console.WriteLine("Viik!");

                }

              
                Console.WriteLine($"Arvuti skoor:{cpuScore} ja kasutaja skoor:{userScore}");
                
                   
                 
                
                
            }

           
        }
    }
}
