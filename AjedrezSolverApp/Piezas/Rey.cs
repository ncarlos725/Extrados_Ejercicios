using _8PiezasProyect.Interfaz;
using System;

namespace _8PiezasProyect.Piezas
{
    public class Rey : IPieza
    {
        // Atributos
        private int fila;
        private int columna;

        // Constructor
        public Rey(int filaInicial, int columnaInicial)
        {
            fila = filaInicial;
            columna = columnaInicial;
        }

        // Métodos de la interfaz IPieza
        public bool EsMovimientoValido(int nuevaFila, int nuevaColumna)
        {
            // Verificar si el movimiento es horizontal, vertical o diagonal, pero de una casilla a la vez
            int filaDiferencia = Math.Abs(nuevaFila - fila);
            int columnaDiferencia = Math.Abs(nuevaColumna - columna);

            return filaDiferencia <= 1 && columnaDiferencia <= 1;
        }

        public void Mover(int nuevaFila, int nuevaColumna)
        {
            // Lógica para mover el rey a la nueva posición
            fila = nuevaFila;
            columna = nuevaColumna;
        }

        public string ObtenerNombre()
        {
            return "Rey";
        }
    }
}
