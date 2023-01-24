using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        string rejouer;

        do
        {
            PropositionsActions();
            Console.WriteLine("Voulez-vous effectuer un nouveau calcul Si oui tapez \"oui\"?");
            rejouer = Console.ReadLine();
        } while (rejouer == "oui");


    }
    public static void AfficherMenu()
    {

        Console.Clear();
        Console.WriteLine("Veuillez choisir une opération : " +
          "\n 1. Addition " +
          "\n 2. Soustraction " +
          "\n 3. Multiplication " +
          "\n 4. Division ");


    }

    public static void PropositionsActions()
    {
        double nombre1, nombre2;

        Console.WriteLine("Entrez le premier nombre :");
        while (!double.TryParse(Console.ReadLine(), out nombre1))
        {
            Console.WriteLine("Entrée non valide. Veuillez entrer un nombre valide :");
        }

        Console.WriteLine("Entrez le deuxième nombre :");
        while (!double.TryParse(Console.ReadLine(), out nombre2))
        {
            Console.WriteLine("Entrée non valide. Veuillez entrer un nombre valide :");
        }

        AfficherMenu();
        string choix;

        do
        {
            AfficherMenu();
            choix = Console.ReadLine();

        } while (choix != "1" && choix != "2" && choix != "3" && choix != "4");




        switch (choix)
        {
            case "1":
                Console.WriteLine($"Résultat de l'addition {nombre1} + {nombre2} = " + Addition(nombre1, nombre2));
                break;
            case "2":
                Console.WriteLine($"Résultat de la soustraction {nombre1} - {nombre2} = " + Soustraction(nombre1, nombre2));
                break;
            case "3":
                Console.WriteLine($"Résultat de la mutltiplication {nombre1} x {nombre2} = " + Multiplication(nombre1, nombre2));
                break;
            case "4":
                Console.WriteLine($"Résultat de la division {nombre1} : {nombre2} = " + Division(nombre1, nombre2));
                break;
            default:
                Console.WriteLine("Veuillez choisir une opération");
                break;
        }
    }





    public static double Addition(double nombre1, double nombre2)
    {
        return nombre1 + nombre2;
    }

    public static double Soustraction(double nombre1, double nombre2)
    {
        return nombre1 - nombre2;
    }

    public static double Multiplication(double nombre1, double nombre2)
    {
        return nombre1 * nombre2;
    }

    public static double Division(double nombre1, double nombre2)
    {
        return nombre1 / nombre2;
    }
}
