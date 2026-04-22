namespace PrimerPracticaParadigma;

public class Actividad9
{
    public static void sumaTotal(int[] array, out int suma)
    {
        suma = 0;
        for (int i = 0; i < array.Length; i++)
        {
            suma += array[i];
        }
    }
}