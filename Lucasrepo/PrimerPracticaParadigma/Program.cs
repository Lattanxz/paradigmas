using System.Runtime.CompilerServices;

namespace PrimerPracticaParadigma;

internal class Program
{
    
    static void Main(string[] args)
    {
        string nombre_completo;
        if (Persona.nombreCompleto("lucas", "martini", out nombre_completo))
        {
            Console.WriteLine($"Hola {nombre_completo}");
        }
        else
        {
            Console.WriteLine("No ingresaste un valor válido..");
        }
    }
}