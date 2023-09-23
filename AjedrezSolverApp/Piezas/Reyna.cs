using _8PiezasProyect.Interfaz;

namespace _8PiezasProyect.Piezas
{
    public class Reina : IPieza
    {
        public int Fila { get; }
        public int Columna { get; }

        public Reina(int fila, int columna)
        {
            Fila = fila;
            Columna = columna;
        }

        public bool EsMovimientoValido(int fila, int columna)
        {
            int filaDiferencia = Fila - fila;
            int columnaDiferencia = Columna - columna;

            return filaDiferencia != 0 && columnaDiferencia != 0 && filaDiferencia != columnaDiferencia;
        }

        public string ObtenerNombre()
        {
            return "Reina";
        }
    }
}
