namespace Semaine2Exercice6
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            int[] tableau = new int[] {5, 8 , 13};

            AnalyseNombres(tableau);
        }

        static void AnalyseNombres(int[] tableau)
        {
            
            bool EstPair(int x)
            {
                return x % 2 == 0;
            }
            
            foreach(int nombre in tableau)
            {

                if (EstPair(nombre))
                {
                    Console.WriteLine($"{nombre} est pair");
                }
                else
                {
                    Console.WriteLine($"{nombre} est impair");
                }

                                    
            }  

        }
    }
}
