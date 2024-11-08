namespace EjercicioExepciones
{
    class Program
    {
        public static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una operacion:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.Write("Opcion: ");

                try
                {
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 5)
                    {
                        continuar = false;
                        Console.WriteLine("Saliendo...");
                        break;
                    }

                    Console.WriteLine("Ingrese el primer numero: ");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero: ");
                    double num2 = double.Parse(Console.ReadLine());

                    double resultado = 0;

                    switch (opcion)
                    {
                        case 1:
                            resultado = operaciones.Sumar(num1, num2);
                            Console.WriteLine($"Resultado de la suma: {resultado}");
                            break;

                        case 2:
                            resultado = operaciones.Restar(num1, num2);
                            Console.WriteLine($"Resultado de la resta: {resultado}");
                            break;

                        case 3:
                            resultado = operaciones.Multiplicar(num1, num2);
                            Console.WriteLine($"Resultado de la multiplicacion: {resultado}");
                            break;

                        case 4:
                            try
                            {
                                resultado = operaciones.Dividir(num1, num2);
                                Console.WriteLine($"Resultado de la division: {resultado}");
                            }
                            catch (DivideByZeroException ex) //si la division es entre cero
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                            break;

                        default:
                            Console.WriteLine("Opcion no valida. Intente de nuevo.");
                            break;
                    }
                }
                catch (FormatException)// para capturar errorres de entrada de datos no numericos
                {
                    Console.WriteLine("Error: Ingrese un numero valido.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocurrio un error inesperado: {ex.Message}");
                }

                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }



}