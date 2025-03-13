using System; // Ingresa datos por teclado
using System.Collections.Generic;
using System.Linq;
using System.Text;    // Permite mostrar mensajes en pantalla
using System.Threading.Tasks;
using BibliotecaCalculadoraTec; // Importa la biblioteca que contiene las operaciones matemáticas

namespace CalculadoraTecFinal
{
        class Program
        {
            private static double num1 = 0, num2 = 0, num0 = 0; // Variables estáticas para almacenar los números ingresados
            static void Main(string[] args)
            {
                bool salir = false; // Variable para controlar la salida del bucle
                while (!salir) // Mientras no se elija la opción de salir, el bucle continuará ejecutándose
                {
                    try // Captura errores de entrada de datos incorrectos
                    {
                        // Menú principal de la calculadora
                        Console.WriteLine(" Menu Principal de Calculadora del Tecnologico de Tlaxiaco");
                        Console.WriteLine("1. Sumar dos numeros");
                        Console.WriteLine("2. Restar dos numeros");
                        Console.WriteLine("3. Multiplicar");
                        Console.WriteLine("4. Dividir");
                        Console.WriteLine("5. Raiz Cuadrada");
                        Console.WriteLine("6. Potencia");
                        Console.WriteLine("7. Porcentaje");
                        Console.WriteLine("8. Fraccion");
                        Console.WriteLine("9.Exponente (e^x)");
                        Console.WriteLine("10. Salir");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Elige una de las opciones");
                        int opcion = Convert.ToInt32(Console.ReadLine()); // Captura la opción elegida por el usuario

                        switch (opcion) // Estructura de control para ejecutar la opción seleccionada
                        {
                            case 1: // Sumar dos números
                            teclado1();// Llama a la función teclado1() para capturar los valores de num1 y num2
                            Console.WriteLine("El resultado de la suma es: " + Class1.sumar(num1, num2));// Llama al método sumar de la clase Class1, pasando los valores num1 y num2 como parámetros.
                                                                                                         // Luego, muestra el resultado de la suma en la consola.
                            break;// Finaliza la ejecución del caso 1.
                        case 2: // Restar dos números
                                teclado1();
                                Console.WriteLine("El resultado de la Resta es: " + Class1.restar(num1, num2));
                                break;
                            case 3: // Multiplicar dos números
                                teclado1();
                                Console.WriteLine("El resultado de la Multiplicacion es: " + Class1.multiplicar(num1, num2));
                                break; //Llama a teclado1(), muestra el resultado de la multiplicacion y finaliza la ejecución del caso con break
                        case 4: // Dividir dos números
                                teclado1();
                                Console.WriteLine("El resultado de la Division es: " + Class1.dividir(num1, num2));
                                break; // Llama a teclado1(), muestra el resultado de la division y finaliza la ejecucion del caso con break
                            case 5: // Calcular la raíz cuadrada de un número
                                teclado0();
                                Console.WriteLine("El resultado de la Raiz cuadrada es: " + Class1.raizCuadrada(num0)); // devuelve un numero 
                                                                                                                        // como parametro 
                                break;
                            case 6: // Calcular la potencia de un número elevado a otro
                                teclado1();
                                Console.WriteLine("El resultado de la Potencia es: " + Class1.potencia(num1, num2));
                                break;
                            case 7: // Calcular el porcentaje de un número con respecto a otro
                                teclado1();
                                Console.WriteLine("El resultado del porcentaje es: " + Class1.porcentaje(num1, num2));
                                break;
                            case 8: // Caso 8 en una estructura 
                            teclado0(); // Llama a la función teclado0() para ingresar un 
                            Console.WriteLine("El resultado de la fracción es: " + Class1.fraccion(num0));
                            // Llama al método fraccion de la clase Class1, pasando num0 como parámetro
                            // Muestra el resultado de la fracción en la 
                            break; // Finaliza la ejecución de este caso en el 
                        case 10: // Salir de la aplicación
                                Console.WriteLine("Has elegido salir de la aplicación");
                                Environment.Exit(1);
                                salir = true;
                                break;
                            default: // Mensaje de error si la opción ingresada no es válida
                                Console.WriteLine("Elige una opcion entre 1 y 9");
                                break;
                        }
                    }
                    catch (FormatException e) // Captura errores de formato en la entrada de datos
                    {
                        Console.WriteLine("Error al ingresar!!");
                    }
                }
            }

            // Método para capturar un solo número desde el teclado
            private static void teclado0()
            {
                Console.WriteLine("Introduzca un numero");
                num0 = double.Parse(Console.ReadLine());
            }

            // Método para capturar dos números desde el teclado
            private static void teclado1()
            {
                Console.WriteLine("Introduzca el primer numero");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo numero");
                num2 = double.Parse(Console.ReadLine());
            }
        }
    }
