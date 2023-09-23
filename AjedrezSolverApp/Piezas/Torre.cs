using _8PiezasProyect.Interfaz;

namespace _8PiezasProyect.Piezas
{
    public class Torre : IPieza
    {
        // Atributos
        private int fila;
        private int columna;

        // Constructor
        public Torre(int filaInicial, int columnaInicial)
        {
            fila = filaInicial;
            columna = columnaInicial;
        }

        // Métodos de la interfaz IPieza
        public bool EsMovimientoValido(int nuevaFila, int nuevaColumna)
        {
            // Verificar si el movimiento es horizontal o vertical
            return fila == nuevaFila || columna == nuevaColumna;
        }

        public void Mover(int nuevaFila, int nuevaColumna)
        {
            // Lógica para mover la torre a la nueva posición
            fila = nuevaFila;
            columna = nuevaColumna;
        }

        public string ObtenerNombre()
        {
            return "Torre";
        }
    }
}
