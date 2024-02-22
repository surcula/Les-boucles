
#region Demo
/*
 * 
 * Affiche 10x coucou avec une boucle while,
 * dans cette boucle crée une boucle for qui dira for + un nombre incrémenté
 * puis rajoute un do while dans la boucle for
 */

int i = 0;
while (i < 10)
{
    Console.WriteLine("Coucou");
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine("for " + j);
        if ( j == 2)
        {
            Console.WriteLine("J'ai faim !");
        }
        do
        {
            Console.WriteLine("Je suis dans la boucle do while");
        } while (false);
    }
    i++;
}
#endregion

#region Exo01

/*
 * Définissez un mot de passe au préalabe
 * demander a l'utilisateur son mot de passe
 * si le mot de passe entré est correcte : afficher "bienvenue"
 * si l'utilisateur se trompe 3 fois, lui suggérer de rentrer chez lui
 * 
 * */

string psw = "chacha";
string pswUser = "";
bool flag = true;
int compteur = 1;

do
{
    Console.WriteLine("Veuillez rentrer votre mot de passe");
    pswUser = Console.ReadLine();
    if( pswUser == psw) 
    { 
        Console.WriteLine("Bienvenue"); 
        flag = false;
    }
    if(compteur == 3)
    {
        Console.WriteLine("Veuillez rentrer à la maison");
        flag = false;
    }
    compteur++;

} while (flag);


#endregion

#region Exo02
/*
 * Afficher les tables de multiplications 
 * */

for (int j = 0; j <= 10; j++)
{
    for (int k = 0; k <= 10; k++)
    {
        Console.WriteLine($" {j} * {k} = {j*k}");
    }
}

#endregion

#region exo03
/*
 * 
 *Un magasin en ligne propose 3 articles
 *coca = 1€ (stock 4)
 *Sandwich = 5€ (stock2)
 *Porte = 200€ (stock3)
 *
 *Tant que l'utilisateur veut continuer ses achats, le programme continue de lui propose la liste des articles
 *en stock et lui demande de faire son choix (1 2 3)
 *
 *Quand il choisit d'arreter le programme affiche le total à payer
 * 
 */

int cocaPrice = 1;
int cocaStock = 4;
int sandwichPrice = 5;
int sandwichStock = 2;
int portePrice = 200;
int porteStock = 3;
string userKey = "";
int total = 0;


while ((cocaStock != 0 || sandwichStock !=0 || porteStock !=0) && userKey != "4")
{
    userKey = "";


    if(cocaStock > 0 && sandwichStock > 0 && porteStock > 0)
    {
        Console.WriteLine("Veuillez choisir un article à ajouter à votre panier : 1 : Coca, 2 : Sandwich, 3 : Porte, 4 : quit");
    }else if (sandwichStock > 0 && porteStock > 0)
    {
        Console.WriteLine("Veuillez choisir un article à ajouter à votre panier : 2 : Sandwich, 3 : Porte, 4 : quit");
    }
    else if(porteStock > 0)
    {
        Console.WriteLine("Veuillez choisir un article à ajouter à votre panier : 3 : Porte, 4 : quit");
    }
    else
    {
        Console.WriteLine("Tous les articles sont en ruptures de stock. Veuillez taper 4 pour quitter.");
    }
    userKey = Console.ReadLine();
    switch (userKey)
    {
        case "1":
            if (cocaStock > 0)
            {
                cocaStock--;
                total += cocaPrice;
            }else
            {
                Console.WriteLine("Désolé le coca est Hors stock, Veuillez choisir autre chose.");
            }
            
            break;
        case "2":
            if(sandwichStock > 0)
            {
                sandwichStock--;
                total += sandwichPrice;
            }else
            {
                Console.WriteLine("Désolé le sandwich est Hors stock, Veuillez choisir autre chose.");
            }
            break;
        case "3":
            if (porteStock > 0)
            {
                porteStock--;
                total += portePrice;
            }else
            {
                Console.WriteLine("Désolé la porte est Hors stock, Veuillez choisir autre chose.");
            }
            break;
        case "4": 
            break;
        default:
            Console.WriteLine("Erreur, veuillez encoder une bonne valeur.");   
            break;
    }
}

Console.WriteLine($"Voici le total de la facture : {total}");
#endregion
