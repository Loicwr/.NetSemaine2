//Exercice notion 1 


using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

/*int[] notes = { 10, 12, 15, 8 };
double somme = 0;

if (!(notes.Length == 0)) 
{ 
*//*    for(int i = 0; i < notes.Length; i++)
    {
        somme += notes[i];
        Console.WriteLine(somme);
    };*//*

    foreach(int n in notes)
    {
        somme += n;
    }
}
else
{
    Console.WriteLine("Erreur , le tableau est vide");
}

double moyenne = somme / notes.Length;
Console.WriteLine(moyenne);*/

//Exercice notion 2


/*int[] tableauEntier = { 1, 2, 3, 10, 13, 18 };


Console.WriteLine($"La moyenne est de : { tableauEntier.Average()}");
Console.WriteLine(tableauEntier.Min());
Console.WriteLine(tableauEntier.Max());*/


//Exercice notion 3


/*List<string> prenoms = new List<string>();
prenoms.Add("Hazel");
prenoms.Add("Moi");
prenoms.Add("Cédric");
prenoms.Add("Amine");

prenoms.Sort();
Console.WriteLine(string.Join(" ", prenoms));//string.join pour afficher ma liste (" mon séparateur ici ", ce que je veux afficher)
Console.WriteLine(prenoms.Contains("Hazel"));//variable.Contains("") connaitre sur mon objet et déjà dans ma liste
*/


//Exercice notion 4

/*Dictionary<string, string> paysCapital = new Dictionary<string, string>();
string pays;
string capitale;
int menuNav;

Console.WriteLine("Hello World !");
Console.WriteLine("1.Ajouter des couples Pays / Capitale");
Console.WriteLine("2.Rechercher une capitale à partir d'un Pays");
Console.WriteLine("3.Afficher tout les couples Pays / Capitale");

while (true)
{
    

    menuNav = Convert.ToInt32(Console.ReadLine());

    switch (menuNav)
    {
        case 1 :
   
            Console.WriteLine("Donne moi un Pays et un capitale ou tapez fin pour arrêter");
            Console.Write("Un Pays ? ");
            pays = Console.ReadLine();

            Console.Write("Une Capitale ? ");
            capitale = Console.ReadLine();
            break;
            
        case 2:
            Console.WriteLine("Donne moi unou tapez fin pour arrêter");
            break;





    }
    
}

*/











