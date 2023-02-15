using System;

namespace Inlämning6_3
{
    class program
    {
        static void Skrivmeny()
        {
            Console.WriteLine("Välj ett av följande alternativ:");
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största talet av två tal");
            Console.WriteLine("3. Avsluta programmet");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen, välj i menyn nedan");

            string menysvar = "";
            
            while (menysvar != "3")
            {
                SkrivMeny();
                menysvar = Console.ReadLine();
                Console.WriteLine();

                switch (menysvar)
                {
                    case (1):
                        MenyvalAddera();
                        break;

                    case (2):
                        MenyvalStörstatalet();
                        break;

                    case (3):
                        break;
                }
                Console.WriteLine();

            }
        }

 

        static void MenyvalAddera()
        {
            Console.WriteLine("Skriv in tre tal");

            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());
            double tal3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{tal1} + {tal2} + {tal3}");
        }

        static void MenyvalStörstaTalet()
        {
            Console.WriteLine("Skriv in ett tal");

            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());   
            int störstatalet = Störst(tal1, tal2);

            Console.WriteLine("Det största talet är: " + störstatalet);
        }

        static int Störst(int tal1, int tal2)
        {

            if (tal1 == tal2)
            {
                return tal1 + tal2;
            }

            else if (tal1 < tal2)
            {
                return tal2;
            }

            else
            {
                return tal1;
            }
        }
    }
}