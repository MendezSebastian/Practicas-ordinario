namespace Resistencia.Domain.Interfaces
{
    public interface Operacion
    {
        void Banda_1(string B1 );
        void Banda_2(string B2);
        void Banda_3(string B3);
        void Banda_gold(string B4);
        string operacion();
    }
}