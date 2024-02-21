namespace yatzee
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Renés roderi :
            Console.WriteLine("Velkommen til Yatzee!");

            Console.WriteLine("Spiller 1, skriv dit navn og afslut med Enter:");
            string spiller1 = Console.ReadLine();

            Console.WriteLine("Spiller 2, skriv dit navn og afslut med Enter:");
            string spiller2 = Console.ReadLine();


            Console.WriteLine(spiller1 + " kast terningerne med Enter!");
            Console.ReadLine();
            {
                int terning1, terning2, terning3, terning4, terning5;
                Random r = new Random();
                terning1 = r.Next(1, 6);
                terning2 = r.Next(1, 6);
                terning3 = r.Next(1, 6);
                terning4 = r.Next(1, 6);
                terning5 = r.Next(1, 6);
                Console.WriteLine(spiller1 + " du har slået: " + terning1 + ", " + terning2 + ", " + terning3 + ", " + terning4 + " & " + terning5);
            }

            //if (input < 9)
            //{
            //    // Input is less than 9.
            //    System.Console.WriteLine(
            //        "Tic-tac-toe has more than {0}" +
            //         " maximum turns.", input);
            //}

            Console.ReadLine();

        }
    }
}
