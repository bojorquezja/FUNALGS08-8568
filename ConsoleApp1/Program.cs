using System;

class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Clear(); // Limpiar la consola
            int n = ObtenerNumeroDeAleatorios();
            GenerarNumerosAleatorios(n);
            Console.WriteLine("¿Desea generar otra lista de números aleatorios? (S/N): ");
        } while (Console.ReadKey(true).Key != ConsoleKey.N);
    }

    static int ObtenerNumeroDeAleatorios()
    {
        int n;

        while (true)
        {
            Console.Write("Ingrese la cantidad de números aleatorios a generar (1-100): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out n) && n > 0 && n <= 100)
            {
                break; // Salir del bucle si la entrada es válida
            }
            Console.WriteLine("Entrada no válida. Por favor ingrese un número entre 1 y 100.");
        }
        return n; // Asegúrate de que n no sea nulo
    }

    static void GenerarNumerosAleatorios(int n)
    {
        Random random = new Random();
        int positivos = 0, negativos = 0;

        for (int i = 0; i < n; i++)
        {
            int numero = random.Next(-20, 21); // Genera un número entre -20 y 20
            Console.WriteLine(numero);

            if (numero < 0)
            {
                negativos++;
            }
            else if (numero > 0)
            {
                positivos++;
            }
        }

        Console.WriteLine($"Números positivos: {positivos}, Números negativos: {negativos}");
    }
}
