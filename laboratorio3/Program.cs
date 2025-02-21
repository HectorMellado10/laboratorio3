using System;

namespace MenuProgram
{
    class Program
    {
        static int opcion; // Variable para la opción del menú
        // Calculadora básica
        static void CalculadoraBasica()
        {
            double num1, num2;
            string operacion;
            Console.Write("Ingrese el primer número: ");
            string? input1 = Console.ReadLine(); // Aca usamos "string?" para manejar valores nulos, aun no lo entiendo completamente pero es para tener mas orden, en teoria jaja
            if (!double.TryParse(input1, out num1))
            {
                Console.WriteLine("Número no válido.");
                return;
            }
            Console.Write("Ingrese el segundo número: ");
            string? input2 = Console.ReadLine();
            if (!double.TryParse(input2, out num2))
            {
                Console.WriteLine("Número no válido.");
                return;
            }
            Console.Write("Seleccione la operación (+, -, *, /): ");
            operacion = Console.ReadLine() ?? ""; // Asignamos una cadena vacía si es nulo

            switch (operacion)
            {
                case "+":
                    Console.WriteLine($"Resultado: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Resultado: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Resultado: {num1 * num2}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                    else
                    {
                        Console.WriteLine($"Resultado: {num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    break;
            }
        }

        // Función de validación de contraseña
        static void ValidacionContrasena()
        {
            string? contrasena;
            do
            {
                Console.Write("Ingrese la contraseña: ");
                contrasena = Console.ReadLine();
                if (contrasena != "1234")
                {
                    Console.WriteLine("Contraseña incorrecta. Intente de nuevo.");
                }
            } while (contrasena != "1234");
            Console.WriteLine("Acceso concedido.");
        }

        // Función de números primos
        static void NumerosPrimos()
        {
            int num;
            Console.Write("Ingrese un número: ");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out num))
            {
                Console.WriteLine("Número no válido.");
                return;
            }
            if (EsPrimo(num))
            {
                Console.WriteLine($"{num} es un número primo.");
            }
            else
            {
                Console.WriteLine($"{num} no es un número primo.");
            }
        }

        // Función auxiliar para determinar si un número es primo
        static bool EsPrimo(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // Función de suma de números pares
        static void SumaNumerosPares()
        {
            int num, suma = 0;
            do
            {
                Console.Write("Ingrese un número (0 para terminar): ");
                string? input = Console.ReadLine();
                if (!int.TryParse(input, out num))
                {
                    Console.WriteLine("Número no válido.");
                    continue;
                }
                if (num % 2 == 0)
                {
                    suma += num;
                }
            } while (num != 0);
            Console.WriteLine($"La suma de los números pares es: {suma}");
        }

        // Función de conversión de temperatura
        static void ConversionTemperatura()
        {
            double temp;
            string? opcion;
            Console.Write("Seleccione la conversión (1: Celsius a Fahrenheit, 2: Fahrenheit a Celsius): ");
            opcion = Console.ReadLine() ?? ""; 
            Console.Write("Ingrese la temperatura: ");
            string? input = Console.ReadLine();
            if (!double.TryParse(input, out temp))
            {
                Console.WriteLine("Temperatura no válida.");
                return;
            }
            if (opcion == "1")
            {
                Console.WriteLine($"{temp}°C es equivalente a {CelsiusAFahrenheit(temp)}°F");
            }
            else if (opcion == "2")
            {
                Console.WriteLine($"{temp}°F es equivalente a {FahrenheitACelsius(temp)}°C");
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }

        // Función para convertir Celsius a Fahrenheit
        static double CelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Función para convertir Fahrenheit a Celsius
        static double FahrenheitACelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        // Función de contador de vocales
        static void ContadorVocales()
        {
            Console.Write("Ingrese una frase: ");
            string? frase = Console.ReadLine() ?? "";
            Console.WriteLine($"La frase contiene {ContarVocales(frase)} vocales.");
        }

        // Función auxiliar para contar vocales en una frase
        static int ContarVocales(string frase)
        {
            int contador = 0;
            foreach (char c in frase.ToLower())
            {
                if ("aeiou".Contains(c))
                {
                    contador++;
                }
            }
            return contador;
        }

        // Función de cálculo de factorial
        static void CalculoFactorial()
        {
            int num;
            Console.Write("Ingrese un número: ");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out num))
            {
                Console.WriteLine("Número no válido.");
                return;
            }
            Console.WriteLine($"El factorial de {num} es {Factorial(num)}");
        }

        // Función auxiliar para calcular el factorial de un número
        static int Factorial(int num)
        {
            int resultado = 1;
            for (int i = 2; i <= num; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        // Función del juego de adivinanza
        static void JuegoAdivinanza()
        {
            Random rand = new Random();
            int numeroAleatorio = rand.Next(1, 101);
            int intento;
            do
            {
                Console.Write("Adivine el número (1-100): ");
                string? input = Console.ReadLine();
                if (!int.TryParse(input, out intento))
                {
                    Console.WriteLine("Número no válido.");
                    continue;
                }
                if (intento < numeroAleatorio)
                {
                    Console.WriteLine("Demasiado bajo.");
                }
                else if (intento > numeroAleatorio)
                {
                    Console.WriteLine("Demasiado alto.");
                }
            } while (intento != numeroAleatorio);
            Console.WriteLine("¡Correcto! Has adivinado el número.");
        }

        // Función de paso por referencia
        static void PasoPorReferencia()
        {
            int num1, num2;
            Console.Write("Ingrese el primer número: ");
            string? input1 = Console.ReadLine();
            if (!int.TryParse(input1, out num1))
            {
                Console.WriteLine("Número no válido.");
                return;
            }
            Console.Write("Ingrese el segundo número: ");
            string? input2 = Console.ReadLine();
            if (!int.TryParse(input2, out num2))
            {
                Console.WriteLine("Número no válido.");
                return;
            }
            Console.WriteLine($"Valores originales: num1 = {num1}, num2 = {num2}");
            Intercambiar(ref num1, ref num2);
            Console.WriteLine($"Valores intercambiados: num1 = {num1}, num2 = {num2}");
        }

        // Función auxiliar para intercambiar dos números por referencia
        static void Intercambiar(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Función de tabla de multiplicar
        static void TablaMultiplicar()
        {
            int num;
            Console.Write("Ingrese un número: ");
            string? input = Console.ReadLine();
            if (!int.TryParse(input, out num))
            {
                Console.WriteLine("Número no válido.");
                return;
            }
            MostrarTablaMultiplicar(num);
        }

        // Función auxiliar para mostrar la tabla de multiplicar
        static void MostrarTablaMultiplicar(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        // Menú del switch (hasta abajo)
        static void Main(string[] args)
        {
            do
            {
                // Menú principal
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1. Calculadora básica");
                Console.WriteLine("2. Validación de contraseña");
                Console.WriteLine("3. Números primos");
                Console.WriteLine("4. Suma de números pares");
                Console.WriteLine("5. Conversión de temperatura");
                Console.WriteLine("6. Contador de vocales");
                Console.WriteLine("7. Cálculo de factorial");
                Console.WriteLine("8. Juego de adivinanza");
                Console.WriteLine("9. Paso por referencia");
                Console.WriteLine("10. Tabla de multiplicar");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                string? input = Console.ReadLine();
                if (!int.TryParse(input, out opcion))
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    opcion = -1; // Asignamos un valor inválido para repetir el bucle
                    continue;
                }

                // Switch para las opciones del menú
                switch (opcion)
                {
                    case 1:
                        CalculadoraBasica();
                        break;
                    case 2:
                        ValidacionContrasena();
                        break;
                    case 3:
                        NumerosPrimos();
                        break;
                    case 4:
                        SumaNumerosPares();
                        break;
                    case 5:
                        ConversionTemperatura();
                        break;
                    case 6:
                        ContadorVocales();
                        break;
                    case 7:
                        CalculoFactorial();
                        break;
                    case 8:
                        JuegoAdivinanza();
                        break;
                    case 9:
                        PasoPorReferencia();
                        break;
                    case 10:
                        TablaMultiplicar();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            } while (opcion != 0);
        }
    }
}
