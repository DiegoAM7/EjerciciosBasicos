using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos
{
    public class Ej9a12
    {
        // Cree un programa de consola que solicite al usuario un número entre el 1 y el 12, el programa debe mostrar por pantalla el nombre del mes que corresponda al número ingresado. Si el número ingresado no está entre 1 y 12 debe mostrar por pantalla error al ingresar el número.
        public void Ejercicio9()
        {
            List<string> meses = new List<string>()
            {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            };

            Console.WriteLine("Ingrese un número del 1 al 12 y se mostrará el mes del año correspondiente:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("====================");

            if (num >= 1 && num <= 12)
            {
                Console.WriteLine(meses[num - 1]);
            }
            else
            {
                Console.WriteLine("Error al ingresar el número.");
            }
        }

        // Cree un programa de consola que solicite dos números al cliente, si el número primer número ingresado es par y el segundo número es impar el programa debe mostrar por pantalla par e impar, si ambos números son pares debe mostrar por pantalla par y para, si el primer número es impar y el segundo es par debe mostrar por pantalla impar y par. 
        public void Ejercicio10()
        {
            Console.WriteLine("Ingrese dos números, se determinara cuales son pares e impares.");
            Console.WriteLine("Ingrese el primer número:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("====================");
            
            if(num1 % 2 == 0)
            {
                Console.Write("Par");
            } else
            {
                Console.Write("Impar");
            }

            if (num2 % 2 == 0)
            {
                Console.WriteLine(" y Par");
            }
            else
            {
                Console.WriteLine(" e Impar");
            }
        }

        // Mejore el ejercicio 10 agregando un número a la ecuación.
        public void Ejercicio11()
        {
            Console.WriteLine("Ingrese tres números, se determinara cuales son pares e impares.");
            Console.WriteLine("Ingrese el primer número:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número:");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("====================");

            if (num1 % 2 == 0)
            {
                Console.Write("Par");
            }
            else
            {
                Console.Write("Impar");
            }

            if (num2 % 2 == 0)
            {
                Console.Write(", Par");
            }
            else
            {
                Console.Write(", Impar");
            }

            if (num3 % 2 == 0)
            {
                Console.WriteLine(" y Par");
            }
            else
            {
                Console.WriteLine(" e Impar");
            }
        }

        // Cree un programa de consola que solicite al usuario una nota entre el 1 y el 7. Si el número ingresado no está entre 1 y 7 el programa debe volver a solicitar la nota hasta que este entre el rango correcto, cuando así suceda el programa debe mostrar por pantalla la nota es válida.
        public void Ejercicio12()
        {
            float nota = 0;

            while (nota < 1 || nota > 7)
            {
                Console.WriteLine("Ingrese una nota entre 1 y 7");
                nota = float.Parse(Console.ReadLine());

                Console.WriteLine("====================");

                if (nota >= 1 && nota <= 7)
                {
                    Console.WriteLine("La nota {0} es valida", nota);
                } else
                {
                    Console.WriteLine("Nota no válida.");
                }
            }
        }
    }
}
