namespace Semaine2Exercice5
{
    internal class Program
    {
        void BonjourPersonnalise(string nom)
        {
            Console.WriteLine($"Bonjour {nom}");
        }
        static void BonjourGlobal()
        {
            Console.WriteLine("Bonjour les gens");
        }
        static void Main(string[] args)
        {
            Program.BonjourGlobal();
            Program program = new Program();
            program.BonjourPersonnalise("Alice");
        }
    }
}
