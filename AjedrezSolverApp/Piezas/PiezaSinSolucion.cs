using _8PiezasProyect.Interfaz;  

public class PiezaSinSolucion : IPieza
{
    public int Fila { get; }
    public int Columna { get; }

    public PiezaSinSolucion(int fila, int columna)
    {
        Fila = fila;
        Columna = columna;
    }

    public bool EsMovimientoValido(int fila, int columna)
    {
        // Esta pieza no tiene soluci�n y siempre lanza una excepci�n.
        throw new SinSolucionException("Esta pieza no tiene soluci�n.");
    }

    public string ObtenerNombre()
    {
        return "Pieza Sin Soluci�n";
    }
}
