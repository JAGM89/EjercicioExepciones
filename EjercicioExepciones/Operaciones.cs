

namespace EjercicioExepciones
{
    public class Operaciones
    {
        public double Sumar(double valor1, double valor2)
        {
            return valor1 + valor2;
        }

        public double Restar(double valor1, double valor2)
        {
            return valor1 - valor2;
        }

        public double Multiplicar(double valor1, double valor2)
        {
            return valor1 * valor2;
        }

        public double Dividir(double valor1, double valor2)
        {
            if (valor2 == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero...");
            }
            return valor1 / valor2;
        }
    }
}
