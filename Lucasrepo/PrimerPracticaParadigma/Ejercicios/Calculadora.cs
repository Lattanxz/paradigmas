using System;

namespace PrimerPracticaParadigma
{
    public enum Opciones 
    {
        Nada = 0,
        Sumar = 1,
        Restar = 2,
        Multiplicar = 3,
        Dividir = 4
    }

    public class Calculadora
    {
        private int nro1;
        private int nro2;
        private Action _accion;

        public Calculadora()
        {
            _accion = () => Console.WriteLine("No hay operación seleccionada.");
        }

        public void PedirNumeros()
        {
            nro1 = LeerNumeroValidado("Ingrese el primer número: ");
            nro2 = LeerNumeroValidado("Ingrese el segundo número: ");
        }

        private int LeerNumeroValidado(string mensaje)
        {
            int numero;
            while (true)
            {
                Console.Write(mensaje);
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out numero))
                {
                    return numero;
                }
                
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
            }
        }

        public void CambiarOperacion(Action funcion)
        {
            _accion = funcion ?? throw new ArgumentNullException(nameof(funcion));
        }

        public void EjecutarFuncion()
        {
            _accion?.Invoke();
        }

        public void PedirOperacion()
        {
            Opciones opt = Opciones.Nada;
            while (opt == Opciones.Nada)
            {
                Console.WriteLine("\nSeleccione una operación:");
                foreach (Opciones c in Enum.GetValues(typeof(Opciones)))
                {
                    if (c != Opciones.Nada)
                        Console.WriteLine($"{(int)c} {c}");
                }

                string input = Console.ReadLine();
                if (int.TryParse(input, out int num) && Enum.IsDefined(typeof(Opciones), num))
                {
                    opt = (Opciones)num;
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                }
            }

            _accion = opt switch
            {
                Opciones.Sumar => Sumar,
                Opciones.Restar => Restar,
                Opciones.Multiplicar => Multiplicar,
                Opciones.Dividir => Dividir,
                _ => () => Console.WriteLine("Operación no soportada.")
            };
        }
        
        private void Sumar() => Console.WriteLine($"{nro1} + {nro2} = {nro1 + nro2}");
        private void Restar() => Console.WriteLine($"{nro1} - {nro2} = {nro1 - nro2}");
        private void Multiplicar() => Console.WriteLine($"{nro1} * {nro2} = {nro1 * nro2}");
        
        private void Dividir()
        {
            if (nro2 == 0)
            {
                Console.WriteLine($"{nro1} / {nro2} = Error: No se puede dividir por cero.");
            }
            else
            {
                Console.WriteLine($"{nro1} / {nro2} = {nro1 / nro2}");
            }
        }
    }
}