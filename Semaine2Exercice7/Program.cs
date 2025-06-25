namespace Semaine2Exercice7
{
    internal class Program
    {
        static void Main(string[] args)
        {                                           //EXERCICE 7.1

            Func<int, int> triple = x => x * 3;

            Console.WriteLine(triple(10));

                                                    //EXERCICE 7.1


                                                    //EXERCICE 7.3

            List<int> nombres = new List<int> { 2, 5, 6, 7, 9 };

            nombres.RemoveAll(x => x % 2 != 0);

            Console.WriteLine(string.Join("-",nombres));
                                                    
                                                    //EXERCICE 7.3
        }       

    }
}
