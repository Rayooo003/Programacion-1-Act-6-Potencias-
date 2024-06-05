// Utiliza el espacio de nombres System que contiene clases fundamentales para ejecutar aplicaciones de consola.
using System;

// Declara una clase llamada Program.
class Program
{
    // Define el método Main, que es el punto de entrada de la aplicación.
    static void Main()
    {
        // Declara tres variables de tipo double para almacenar el número base, el exponente y el resultado.
        double NúmeroBase, Exponente, Resultado;

        // Imprime un mensaje de bienvenida en la consola.
        Console.WriteLine("Bienvenido a la calculadora de potencias.");

        // Pide al usuario que ingrese el número base.
        Console.WriteLine("Por favor ingrese el número base.");

        // Lee la línea de la consola, la convierte a double y la asigna a Exponente.
        NúmeroBase = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Ingrese el exponente al  que se elevará el número base.");
        Exponente = Convert.ToDouble(Console.ReadLine());

        // Verifica si el exponente es identico a cero.
        if (Exponente == 0)
        {
            // Informa al usuario que el resultado es 1 cuando el exponente es 0.
            Console.WriteLine("No es posible realizar la operación con exponente 0. El resultado es 1.");

            // Asigna 1 al resultado ya que cualquier número elevado a la potencia de 0 es 1.
            Resultado = 1;
        }

        // Si el exponente no es cero, ejecuta el siguiente bloque de código.
        else
        {
            // Utiliza el método Pow de la clase Math para calcular la potencia y asigna el resultado a Resultado.
            Resultado = Math.Pow(NúmeroBase, Exponente);

            // Imprime el resultado en la consola.
            Console.WriteLine("La potencia de " + NúmeroBase + " elevado a " + Exponente + " es " + Resultado);

        }

    }

}

