using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Ejer5
{
    internal class Program
    {
        public static int total = 0;
        public static int resultado = 0;
        static void Main(string[] args)
        {

            int nroA, nroB;

            string cadena, operador;


            Console.WriteLine("Ingresar primer nro");
            cadena = Console.ReadLine();
            while (int.TryParse(cadena, out nroA) == false)
            {
                Console.WriteLine("Reingresar primer nro");
                cadena = Console.ReadLine();
            }

            Console.WriteLine("Ingresar segundo nro");
            cadena = Console.ReadLine();
            while (int.TryParse(cadena, out nroB) == false)
            {
                Console.WriteLine("Reingresar segundo nro");
                cadena = Console.ReadLine();
            }

            Console.WriteLine("Ingresar operador (+,-,*,/)");
            operador = Console.ReadLine();
            while (operador != "*" && operador != "-" && operador != "+" && operador != "/")
            {
                Console.WriteLine("Reingresar operador (+,-,*,/)");
                operador = Console.ReadLine();
            }

            try
            {
                MostrarResultado(nroA, nroB, operador, total);

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();
        }


        static void MostrarResultado(int nroA, int nroB, string operador, int total)
        {
            switch (operador)
            {
                case "*":
                    {
                        total = multiplicar(nroA, nroB);
                        Console.WriteLine($"Multiplicacion: {total}");
                        break;
                    }
                case "+":
                    {
                        total = sumar(nroA, nroB);
                        Console.WriteLine($"Suma: {total}");
                        break;
                    }
                case "-":
                    {
                        total = restar(nroA, nroB);
                        Console.WriteLine($"Resta: {total}");
                        break;
                    }
                case "/":
                    {
                        total = dividir(nroA, nroB);
                        Console.WriteLine($"División: {total}");
                        break;
                    }
            }



            static int sumar(int a, int b)
            {
                int resultado;
                resultado = a + b;
                return resultado;
            }

            static int restar(int a, int b)
            {
                int resultado;
                resultado = a - b;
                return resultado;
            }

            static int multiplicar(int a, int b)
            {
                int resultado;
                resultado = a * b;
                return resultado;
            }

            static int dividir(int a, int b)
            {
                int resultado;

                if (b != 0)
                {
                    resultado = a / b;

                }
                else
                {
                    Exception err = new Exception("No se puede dividir por cero");
                    throw err;
                }
                return resultado;
            }

        }
    }
}
