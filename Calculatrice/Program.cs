using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
       
        Console.WriteLine("Veuillez entrer un premier nombre");
        int nombre1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Veuillez entrer un deuxème nombre");
        int nombre2 = int.Parse(Console.ReadLine());

        AfficherMenu(); 
       
        int choix = int.Parse(Console.ReadLine());


        switch (choix)
        {
            case 1:
                Console.WriteLine($"Résultat de l'addition {nombre1} + {nombre2} = " + Addition(nombre1, nombre2));
                break;
            case 2:
                Console.WriteLine($"Résultat de la soustraction {nombre1} - {nombre2} = " + Soustraction(nombre1, nombre2));
                break;
            case 3:
                Console.WriteLine($"Résultat de la mutltiplication {nombre1} x {nombre2} = " + Multiplication(nombre1, nombre2));
                break;
            case 4:
                Console.WriteLine($"Résultat de la division {nombre1} : {nombre2} = " + Division(nombre1, nombre2));
                break; 
            default:
                Console.WriteLine("Veuillez choisir une opération");
                break;
        }

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

    public static int Addition(int nombre1, int nombre2)
    {
        return nombre1 + nombre2;
    }

    public static int Soustraction(int nombre1, int nombre2)
    {
        return nombre1 - nombre2;
    }

    public static int Multiplication(int nombre1, int nombre2)
    {
        return nombre1 * nombre2;
    }

    public static int Division(int nombre1, int nombre2)
    {
        return nombre1 / nombre2;
    }
}