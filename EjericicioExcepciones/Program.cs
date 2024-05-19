

int opcion = 0;

do
{
    Console.WriteLine("Menú de Operaciones");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");

    try
    {
        opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                RealizarOperacion("sumar");
                break;
            case 2:
                RealizarOperacion("restar");
                break;
            case 3:
                RealizarOperacion("multiplicar");
                break;
            case 4:
                RealizarOperacion("dividir");
                break;
            case 5:
                Console.WriteLine("Saliendo del programa...");
                break;
            default:
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Ingrese un número válido.");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Error: No se puede dividir por cero.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }

    Console.WriteLine();
} while (opcion != 5);



static void RealizarOperacion(string operacion)
{
    double num1, num2;
    Console.Write("Ingrese el primer número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Ingrese el segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    switch (operacion)
    {
        case "sumar":
            Console.WriteLine($"Resultado de la suma: {num1 + num2}");
            break;
        case "restar":
            Console.WriteLine($"Resultado de la resta: {num1 - num2}");
            break;
        case "multiplicar":
            Console.WriteLine($"Resultado de la multiplicación: {num1 * num2}");
            break;
        case "dividir":
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }
            Console.WriteLine($"Resultado de la división: {num1 / num2}");
            break;
    }
}