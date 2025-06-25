
namespace Semaine2Exercice9

{
    public static class NotesUtil
    {

       

        public static void Main()
        {


            Console.WriteLine("Combien de notes voulez-vous entrer ?");
                int nombreNotes = Convert.ToInt32(Console.ReadLine());

            int totalPoints = 0;
            

            for (int i = 0; i < nombreNotes; i++)
            {
                Console.WriteLine($"Entrez la note #{i + 1} sur 20 :");
                int entrerUtilisateur = Convert.ToInt32(Console.ReadLine());

                totalPoints += entrerUtilisateur;
            }







            double moyenne = CalculerMoyenne(totalPoints, nombreNotes);
            Console.WriteLine($"La moyenne est de : {moyenne}");

            int[] tableauNotes = new int[] { 20, 8, 6 };

            double moyenneTableau = CalculerMoyenne(tableauNotes);
            Console.WriteLine($"La moyenne du tableau est de : {moyenneTableau:F2}");
           
            
        }

        public static double CalculerMoyenne(int totalPoints, int nombreNotes)
        {
            double resultat = (double) totalPoints / nombreNotes;
            return resultat;
        }

        public static double CalculerMoyenne(int[] notes)
        {
            int sommeNotes = 0;

            foreach(int note in notes)
            {
                sommeNotes += note;
            }

            return CalculerMoyenne(sommeNotes, notes.Length);
            
            

        }
    }

}


