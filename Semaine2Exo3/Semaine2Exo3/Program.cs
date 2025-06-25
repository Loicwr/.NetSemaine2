namespace Semaine2Exo3
{
    internal class Program
    {                                                              //EXERCICE 3

       static int Multiplier(int a, int b)
        {
            return a * b;
        }


        static int Multiplier(int a, int b, int c)
        {
            return a * b * c;
        }

        static int Multiplier(int[] tableau)
        {
            int somme = 1;
            foreach (int n in tableau)
            {
                somme = n * somme;
            }

            return somme;
        }


        static void Main(string[] args)
        {

            Console.WriteLine(Multiplier(2, 3));
            Console.WriteLine(Multiplier(2, 3, 4));

            int[] tableau = new int[] { 2, 3, 4 };
            Console.WriteLine(Multiplier(tableau));

        }                                                   //EXERCICE 3


        
       
        

       






        
    }
}