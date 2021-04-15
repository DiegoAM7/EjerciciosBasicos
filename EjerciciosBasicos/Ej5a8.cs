using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos
{
    public class Ej5a8
    {
        // Cree un programa de consola que solicite al cliente la cantidad de notas que quiere promediar, luego el programa debe solicitar dicha cantidad de notas para promediarlas. Finalmente debe mostrar por pantalla el resultado del promedio e indicar si el alumno aprobó o reprobó la asignatura.
        public void Ejercicio5()
        {
            Console.WriteLine("Ingrese la cantidad de las notas a promediar:");
            int cant = int.Parse(Console.ReadLine());
            float notas = float.Parse("0");

            for (int x = 1; x <= cant; x++)
            {
                Console.WriteLine("Ingrese la nota N°{0}:", x);
                float nota = float.Parse(Console.ReadLine());
                notas += nota;
            }

            float promedio = notas / cant;

            Console.WriteLine("====================");

            if (promedio >= 4.0)
            {
                Console.WriteLine("Has aprobado con nota {0}", promedio);
            } else
            {
                Console.WriteLine("Has reprobado con nota {0}", promedio);
            }
        }

        // Cree un programa de consola que solicite un número al cliente y muestre por pantalla todos los números impares que hay desde el 1 hasta el número ingresado.
        public void Ejercicio6()
        {
            Console.WriteLine("Ingrese un número para ver los números impares desde el 1 hasta el número ingresado:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("====================");

            for (int x = 1; x <= num; x++)
            {
                if(x % 2 != 0)
                {
                    Console.WriteLine(x);
                }
            }
        }

        // Cree un programa de consola que solicite dos números al cliente, el programa debe verificar que número es mayor y menor luego mostrar por pantalla todos los números desde el menor hasta el mayor de los números ingresados por el cliente.
        public void Ejercicio7()
        {
            Console.WriteLine("Ingrese dos número para determinar el mayor y ver los números que hay entre ambos:");
            Console.WriteLine("Ingrese el primer número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("====================");

            if (num1 < num2)
            {
                for (int x = num1; x <= num2; x++)
                {
                    Console.WriteLine(x);
                }
            } else
            {
                for (int x = num2; x <= num1; x++)
                {
                    Console.WriteLine(x);
                }
            }
        }

        // Cree un programa de consola que solicite al usuario un número entre el 1 y el 7, el programa debe mostrar por pantalla el nombre del día de la semana que corresponda al número ingresado. Si el número ingresado no está entre 1 y 7 debe mostrar por pantalla error al ingresar el número.
        public void Ejercicio8()
        {
            List<string> semana = new List<string>()
            {
                "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"
            };

            Console.WriteLine("Ingrese un número del 1 al 7 y se mostrará el día de la semana correspondiente:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("====================");

            if (num >= 1 && num <= 7)
            {
                Console.WriteLine(semana[num - 1]);
            }
            else
            {
                Console.WriteLine("Error al ingresar el número.");
            }
        }
    }
}
