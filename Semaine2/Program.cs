//Exercice notion 1 


using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Diagnostics;
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



while (true)
{
    Console.WriteLine("Hello World !");
    Console.WriteLine("1.Ajouter des couples Pays / Capitale");
    Console.WriteLine("2.Rechercher une capitale à partir d'un Pays");
    Console.WriteLine("3.Afficher tout les couples Pays / Capitale");

    menuNav = Convert.ToInt32(Console.ReadLine());

    switch (menuNav)
    {
        case 1:

            while (true)
            {

                Console.WriteLine("Donne moi un Pays et un capitale ou tapez fin pour revenir au menu principal");

                Console.Write("Un Pays ? ");
                pays = Console.ReadLine();

                if (pays == "fin")
                {
                    break;
                }
                else
                {
                    Console.Write("Une Capitale ? ");
                    capitale = Console.ReadLine();
                    paysCapital.Add(pays, capitale);
                }

            }
            Console.Clear();
            break;

        case 2:


            while (true)
            {
                Console.Clear();

                Console.WriteLine("Donne moi le nom d'un pays et trouvons sa capitale ou tapez fin pour revenir au menu principal");
                pays = Console.ReadLine();

                if (pays == "fin")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("la capitale est : " + paysCapital[pays]);
                    Console.ReadKey();
                }
            }
            break;


        case 3:

            Console.Clear();

            Console.WriteLine("Voici tout les couples de Pays / Capitale enregistrer");

            foreach (KeyValuePair<string, string> pair in paysCapital)
            {
                Console.WriteLine(pair.Key, pair.Value);
            }



            break;


    }*/




//Exercice 5


/*    int[] entiers = { 1, 3, 4, 6, 9 };

    List<string> prenoms = new List<string> { "Hazel", "Loïc", "Cédric", "Amine" };
    //prenoms.Add("Hazel");
    //prenoms.Add("Loïc");
    //prenoms.Add("Cédric");
    //prenoms.Add("Amine");

    Dictionary<string, string> paysCapitale = new Dictionary<string, string>
    {
        ["France"] = "Paris",
        ["Espagne"] = "madrid",
        ["Belgique"] = "bruxelles"
    };

    int compteurElement = 0;

    foreach (int entier in entiers)
    {
        compteurElement++;
        Console.Write($"{entier} ");
    }
    ;

    Console.WriteLine();

    int compteurPrenoms = 0;
    foreach (string prenom in prenoms)
    {
        compteurElement++;
        compteurPrenoms++;
        Console.Write($"{compteurPrenoms} : {prenom} ");
    }
    ;

    Console.WriteLine();

foreach (var pair in paysCapitale)
{
    compteurElement++;
    Console.WriteLine($"{pair.Key} : {pair.Value}");
};

Console.WriteLine();
Console.WriteLine(compteurElement);*/





// LES FONCTIONS EN C#

//Pascal case -> Fonctions / Méthode (VoiciUnPascalCase)

//Camel case -> Variables (voiciUnCamelCase)

//Snake_case -> Dossier / fichier (voici_un_snake_case)

//kebab-case -> Dossier / fichier (voici-un-kebab-case)

//UPPER CASE -> Constantes (VOICIUNUPPERCASE)


// Exercice 1


/*static void AfficherSeprateur()
{
    Console.WriteLine(new string('-', 30));
}

AfficherSeprateur();*/


//Exercice 2

int a;
int b;

Console.WriteLine("Entrer deux nombres, je vais les additionner");
Console.WriteLine("Le premier nombre : ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Le deuxieme nombre : ");
b = Convert.ToInt32(Console.ReadLine());

static int Additionner(int a, int b)
{
    int resultat = a + b;
    return resultat;
}
Console.WriteLine("Le résultat est " + Additionner(a, b));



Console.WriteLine("entre un nombre est voyons si il est pair : ");
int nombre = Convert.ToInt32(Console.ReadLine());

static bool EstPair(int nombre)
{
    return nombre % 2 == 0;
}

Console.WriteLine(EstPair(nombre));

Console.WriteLine();


static double CalculerPrixTTC(double prixHT, double tauxTVA = 0.20)
{
    return prixHT + prixHT * tauxTVA;
}

Console.WriteLine(CalculerPrixTTC(55, 0.20));