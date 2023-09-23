using _8PiezasProyect.Interfaz;
using _8PiezasProyect.Piezas;
using System;

namespace _8PiezasProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            IPieza pieza = null;

            do
            {
                Console.WriteLine("Elija una pieza para resolver el problema de las 8 reinas:");
                Console.WriteLine("1. Rey");
                Console.WriteLine("2. Reina");
                Console.WriteLine("3. Torre");
                Console.WriteLine("4. Alfil");
                Console.WriteLine("5. Caballo");
                Console.WriteLine("6. Peón");

                // Leer la opción del usuario
                int opcion;
                if (int.TryParse(Console.ReadLine(), out opcion) && opcion >= 1 && opcion <= 6)
                {
                    switch (opcion)
                    {
                        case 1:
                            pieza = new Rey(0, 0);
                            break;
                        case 2:
                            pieza = new Reina(0, 0);
                            break;
                        case 3:
                            pieza = new Torre(0, 0);
                            break;
                        case 4:
                            pieza = new Alfil(0, 0);
                            break;
                        case 5:
                            pieza = new Caballo(0, 0);
                            break;
                        case 6:
                            pieza = new Peon(0, 0);
                            break;
                    }

                    if (pieza != null)
                    {
                        ResolverTablero.Resolver8Piezas(pieza);
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                }
            } while (pieza == null);

            Console.ReadKey();
        }
    }
}


