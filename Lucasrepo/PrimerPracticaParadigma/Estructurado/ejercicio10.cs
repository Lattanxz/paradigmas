namespace PrimerPracticaParadigma;

public class ejercicio10
{

    public static void Actividad(int[] datos)
    {
        for (int i = 0; i < datos.Length - 1; i++)
        {
            for (int j = i + 1; j < datos.Length; j++)
            {
                int aux;
                if (datos[i] > datos[j])
                {
                    aux = datos[i];
                    datos[i] = datos[j];
                    datos[j] = aux;
                }
            }
        }
    }

    public static void Mostrar(int[] datos)
    {
        foreach (int dato in datos)
        {
            Console.WriteLine($"Datos: {dato}");
        }
    }

    public static void duplicarVariable(int a)
    {
        a *= 2;
    }

    public static void mostrarVariable(int a)
    {
        Console.WriteLine($"Valor de a: {a}");
    }
}