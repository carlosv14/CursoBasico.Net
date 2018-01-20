namespace Calculadora.Operaciones
{
    public abstract class Operacion
    {
        public int Izquierda;
        public int Derecha;

        public abstract double Operar();
    }
}