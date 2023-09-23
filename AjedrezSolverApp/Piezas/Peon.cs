using _8PiezasProyect.Interfaz;

namespace _8PiezasProyect.Piezas
{
    public class Peon : IPieza
    {
        // Atributos
        private int fila;
        private int columna;

        // Constructor
        public Peon(int filaInicial, int columnaInicial)
        {
            fila = filaInicial;
            columna = columnaInicial;
        }

        // Métodos de la interfaz IPieza
        public bool EsMovimientoValido(int nuevaFila, int nuevaColumna)
        {
            // Verificar si el movimiento es válido para un peón
            int filaDiferencia = nuevaFila - fila;
            int columnaDiferencia = Math.Abs(nuevaColumna - columna);

            // En el juego de ajedrez, un peón puede moverse hacia adelante una casilla o dos casillas en su primer movimiento.
            // También puede moverse diagonalmente una casilla para capturar una pieza enemiga.
            // La dirección del movimiento depende del color del peón (blanco o negro).

            // Si es un peón blanco:
            if (filaDiferencia == 1 && columnaDiferencia == 0)
            {
                // Movimiento hacia adelante una casilla
                return true;
            }
            else if (filaDiferencia == 2 && columnaDiferencia == 0 && fila == 1) // Primer movimiento
            {
                // Movimiento hacia adelante dos casillas en el primer movimiento
                return true;
            }
            else if (filaDiferencia == 1 && columnaDiferencia == 1)
            {
                // Movimiento diagonal para capturar una pieza enemiga
                return true;
            }

            // Si es un peón negro:
            // De manera similar, un peón negro puede moverse hacia adelante una casilla o dos casillas en su primer movimiento,
            // y puede moverse diagonalmente para capturar una pieza enemiga.

            return false; // Si no cumple con ninguno de los movimientos válidos, es inválido.
        }

        public void Mover(int nuevaFila, int nuevaColumna)
        {
            // Lógica para mover el peón a la nueva posición
            fila = nuevaFila;
            columna = nuevaColumna;
        }

        public string ObtenerNombre()
        {
            return "Peón";
        }
    }
}
