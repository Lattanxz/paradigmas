namespace PrimerPracticaParadigma;

public class Persona
{
    public static bool nombreCompleto(string nombre,string apellido, out string nombre_completo)
    {
        nombre_completo = string.Empty;
        
        if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
        {
            Console.WriteLine("Porfavor no envie valores vacios");
            return false;
        }
        nombre_completo = string.Concat(nombre, ", ",apellido);
        return true;
    }
}