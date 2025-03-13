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
                return uno + dos; // retorna el valor de la suma
        }
             public static double restar(double uno, double dos)
             {
                 return uno - dos; // retorna el valor de la resta
        }
        //metodo para multiplicar dos numeros
             public static double multiplicar(double uno, double dos)
              {
                return uno * dos;//retorna el producto de los dos numeros
             }
        public static double dividir(double uno, double dos)
        {
            if (dos == 0) // Verifica si el divisor es cero
            {
                Console.WriteLine("Error: No se puede dividir por cero."); // Mensaje de error
                return double.NaN; // Retorna NaN si la división no es posible
            }
            return uno / dos; // Realiza la división si no hay error
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
        { // Caso base: cualquier número elevado a la potencia 0 es 1
            if (exponente == 0) return 1;

            // Si el exponente es negativo, convertimos el problema en una potencia positiva y luego invertimos el resultado
            if (exponente < 0) return 1 / potencia(baseNum, -exponente);

            // Llamada recursiva: multiplicamos la base por la potencia de baseNum con un exponente reducido en 1
            return baseNum * potencia(baseNum, exponente - 1); 
        }


        public static double porcentaje(double total, double porcentaje)
        {
            // Calcula el porcentaje de un total dado
            double resultado = (total * porcentaje) / 100; // Multiplica el total por el porcentaje y divide entre 100
            return resultado; // Retorna el resultado obtenido
        }

        public static double fraccion(double numero)  // Define un método estático que recibe un número de tipo double y devuelve un double
        {
                if (numero == 0) // Verifica si el número ingresado es igual a cero
            {
                    Console.WriteLine("Error: No se puede calcular la fracción de cero."); // Muestra un mensaje de error en la consola
                return Double.NaN; // Retorna NaN (Not a Number) para indicar que el cálculo no es válido
            }
                return 1 / numero; // Si el número no es cero, retorna su fracción (1 dividido por el número)
        }
        public static double exp(double x)
        {
            return Math.Exp(x); // Calcula e elevado a la potencia de x
        }
    }
    }


