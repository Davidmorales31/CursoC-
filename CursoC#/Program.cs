using System;
using System.Security.Cryptography.X509Certificates;

namespace Prueba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el numero 1 ");
            int numeroUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el numero 2 ");
            int numeroDos = Convert.ToInt32(Console.ReadLine());
            restaNumeros(numeroUno, numeroDos);
            sumaNumeros(numeroUno, numeroDos);
            divisionNumeros(numeroUno, numeroDos);
            moduloNumeros(numeroUno, numeroDos);

        }

        public static void restaNumeros(int numeroUno, int numeroDos)
        {
            string resouestaResta = Convert.ToString($"La resta de los numeros es {numeroUno - numeroDos}. ");
            Console.WriteLine(resouestaResta);
        }

        public static void sumaNumeros(int numeroUno, int numeroDos)
        {
            string resouestaResta = Convert.ToString($"La suma de los numeros es {numeroUno + numeroDos}. ");
            Console.WriteLine(resouestaResta);
        }
        public static void divisionNumeros(int numeroUno, int numeroDos)
        {
            string resouestaResta = Convert.ToString($"La division de los numeros es {numeroUno / numeroDos}. ");
            Console.WriteLine(resouestaResta);
        }

        public static void moduloNumeros(int numeroUno, int numeroDos)
        {
            string resouestaResta = Convert.ToString($"el Modulo de los numeros es {numeroUno % numeroDos}. ");
            Console.WriteLine(resouestaResta);
        }

    }
}

