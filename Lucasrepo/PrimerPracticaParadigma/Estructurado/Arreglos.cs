using System.Globalization;

namespace PrimerPracticaParadigma;

public class Arreglos
{
    //public int[] valores = { 1, 2, 3, 4, 5 };
    
    public static int[] valores = new int[5];

    public static void ejemplosDeClase()
    {
        valores[0] = 1; //Cargo un valor en la posicion 0
        valores[1] = 2; //Cargo un valor en la posicion 1
        valores[2] = 9; //Cargo un valor en la posicion 2
        valores[3] = 5; //Cargo un valor en la posicion 3
        valores[4] = 100005; //Cargo un valor en la posicion 4;
        int mayor = valores.Max();
        for (int i = 0; i < 5; i = i + 1)
        {
            Console.WriteLine($"El valor de la posicion {i} es {valores[i]}");
            if (i == 4)
            {
                Console.WriteLine($"El ultimo valor es: {valores[i]}");
            }
        }

        Console.WriteLine($"Mayor: {mayor}");
    }
}