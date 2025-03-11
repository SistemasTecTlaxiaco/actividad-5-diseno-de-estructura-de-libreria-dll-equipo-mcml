using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCalculadoraTec
{
    public class Class1
    {

            public static double sumar(double uno, double dos)
            {
                return uno + dos;
            }

            public static double multiplicar(double uno, double dos)
            {
                return uno * dos;
            }


            public static double restar(double uno, double dos)
            {
                return uno - dos;
            }


            public static double dividir(double uno, double dos)
            {
                try
                {
                    if (dos == 0) // Verifica si el divisor es cero
                    {
                        throw new ArithmeticException("No se puede dividir por cero."); // Lanza una excepción
                    }
                    return uno / dos; // Retorna la división
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine("Error: " + e.Message); // Muestra un mensaje de error en la consola
                    return Double.NaN; // Retorna NaN (Not a Number)
                }
            }


            public static double raizCuadrada(double num)
            {
                if (num < 0) // Verifica si el número es negativo
                {
                    Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo."); // Mensaje de error
                    return Double.NaN; // Retorna NaN
                }
                return Math.Sqrt(num); // Retorna la raíz cuadrada del número
            }

            public static double potencia(double baseNum, double exponente)
            {
                return Math.Pow(baseNum, exponente); // Retorna el resultado de elevar baseNum a exponente
            }


            public static double porcentaje(double total, double porcentaje)
            {
                return (total * porcentaje) / 100; // Retorna el porcentaje del total
            }

            public static double fraccion(double numero)
            {
                if (numero == 0) // Verifica si el número es cero
                {
                    Console.WriteLine("Error: No se puede calcular la fracción de cero."); // Mensaje de error
                    return Double.NaN; // Retorna NaN
                }
                return 1 / numero; // Retorna la fracción del número
            }
        }
    }


