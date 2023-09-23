using _8PiezasProyect.Interfaz;

namespace _8PiezasProyect.Piezas
{
    public class CaballoEspecial : Caballo
    {
        public CaballoEspecial(int filaInicial, int columnaInicial) : base(filaInicial, columnaInicial)
        {
        }

        public override bool EsMovimientoValido(int nuevaFila, int nuevaColumna)
        {
            int filaDiferencia = Math.Abs(nuevaFila - this.fila);
            int columnaDiferencia = Math.Abs(nuevaColumna - this.columna);

            // Un movimiento válido para un "caballo especial" es en forma de "L" o una casilla en cualquier dirección.
            return (filaDiferencia == 2 && columnaDiferencia == 1) || (filaDiferencia == 1 && columnaDiferencia == 2)
                || (filaDiferencia == 1 && columnaDiferencia == 1);
        }
    }
}
