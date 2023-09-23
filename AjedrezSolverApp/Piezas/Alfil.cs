using _8PiezasProyect.Interfaz;
using System;

namespace _8PiezasProyect.Piezas
{
    public class Alfil : IPieza
    {
        // Atributos
        private int fila;
        private int columna;

        // Constructor
        public Alfil(int filaInicial, int columnaInicial)
        {
            fila = filaInicial;
            columna = columnaInicial;
        }

        // Métodos de la interfaz IPieza
        public bool EsMovimientoValido(int nuevaFila, int nuevaColumna)
        {
            // Verificar si el movimiento es en diagonal
            int filaDiferencia = Math.Abs(nuevaFila - fila);
            int columnaDiferencia = Math.Abs(nuevaColumna - columna);

            return filaDiferencia == columnaDiferencia;
        }

        public void Mover(int nuevaFila, int nuevaColumna)
        {
            // Lógica para mover el alfil a la nueva posición
            fila = nuevaFila;
            columna = nuevaColumna;
        }

        public string ObtenerNombre()
        {
            return "Alfil";
        }
    }
}
