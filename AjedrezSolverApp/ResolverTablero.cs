using System;
using _8PiezasProyect.Interfaz;

namespace _8PiezasProyect
{
    public class ResolverTablero
    {
        public static void Resolver8Piezas(IPieza pieza)
        {
            int tamanoTablero = 8;
            IPieza[,] tablero = new IPieza[tamanoTablero, tamanoTablero];
            if (!Resolver8PiezasRecursivo(tablero, pieza, 0))
            {
                // Lanza la excepción SinSolucionException si no se encuentra una solución.
                throw new SinSolucionException("No se encontró una solución al problema de las piezas.");
            }
        }

        private static bool Resolver8PiezasRecursivo(IPieza[,] tablero, IPieza pieza, int piezasColocadas)
        {
            int tamanoTablero = tablero.GetLength(0);

            // Caso base: si todas las piezas se han colocado con éxito, hemos encontrado una solución.
            if (piezasColocadas == 8)
            {
                MostrarTablero(tablero);
                return true;
            }

            // Recorre el tablero en busca de una posición válida para la pieza actual.
            for (int fila = 0; fila < tamanoTablero; fila++)
            {
                for (int columna = 0; columna < tamanoTablero; columna++)
                {
                    if (pieza.EsMovimientoValido(fila, columna))
                    {
                        // Coloca la pieza en esta posición.
                        tablero[fila, columna] = pieza;

                        // Llama recursivamente para colocar la siguiente pieza.
                        if (Resolver8PiezasRecursivo(tablero, pieza, piezasColocadas + 1))
                        {
                            return true; // Si encontramos una solución, salimos.
                        }

                        // Si no se pudo colocar la siguiente pieza, retrocede y prueba otra posición.
                        tablero[fila, columna] = null;
                    }
                }
            }

            // Si no se encontró una solución en esta ronda, regresa falso.
            return false;
        }

        private static void MostrarTablero(IPieza[,] tablero)
        {
            int tamanoTablero = tablero.GetLength(0);

            for (int fila = 0; fila < tamanoTablero; fila++)
            {
                for (int columna = 0; columna < tamanoTablero; columna++)
                {
                    if (tablero[fila, columna] != null)
                    {
                        Console.Write("|* ");
                    }
                    else
                    {
                        Console.Write("|. ");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine();
        }
    }
}

