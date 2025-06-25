namespace Semaine2Exercice8
{
    internal class Program
    {
        static void Main(string[] args)
        {



            static void Traiter(int a, int b, int c)
            {
                // calcule quelque chose
                int x = a + b + c;
                Console.WriteLine(x);
                // calcule autre chose
                if (a > 0 && b > 0 && c > 0)
                    Console.WriteLine("Tous positifs");
                // encore autre chose         
                Console.WriteLine($"Moyenne = {(a + b + c) / 3}");

            }



            int Additionner(int a, int b, int c)
            {
                int somme = a + b + c;
                return somme;
            }

            bool SontTousPositifs(int a, int b, int c)
            {
                return (a > 0 && b > 0 && c > 0) ? true : false;
            }

            double Moyenne(int a, int b, int c)
            {
                double moyenne = (a + b + c) / 3;
                return moyenne;
            }

            void AfficherEnConsole(int a, int b, int c)
            {
                Console.WriteLine(Additionner(a, b, c));
                Console.WriteLine(SontTousPositifs(a, b, c));
                Console.WriteLine(Moyenne(a, b, c));
            }

            AfficherEnConsole(1, 2, 3);

        }
    }
}     
    






    

