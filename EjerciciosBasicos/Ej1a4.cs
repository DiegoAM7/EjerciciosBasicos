using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos
{
    public class Ej1a4
    {
        // Cree un programa de consola que solicite una nota y muestre por pantalla si la nota es correcta o está fuera de rango. El rango correcto es de 1 a 7.
        public void Ejercicio1()
        {
            Console.WriteLine("Ingrese una nota, para verificar si es correcta.");
            float nota = float.Parse(Console.ReadLine());

            Console.WriteLine("====================");

            if (nota >= 1 && nota <= 7)
            {
                Console.WriteLine("La nota {0} es correcta.", nota);
            } else
            {
                Console.WriteLine("La nota {0} esta fuera del rango.", nota);
            }
        }

        // Cree un programa de consola que solicite un número y muestre por pantalla si el número es par o impar, el 0 se considera par.
        public void Ejercicio2()
        {
            Console.WriteLine("Ingrese un número, para verificar si es par o impar.");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("====================");

            if (num % 2 == 0)
            {
                Console.WriteLine("El número {0} es par.", num);
            } else
            {
                Console.WriteLine("El número {0} es impar.", num);
            }
        }

        // Cree un programa de consola que solicite una distancia en kilómetros para ser recorrida en 6 horas, el script debe calcular a qué velocidad se desplazará el vehículo en recorrer la distancia ingresada por el cliente, debe mostrar el resultado por pantalla.
        public void Ejercicio3()
        {
            Console.WriteLine("Ingrese la distancia en km, a ser recorridos en 6 horas.");
            float dist = float.Parse(Console.ReadLine());

            float vel = dist / 6;

            Console.WriteLine("====================");

            Console.WriteLine("La velocidad de desplazamiento debe ser de {0}.", vel);
        }

        // Mejore el script del ejercicio 3 para satisfacer las siguientes necesidades: si la velocidad es superior a 100 km/h debe mostrar por pantalla que el vehículo se desplazará a gran velocidad, en caso contrario debe mostrar por pantalla que el vehículo se desplazara a una velocidad moderada.
        public void Ejercicio4()
        {
            Console.WriteLine("Ingrese la distancia en km, a ser recorridos en 6 horas.");
            float dist = float.Parse(Console.ReadLine());

            float vel = dist / 6;

            Console.WriteLine("====================");

            Console.WriteLine("La velocidad de desplazamiento debe ser de {0}.", vel);

            if (vel > 100)
            {
                Console.WriteLine("Se desplazara a gran velocidad.");
            } else
            {
                Console.WriteLine("Se desplzara a una velocidad moderada.");
            }
        }
    }
}
