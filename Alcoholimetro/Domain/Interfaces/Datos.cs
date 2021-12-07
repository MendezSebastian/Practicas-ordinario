namespace Alcohol.Domain.Interfaces
{
    public interface Datos
    {
        void PrimerDato(int cantidad, string bebida);
        void SegundoDato(int peso);
        string DatosTotales();
    }
}