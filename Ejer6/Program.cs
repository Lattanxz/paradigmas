namespace Ejer6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;
            string nombre = "Martin", apellido = "Gomez";
            int resulMay, resulMen;
            if (BuscarPlus(a, b, out resulMay, out resulMen) == true)
            {
                Console.WriteLine(resulMay);
                Console.WriteLine(resulMen);
            }
            else
            {
                Console.WriteLine("Los numeros son iguales");
            }

            if (BuscarPlus2(nombre, apellido, out string completo) == true)
            {
                Console.WriteLine(completo);
            }

                Console.ReadKey();

        }

        
        static bool BuscarPlus(int x, int y, out int may, out int men)
        {
            bool okey;
            if (x == y)
            {   
                may = 0;
                men = 0;
                okey = false;
            }
            else
            {
                okey = true;
                if (x > y)
                {
                    may = x;
                    men = y;
                }
                else
                {
                    may = y;
                    men = x;
                }
            }
            return okey;
        }

        static bool BuscarPlus2(string apellido, string nombre, out string completo)
        {
            bool ok;
            if (apellido == string.Empty)
            {                
                ok = false;
                completo = string.Empty;
            }
            else if (nombre == string.Empty)
            {
                ok = false;
                completo = string.Empty;
            }
            else
            {
                ok = true;
                completo = $"{apellido}, {nombre}";

            }
            return ok;
        }
    }

        /* static void buscar(int x, int y, out int may, out int men)
        {
            if (x > y)
            {
                may = x;
                men = y;
            }
            else
            {
                may = y;
                men = x;
            }
        }*/
    }
