using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBasicos
{
    class Program
    {
        public static Ej1a4 ej1a4 = new Ej1a4();
        public static Ej5a8 ej5a8 = new Ej5a8();
        public static Ej9a12 ej9a12 = new Ej9a12();
        public static Ej13a16 ej13a16 = new Ej13a16();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("Ingrese el número del ejercicio:");
                Console.WriteLine("========================================");
                Console.WriteLine("1.- Ejercicio N°1");
                Console.WriteLine("2.- Ejercicio N°2");
                Console.WriteLine("3.- Ejercicio N°3");
                Console.WriteLine("4.- Ejercicio N°4");
                Console.WriteLine("5.- Ejercicio N°5");
                Console.WriteLine("6.- Ejercicio N°6");
                Console.WriteLine("7.- Ejercicio N°7");
                Console.WriteLine("8.- Ejercicio N°8");
                Console.WriteLine("9.- Ejercicio N°9");
                Console.WriteLine("10.- Ejercicio N°10");
                Console.WriteLine("11.- Ejercicio N°11");
                Console.WriteLine("12.- Ejercicio N°12");
                Console.WriteLine("13.- Ejercicio N°13");
                Console.WriteLine("14.- Ejercicio N°14");
                Console.WriteLine("15.- Ejercicio N°15");
                Console.WriteLine("16.- Ejercicio N°16");
                Console.WriteLine("17.- Salir");
                Console.WriteLine("========================================");

                int option = int.Parse(Console.ReadLine());

                Console.WriteLine("========================================");

                switch (option)
                {
                    case 1:
                        ej1a4.Ejercicio1();
                        break;
                    case 2:
                        ej1a4.Ejercicio2();
                        break;
                    case 3:
                        ej1a4.Ejercicio3();
                        break;
                    case 4:
                        ej1a4.Ejercicio4();
                        break;
                    case 5:
                        ej5a8.Ejercicio5();
                        break;
                    case 6:
                        ej5a8.Ejercicio6();
                        break;
                    case 7:
                        ej5a8.Ejercicio7();
                        break;
                    case 8:
                        ej5a8.Ejercicio8();
                        break;
                    case 9:
                        ej9a12.Ejercicio9();
                        break;
                    case 10:
                        ej9a12.Ejercicio10();
                        break;
                    case 11:
                        ej9a12.Ejercicio11();
                        break;
                    case 12:
                        ej9a12.Ejercicio12();
                        break;
                    case 13:
                        ej13a16.Ejercicio13();
                        break;
                    case 14:
                        ej13a16.Ejercicio14();
                        break;
                    case 15:
                        ej13a16.Ejercicio15();
                        break;
                    case 16:
                        ej13a16.Ejercicio16();
                        break;
                    case 17:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Debe ingresar un número válido.");
                        break;
                }

                Console.WriteLine("========================================");
                Console.Write("Presione Enter para continuar...");
                Console.ReadLine();
            }
        }
    }
}
