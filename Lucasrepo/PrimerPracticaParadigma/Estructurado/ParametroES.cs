namespace PrimerPracticaParadigma;

public class ParametroES
{
    public static void recibirParametroReferencia(ref int a, ref int b)
    {
        int aux;
        aux = a;
        a = b;
        b = aux;
    }
}