namespace PrimerPracticaParadigma;

public class algoritmos10
{
    //se ingresan 5 numeros, al terminar informar cuales y cuantos de ellos superan el promedio de los mismos

    public static void IngresarNumeros(int[] numeros)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            int num;
            while (true)
            {
                Console.Write($"Numero en la pos {i}: ");
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("ingrese un numero valido");
                }
                else
                {
                    numeros[i] = num;
                    break;
                }
            }
        }
    }

    public static void MostrarPromedio(int[] numeros)
    {
        Console.WriteLine($"Promedio es: {CalcularPromedio(numeros)}");
    }
    private static int CalcularPromedio(int[] numeros)
    {
        int acum = 0;
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            acum += numeros[i];
        }
        return acum / numeros.Length;
    }

    private static bool esMayorAlProm(int num, int prom)
    {
        return num > prom;
    }

    public static int[] cualesSuperanProm(int[] numeros)
    {
        int promedio = CalcularPromedio(numeros);
        int[] mayores = new int[numeros.Length];
        foreach (int num  in numeros)
        {
            if (esMayorAlProm(num, promedio))
                mayores.Append(num);
        }

        return mayores;
    }

    public static void mostrarMayores(int[] mayores)
    {
        foreach (var VARIABLE in mayores)
        {
            Console.WriteLine(VARIABLE);
        }
    }

    public static void EjecutarTodo(int[] numeros)
    {
        MostrarPromedio(numeros);
        Console.WriteLine();
        int[] mayores = cualesSuperanProm(numeros);
        mostrarMayores(mayores);
    }
}