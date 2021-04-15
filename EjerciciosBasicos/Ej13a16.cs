using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos
{
    public class Ej13a16
    {
        // Mejore el ejercicio 5 con lo aprendido en el ejercicio 12.
        public void Ejercicio13()
        {
            Console.WriteLine("Ingrese la cantidad de las notas a promediar:");
            int cant = int.Parse(Console.ReadLine());
            float notas = float.Parse("0");

            for (int x = 1; x <= cant; x++)
            {
                Console.WriteLine("====================");
                float nota = 0;

                while (nota < 1 || nota > 7)
                {
                    Console.WriteLine("Ingrese la nota N°{0}", x);
                    nota = float.Parse(Console.ReadLine());

                    Console.WriteLine("====================");

                    if (nota >= 1 && nota <= 7)
                    {
                        Console.WriteLine("La nota {0} es valida", nota);
                    }
                    else
                    {
                        Console.WriteLine("Nota no válida.");
                    }
                }

                notas += nota;
            }

            float promedio = notas / cant;

            Console.WriteLine("====================");

            if (promedio >= 4.0)
            {
                Console.WriteLine("Has aprobado con nota {0}", promedio);
            }
            else
            {
                Console.WriteLine("Has reprobado con nota {0}", promedio);
            }
        }

        // Cree un programa de consola que solicite al cliente un monto para solicitar un crédito y la cantidad de cuotas en las que quiere pagar dicho préstamo, el programa debe calcular cuánto será el total que deberá pagar el cliente y cuando es el valor por cuota. Teniendo en cuenta que:
        // - Entre 1 y 12 cuotas el interés aplicado al monto es del 10%.
        // - Entre 13 y 30 cuotas el interés aplicado al monto es de 25%.
        // - Entre 31 y 40 cuotas el interés aplicado al monto es de 35%.
        // - Más de 40 cuotas el interés aplicado al monto es de un 50%.
        public void Ejercicio14()
        {
            Console.WriteLine("Ingrese el monto del crédito a solicitar:");
            float monto = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las cuotas en las que quiere pagar el crédito:");
            int cuotas = int.Parse(Console.ReadLine());

            if (cuotas >= 1 && cuotas <= 12)
            {

            }
        }

        // Cree un programa de consola que solicite al cliente su nombre y edad además del nombre y la edad de otra persona, el programa debe mostrar por pantalla el nombre de la persona menor y mayor, además de la diferencia de edad entre ambos.
        public void Ejercicio15()
        {

        }

        // Cree un programa de consola que solicite al cliente un número de minutos el programa debe mostrar por pantalla a cuantas horas y minutos corresponden al número ingresado.
        public void Ejercicio16()
        {

        }
    }
}
