﻿// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Diagnostics;

string titre = "Harry Potter Game";

Debug.WriteLine("==> Je teste " + titre);

#region Framework du projet
//Affiche les crédits sur la console
void AffichageCredits()
{
    Console.WriteLine("************");
    Console.WriteLine("Sylvain le malin");
    Console.WriteLine("2024-02-08");
    Console.WriteLine("************");

}

void AfficherForce()
{
    Console.WriteLine("De quel coté de la force seras tu ?");
    Console.WriteLine("1. Du coté lumineux");
    Console.WriteLine("2. Du coté obscur");
    Console.WriteLine("3. Neutre");
}

int AfficheForcesEtRetourneSelection()
{
    AfficherForce();
    string saisieForce = Console.ReadLine();
    int typeForce = int.Parse(saisieForce);

    return typeForce;
}

int[,] PrepareGrilleDuJeu()
{
    int positionJoueur = 1;

    int[,] positions = new int[10, 20];

    return positions;
}

void AfficherItemMenu(string itemMenu, int indexMenu = 1)
{
    string format = "{0}. {1}";
    Console.WriteLine(format, indexMenu, itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());
}


String SaisieAge()
{
    bool ageSaisiPasValide = true;
    string ageSaisi = "";

    do
    {
        Console.WriteLine("Quel est ton âge ?");
        ageSaisi = Console.ReadLine();
        ageSaisiPasValide = string.IsNullOrWhiteSpace(ageSaisi);

    } while (ageSaisiPasValide);
    return ageSaisi;
}


bool AgeIsValid(string ageSaisi, int agePlayer)
{

    bool ageIsValid = false;

    agePlayer = int.Parse(ageSaisi);

    int ageMinimum = 12;

    int comparaison = agePlayer.CompareTo(ageMinimum);

    //Console.WriteLine(comparaison);

    ageIsValid = comparaison >= 0;

    return ageIsValid;
}

bool VerifierAge(string ageSaisi)
{
    int agePlayer = 0;
    agePlayer = int.Parse(ageSaisi);

    bool ageValid = AgeIsValid(ageSaisi, agePlayer);

    if (ageValid)
    {
        string message = "";

        if (agePlayer < 18)
        {
            message = "Attention, tu n'es pas majeur !";
        }
        else if (agePlayer < 40)
        {
            message = "Ça va, t'es pas trop vieux encore !";
        }
        else
        {
            message = "Ah oui, tu as au moins 40 ans quand même !";
        }
        Console.WriteLine(message);

        return true;

    } else {

        return false;
    }
}

string SaisirDate()
{
    Console.WriteLine("quelle est ta date de naissance ? ");

    return Console.ReadLine();
}

void AfficherDateNaissance()
{
    bool formatDateCorrect = false;

    while (!formatDateCorrect)
    {
        string dateDeNaissanceSaisie = SaisirDate();

        try
        {
            DateTime dateEtHeureDeNaissance = DateTime.Parse(dateDeNaissanceSaisie);
            DateOnly dateDeNaissance = DateOnly.FromDateTime(dateEtHeureDeNaissance);
            Console.WriteLine("ta date des naissance est le : " + dateDeNaissance);
            formatDateCorrect = true;

        }
        catch (FormatException)
        {
            Console.WriteLine(" vous n'avez pas saisi au bon format la date  !");
        }
    }


}

void AfficherForceChoisie(int typeForce)
{
    const int forceLumineuse = 1;
    const int forceObscure = 2;
    const int neutre = 3;


    switch (typeForce)
    {
        case forceLumineuse:
            {
                Console.WriteLine("tu as choisi le coté lumineux");
            }
            break;
        case forceObscure:
            {
                Console.WriteLine("tu as choisi le coté obscur");
            }
            break;
        case neutre:
            {
                Console.WriteLine("tu n'as pas choisi ton camp !");
            }
            break;
        default:
            {
                Console.WriteLine("tu n'as rien choisi !");
            }
            break;
    }
}

string ChoisirArmeEtRetourneSelection()
{
    float puissanceArme = 10;
    puissanceArme = 15.5f;

    while (true)
    {
        Console.WriteLine("Choisissez votre arme pour démarrer le jeu :");

        string[] tabArme = {"baguette", "couteau", "flingue", "bombe nucléaire"};
 

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"{i + 1}.  {tabArme[i]}");

        }
        try
        {
            string saisieArme = Console.ReadLine();
            int typeArme = int.Parse(saisieArme) - 1;
            return tabArme[typeArme];
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("tu as saisi une arme qui n'existe pas !!!");
            Console.WriteLine("");
        }
        catch (FormatException)
        {
            Console.WriteLine("Tu dois entrer un nombre !");
            Console.WriteLine("");

        }
    }

    return null;

}

void AfficherArmeChoisie(string arme)
{

    const string message = "Vous avez choisi un(e) ";

    Console.WriteLine(message + arme);
}

#endregion

#region MENU
// ------------------  MENU -----------------

Console.WriteLine("********");
Console.WriteLine("* MENU *");
Console.WriteLine("********");
Console.WriteLine("");
AffichageCredits();
////chaine complete
//string itemMenu = "nouvelle partie";
//Console.WriteLine(string.Format(format, 1, itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower()));

////on enleve string.Format , il est la en implicite
//itemMenu = "charger une partie";
//Console.WriteLine(format, 2, itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());


////interpollation
//itemMenu = "crédits";
//Console.WriteLine($"{3}. {itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower()}");


AfficherItemMenu("Nouvelle Partie");
AfficherItemMenu("Charger une Partie", 2);
AfficherItemMenu("Crédits", 3);
AfficherItemMenu("Quitter", 4);



string choixMenuSaisi = Console.ReadLine();

int choixMenu = int.Parse(choixMenuSaisi);

Console.WriteLine("vous avez selectionnez le menu " + choixMenu);

#endregion

#region ----- SAISIE INFORMATION JOUEUR/JOUEUSE ----------

string ageSaisi = SaisieAge();
bool verifierAge  =  VerifierAge(ageSaisi);

if (verifierAge) { 

    AfficherDateNaissance();

    #region -----  PREPARATION ARME ------
    string arme = ChoisirArmeEtRetourneSelection();
    AfficherArmeChoisie(arme);
    #endregion

    #region  ----- CHOIX CAMP ------
    int typeForce = AfficheForcesEtRetourneSelection();
    AfficherForceChoisie(typeForce);
    #endregion

    #region ---- MOTEUR DE JEU ----
    int[,] grilleJeu = PrepareGrilleDuJeu();
    #endregion

    #region ----- AFFICHAGE CREDITS -----
    AffichageCredits();
    #endregion

}
else
{
    Console.WriteLine("Tu n'as pas l'age requis !!!!!");
    Console.WriteLine(" BYE BYE !!!");
}

#endregion

