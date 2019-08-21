using System;

namespace SwimmingHallTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Velkommen til svømmehallens billetsystem. ");
            Console.WriteLine("Vi har billetter til voksen, børn også en familien billet");
            Console.WriteLine("Angiv ønskes type. Voksen: V");
            Console.WriteLine("Angiv ønskes type. Børnebillet: B");
            Console.WriteLine("Angiv ønskes type. Familiebillet: F");




            string typebillet = Console.ReadLine();

            // priser
            double child = 30;
            double adult = 65;
            double familie = 100;
            double total;
            double totalrabat;

            switch (typebillet.ToLower())
            {
                case "v":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Du har valgt voksenbillet, hvor mange ønskes der?");
                    string antaladult = Console.ReadLine();
                    double antalvoksen = float.Parse(antaladult);
                    total = antalvoksen * adult;
                    Console.Write("Din pris er ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(total);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" kr");
                    break;
                case "b":
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine("Du har valgt børnebillet, hvor mange ønskes der?");
                    string antalchild = Console.ReadLine();
                    double antalbarn = float.Parse(antalchild);

                    if (antalbarn > 10)
                    {
                        total = antalbarn * child;
                        totalrabat = total - (total * 0.10);


                        Console.Write("Din pris er ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(totalrabat);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" kr");

                    }
                    else
                    {
                        total = antalbarn * child;
                        Console.Write("Din pris er ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(total);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" kr");
                    } 
                    break;
                case "f":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Du har valgt familiebillet, som er 2x voksen og 2x børn, hvor mange ønskes der?");
                    string antalfam = Console.ReadLine();
                    double antalfamilie = float.Parse(antalfam);
                    total = antalfamilie * familie;
                    Console.Write("Din pris er ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(total);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(" kr");
                    break;
                default:
                    Console.WriteLine("FORKERT");
                    break;
            }
        }
    }
}
