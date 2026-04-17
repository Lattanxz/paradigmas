using System.Runtime.CompilerServices;

namespace PrimerPracticaParadigma;

internal class Program
{
    
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        calc.PedirOperacion();
        calc.PedirNumeros();
        calc.EjecutarFuncion();
    }
}