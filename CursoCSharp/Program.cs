using System;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //###Concatenación de cadenas###
            //Se utiliza el operador + para concatenar cadenas.
            //Ejemplo:
            string greeting = "Hello ";
            string world = "World!";
            string mark = "ACME";

            Console.WriteLine(greeting  + world);

            /*Cadenas literales
            Permite utilizar caracteres especiales sin escaparlos
            Conserva tambien el formato de la cadena, incluyendo
            saltos de linea y espaciados */
            //Ejemplo:
            Console.WriteLine(@"Esta cadena \ admite caracteres especiales f 
                    Continua el texto...");

            /*Interpolación de cadenas
             La interpolación de cadenas permite concatenar variables
             con cadenas y facilita la comprensión del código.*/
            //Ejemplo:
            Console.WriteLine($"Esto es un saludo {greeting}{world}");

            /*De igual forma podemos utilizar
             Cadenas literales e Interpolación de cadenas*/
            //Ejemplo:
            Console.WriteLine($@"Formato de salida:
    C:\Documentos\{mark}\..");

            //#####Operadores Matemáticos#####
            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Diffrence: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            decimal decimalQuotient = 7.0m / 5;

            Console.WriteLine("Decimal quotien: " + decimalQuotient);

            int first = 7;
            int second = 5;
            decimal quotientD = (decimal)first / (decimal)second;
            Console.WriteLine(quotientD);

            Console.WriteLine("Modulus of 200 / 5: " + (200 % 5));
            Console.WriteLine("Modulus of 7 / 5: " + (7 % 5));


            int value = 1;
            ++value;

            value = value + 1;
            Console.WriteLine("First increment: " + value);

            value += 1;
            Console.WriteLine("Second increment: " + value);

            value++;
            Console.WriteLine("Third increment: " + value);

            value = value - 1;
            Console.WriteLine("First decrement: " + value);

            value -= 1;
            Console.WriteLine("Second decrement: " + value);

            value--;
            Console.WriteLine("Third decrement: " + value);

            value = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine("Second: " + value++);
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));

            int fahrenheit = 94;
            decimal celsius = ((decimal)fahrenheit - 32) * (5m / 9m);
            Console.WriteLine(@"The temperature is " + celsius + " Celsius");
            Console.WriteLine(@"The temperature is " + celsius + " Celsius.");


        }
    }
}
