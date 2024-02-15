using EjercicioExcepciones;

int opcion;
Operaciones op = new Operaciones();
double num1 = -1, num2 = -1 , resultado = 0;
do
{
    Console.WriteLine("Mi Calculadora C#");
    Console.WriteLine("");
    Console.WriteLine("********| Operaciones Disponibles |********");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("0. Salir");

    Console.WriteLine("Ingrese la operacion a realizar:");
    try
    {

        opcion = Convert.ToInt32(Console.ReadLine());

        do {
            try
            {
                Console.WriteLine("Ingrese primer numero:");
                num1 = Convert.ToInt32(Console.ReadLine());
            }catch (Exception ex)
            {
                Console.WriteLine("El valor ingresado es incorrecto, intente otra vez.");
            }
        } while (num1 < 0);

        do
        {
            try
            {
                Console.WriteLine("Ingrese segundo numero:");
                num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("El valor ingresado es incorrecto, intente otra vez.");
            }
        } while (num2 < 0);

        if (opcion == 1)
        {
            resultado = op.sumar(num1, num2);
        }
        else if (opcion == 2)
        {
            resultado = op.restar(num1, num2);
        }
        else if (opcion == 3)
        {
            resultado = op.multiplicar(num1, num2);
        }
        else if (opcion == 4)
        {
            resultado = op.dividir(num1, num2);
        }
        else
        {
            Console.WriteLine("Opcion no valida");
        }

        Console.WriteLine("************************************");
        Console.WriteLine("Resultado "+resultado);
        Console.WriteLine("************************************");
    } 
    catch (Exception ex)
    {
        Console.WriteLine("Error al capturar la opcion ingresada, intente otra vez.");
        opcion = 6;
    }
} while (opcion != 0);
