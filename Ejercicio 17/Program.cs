using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas = 0;
            int minutos = 0;
            int segundos = 0;

            // Pedir al usuario la hora inicial y validar que esté entre 0 y 23
            do
            {
                Console.WriteLine("Ingrese la hora (0-23):");
                horas = int.Parse(Console.ReadLine());

                if (horas < 0 || horas > 23)
                    Console.WriteLine("Error. La hora debe estar entre 0 y 23.");
            } while (horas < 0 || horas > 23);

            // Pedir al usuario los minutos iniciales y validar que estén entre 0 y 59
            do
            {
                Console.WriteLine("Ingrese los minutos (0-59):");
                minutos = int.Parse(Console.ReadLine());

                if (minutos < 0 || minutos > 59)
                    Console.WriteLine("Error. Los minutos deben estar entre 0 y 59.");
            } while (minutos < 0 || minutos > 59);

            // Pedir al usuario los segundos iniciales y validar que estén entre 0 y 59
            do
            {
                Console.WriteLine("Ingrese los segundos (0-59):");
                segundos = int.Parse(Console.ReadLine());

                if (segundos < 0 || segundos > 59)
                    Console.WriteLine("Error. Los segundos deben estar entre 0 y 59.");
            } while (segundos < 0 || segundos > 59);

            // Simular el reloj en tiempo real
            while (true)
            {
                Console.Clear(); // Limpiar la consola para mostrar la hora actualizada
                Console.WriteLine($"Hora actual: {horas:D2} {minutos:D2} {segundos:D2}"); // Mostrar la hora en formato HH:MM:SS

                segundos++; // Incrementar los segundos

                // Si los segundos llegan a 60, reiniciarlos y sumar 1 a los minutos
                if (segundos == 60)
                {
                    segundos = 0;
                    minutos++;
                }

                // Si los minutos llegan a 60, reiniciarlos y sumar 1 a las horas
                if (minutos == 60)
                {
                    minutos = 0;
                    horas++;
                }

                // Si las horas llegan a 24, reiniciarlas (formato de 24 horas)
                if (horas == 24)
                {
                    horas = 0;
                }

                Thread.Sleep(1000); // Pausar la ejecución durante 1 segundo para simular el paso del tiempo
            }
        }
    }
}
