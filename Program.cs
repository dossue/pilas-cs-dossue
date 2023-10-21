using System;

class Program
{
    static void Main()
    {
        const int capacidad = 10;
        int[] elementos = new int[capacidad];
        int tope = -1;

        Console.WriteLine("Teclea elemento de la pila (termina con -1)");

        int x = 0;
        const int CLAVE = -1;

        while (true) // Cambiar la condición del bucle
        {
            x = int.Parse(Console.ReadLine());

            if (x == CLAVE)
            {
                break; // Salir del bucle si se ingresa -1
            }

            if (tope < capacidad - 1)
            {
                tope++;
                elementos[tope] = x;
            }
            else
            {
                Console.WriteLine("Excepción: Pila llena");
                break;
            }
        }

        if (tope >= 0)
        {
            Console.WriteLine("Elementos de la Pila: ");
            while (tope >= 0)
            {
                x = elementos[tope];
                tope--;
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Pila vacía");
        }

        Console.WriteLine("Presiona cualquier tecla para salir.");
        Console.ReadKey(); // Esperar a que el usuario presione una tecla
    }
}