using _8PiezasProyect.Interfaz;

namespace _8PiezasProyect.Piezas
{
    public class Caballo : IPieza
    {
        // Atributos
        protected int fila;
        protected int columna;

        // Constructor
        public Caballo(int filaInicial, int columnaInicial)
        {
            fila = filaInicial;
            columna = columnaInicial;
        }

        // Métodos de la interfaz IPieza
        public virtual bool EsMovimientoValido(int nuevaFila, int nuevaColumna)
        {
            // Verificar si el movimiento es válido para un caballo
            int filaDiferencia = Math.Abs(nuevaFila - fila);
            int columnaDiferencia = Math.Abs(nuevaColumna - columna);

            // Un movimiento válido para un caballo es en forma de "L", dos pasos en una dirección y un paso en la otra.
            return (filaDiferencia == 2 && columnaDiferencia == 1) || (filaDiferencia == 1 && columnaDiferencia == 2);
        }

        public void Mover(int nuevaFila, int nuevaColumna)
        {
            // Lógica para mover el caballo a la nueva posición
            fila = nuevaFila;
            columna = nuevaColumna;
        }

        public string ObtenerNombre()
        {
            return "Caballo";
        }
    }
}
