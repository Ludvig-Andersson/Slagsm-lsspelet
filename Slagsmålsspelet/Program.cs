using System;

namespace Slagsmålsspelet
{
    class Program
    {
        static void Main(string[] args)
        {

           string play = "ja";

           while (play == "ja") { //ifall man vill starta om spelet efter det är slut
           
            string Karaktär = "Karaktär";
            string Göran = "Göran";
            int runda = 0;
            int HPB = 100;
            int HPG = 150;


            Random generator = new Random();

            Console.Clear();
            System.Console.WriteLine("Du ska slåss mot Göran");
            System.Console.WriteLine("Göran har 150 HP och du har nuvarande 100 HP.");
            System.Console.WriteLine("Tryck ENTER för att fortsätta");
            Console.ReadLine();

            Console.Clear();
            System.Console.WriteLine("Vilken karaktär vill du välja?");
            System.Console.WriteLine("a) Berit (Har med Health)");
            System.Console.WriteLine("b) Leif (Gör mer Damage)");
            System.Console.WriteLine("c) Gunbritt (Har bättre accuracy)");

            Karaktär = Console.ReadLine(); // här väljer man mellan tre olika karaktärer


            while (Karaktär != "a" && Karaktär != "b" && Karaktär != "c") //ifall man skrev något fel
            {
                System.Console.WriteLine("Du skrev inte in nån Ability, prova igen.");
                Karaktär = Console.ReadLine();
                

            }

            if (Karaktär == "a")
            {

                HPB = HPB + 50;

                System.Console.WriteLine("Ditt HP har ökat med 50 och du har nu " + HPB + " HP!");
                System.Console.WriteLine("Tryck ENTER för att fortsätta");

                Console.ReadLine();

                while (HPB > 0 && HPG > 0) // att om hp inte är högre än 0 så är spelet över
                {

                    Console.Clear();

                    runda = runda + 1;

                    System.Console.WriteLine("Runda:" + runda);

                    Console.ReadLine();

                    int random = generator.Next(8, 14);

                    HPB = HPB - random;

                    System.Console.WriteLine("Berit tog " + random + " i skada");

                    random = generator.Next(8, 14);

                    HPG = HPG - random;

                    System.Console.WriteLine(Göran + " tog " + random + " i skada");

                    System.Console.WriteLine(Göran + " HP " + HPG);
                    System.Console.WriteLine("Berit HP " + HPB);
                    System.Console.WriteLine("Tryck ENTER för att fortsätta");
                    Console.ReadLine();

                }



            }

            if (Karaktär == "b")
            {

                System.Console.WriteLine("Du gör mer damage nu");
                System.Console.WriteLine("Tryck ENTER för att fortsätta");

                Console.ReadLine();

                while (HPB > 0 && HPG > 0)
                {

                    Console.Clear();

                    runda = runda + 1;

                    System.Console.WriteLine("Runda:" + runda);

                    Console.ReadLine();

                    int random = generator.Next(8, 14);

                    HPB = HPB - random;

                    System.Console.WriteLine("Leif tog " + random + " i skada");

                    random = generator.Next(13, 19);

                    HPG = HPG - random;

                    System.Console.WriteLine(Göran + " tog " + random + " i skada");

                    System.Console.WriteLine(Göran + " HP " + HPG);
                    System.Console.WriteLine("Leif HP " + HPB);
                    System.Console.WriteLine("Tryck ENTER för att fortsätta");

                    Console.ReadLine();


                }

            }

            if (Karaktär == "c") //Gunbritt
            {

                System.Console.WriteLine("Du valde Gumbrit, du gör lite mer damage och får oftast bra träffar.");
                System.Console.WriteLine("Tryck ENTER för att fortsätta");
                Console.ReadLine();

                while (HPB > 0 && HPG > 0)
                {

                    Console.Clear();

                    runda = runda + 1;

                    System.Console.WriteLine("Runda:" + runda); //numret ökar med 1 för varje runda

                    Console.ReadLine();

                    int random = generator.Next(8, 14); 

                    HPB = HPB - random;

                    System.Console.WriteLine("Gunbritt tog " + random + " i skada");

                    random = generator.Next(15, 18); //den slumpar mellan 16-17

                    HPG = HPG - random; // HP minskar med antingen 16 eller 17 skada

                    System.Console.WriteLine(Göran + " tog " + random + " i skada");

                    System.Console.WriteLine(Göran + " HP " + HPG);
                    System.Console.WriteLine("Gunbritt HP " + HPB);
                    System.Console.WriteLine("Tryck ENTER för att fortsätta");

                    Console.ReadLine();


                }

            }



            if (HPB > HPG)
            {
                Console.Clear();
                System.Console.WriteLine("Grattis du slog Göran!!");
                System.Console.WriteLine("Det tog " + runda + " rundor");

            }

            if (HPB < HPG)
            {
                Console.Clear();
                System.Console.WriteLine("Tyvärr du förlorade!!");
                System.Console.WriteLine("Det tog " + runda + " rundor");
            }

            if (HPB == HPG) 
            {
                Console.Clear();
                System.Console.WriteLine("Det blev oavgjort!!");
                System.Console.WriteLine("Det tog " + runda + " rundor");
            }


            System.Console.WriteLine("Vill du spela igen? ja eller nej");

            play = Console.ReadLine();

            while (play != "ja" && play != "nej") { //ifall man skrev fel

                System.Console.WriteLine("Du skrev inte ja eller nej, prova igen");
                play = Console.ReadLine();
            }
            

           }


            Console.ReadLine();
        }
    }
}
