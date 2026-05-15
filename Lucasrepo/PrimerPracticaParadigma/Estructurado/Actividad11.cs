namespace PrimerPracticaParadigma;

public static class Actividad11
{
    public static int[] numeros = new int[15];

    public static void ingresarNums()
    {
        algoritmos10.IngresarNumeros(numeros);
    }

    public static void obtenerMayorYPos()
    {
        int mayor = numeros[0];
        int pos = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
                pos = i;
            }
        }

        Console.WriteLine($"Mayor: {mayor}, Su posicion es numeros[{pos}]");
    }
    
}