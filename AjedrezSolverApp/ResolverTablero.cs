using _8PiezasProyect.Interfaz;

namespace _8PiezasProyect
{
    public class ResolverTablero
    {
        public static void Resolver8Piezas(IPieza pieza)
        {
            int tamanoTablero = 8;
            IPieza[,] tablero = new IPieza[tamanoTablero, tamanoTablero];
            Resolver8PiezasRecursivo(tablero, pieza, 0);
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
                    if (EsMovimientoValido(tablero, pieza, fila, columna))
                    {
                        // Coloca la pieza en esta posición.
                        tablero[fila, columna] = pieza;

                        // Llama recursivamente para colocar la siguiente pieza.
                        if (Resolver8PiezasRecursivo(tablero, pieza, piezasColocadas + 1))
                        {
                            return true; // Si encontramos una solucion, salimos.
                        }

                        // Si no se pudo colocar la siguiente pieza, retrocede y prueba otra pos.
                        tablero[fila, columna] = null;
                    }
                }
            }

            // Si no se encontró una solución en esta ronda, regresa falso.
            return false;
        }

        private static bool EsMovimientoValido(IPieza[,] tablero, IPieza pieza, int fila, int columna)
        {
            int tamanoTablero = tablero.GetLength(0);

            // Verifica si la posición está ocupada por otra pieza.
            if (tablero[fila, columna] != null)
            {
                return false;
            }

            // Verifica si hay otra reina en la misma fila.
            for (int i = 0; i < tamanoTablero; i++)
            {
                if (tablero[fila, i] != null)
                {
                    return false;
                }
            }

            // Verifica si hay otra reina en la misma columna.
            for (int i = 0; i < tamanoTablero; i++)
            {
                if (tablero[i, columna] != null)
                {
                    return false;
                }
            }

            // Verifica si hay otra reina en la diagonal principal (hacia arriba).
            for (int i = fila, j = columna; i >= 0 && j >= 0; i--, j--)
            {
                if (tablero[i, j] != null)
                {
                    return false;
                }
            }

            // Verifica si hay otra reina en la diagonal principal (hacia abajo).
            for (int i = fila, j = columna; i < tamanoTablero && j < tamanoTablero; i++, j++)
            {
                if (tablero[i, j] != null)
                {
                    return false;
                }
            }

            // Verifica si hay otra reina en la diagonal secundaria (hacia arriba).
            for (int i = fila, j = columna; i >= 0 && j < tamanoTablero; i--, j++)
            {
                if (tablero[i, j] != null)
                {
                    return false;
                }
            }

            // Verifica si hay otra reina en la diagonal secundaria (hacia abajo).
            for (int i = fila, j = columna; i < tamanoTablero && j >= 0; i++, j--)
            {
                if (tablero[i, j] != null)
                {
                    return false;
                }
            }

            // Si pasó todas las verificaciones, el movimiento es válido.
            return true;
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
