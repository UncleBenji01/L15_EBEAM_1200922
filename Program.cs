using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace L15_EBEAM_1200922
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string OPCIONES;
            Console.WriteLine("Sea Bienvenido al menu");
            Console.WriteLine("Presione 1: = opcion1 ");
            Console.WriteLine("Presione 2: = opcion2 ");
            Console.WriteLine("Presione 3: = opcion3 ");
            OPCIONES = Console.ReadLine();

            switch (OPCIONES)
            {
                case "1":
                    cargarvector cv = new cargarvector();
                    cv.FirstEx(); 
                    break;
                case "2":
                    cargarvector se = new cargarvector();
                    se.SecondEx();
                    break;
                case "3":
                    Console.WriteLine(" Puede salir del programa");
                    Environment.Exit(0);
                    break;
            }
        }

        internal class cargarvector
        {
            /*************************************************************************************************/
            //var first ex
            string[] empleados = new string[5];
            int[] nacimiento = new int[5];
            //var second ex
            string[] NomApe = new string[5];
            double[] nota = new double[5];
            
            /*************************************************************************************************/
            public void FirstEx()
            {
                string[] empleados = new string[5];
                int[] edades = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingrese el Nombre de un empleado : " + (i + 1));
                    empleados[i] = (Console.ReadLine());
                    Console.WriteLine("Ingrese su edad: " + (i + 1));
                    edades[i] = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Nombre del empleado : " + empleados[i]);
                    Console.WriteLine("Edad: " + edades[i].ToString());
                }
                Console.Clear();
                int prom = 0;
                
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("El nombre de la persona y su edad: " + empleados[i] + "," + edades[i].ToString());
                }
                prom = ((edades[0] + edades[1] + edades[2] + edades[3] + edades[4])/ 5); 
                Console.WriteLine(" El promedio de las edades es: " + prom);
                Console.ReadKey();
                Console.Clear();

                int mayor = 0;
                string persona = "";
                for (int i = 0; i < 5; i++)
                {
                    if (edades[i] > mayor)
                    {
                        mayor = edades[i];
                        persona = empleados[i];
                    }
                }
                Console.WriteLine(persona + " tiene " + mayor + " años, lo cual es el mayor");
                Console.ReadKey();
                Console.Clear();
            }
            /*************************************************************************************************/
            public void SecondEx()
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingrese el nombre y apellido No.0" + (i+1));
                    NomApe[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese la nota No.0" + (i + 1));
                    nota[i] = Convert.ToDouble(Console.ReadLine());
                }
                Console.ReadKey();
                Console.Clear();
                string personaM = "";
                double mayor = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (nota[i] > mayor)
                    {
                        mayor = nota[i];
                        personaM = NomApe[i];
                    }
                }
                string personaMn = "";
                double menor = nota[0];
                for (int i = 0; i < 5; i++)
                {
                    if (nota[i] < menor)
                    {
                        menor = nota[i];
                        personaMn = NomApe[i];
                    }
                }
                Console.WriteLine(personaM + " tiene " + mayor + " de punteo, lo cual tiene la calificacion mas alta");
                Console.WriteLine(personaMn + " tiene " + menor + " de punteo, lo cual tiene la calificacion mas baja");
                Console.ReadKey();
                Console.Clear();

                int aprobado = 0, reprobado = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (nota[i] < 71)
                    {
                        reprobado = reprobado + 1;
                        Console.WriteLine(NomApe[i] + " esta reprobado, su calificacion fue " + nota[i]);
                    }
                }
                
                for (int i = 0; i < 5; i++)
                {
                    if (nota[i] >= 71)
                    {
                        aprobado = aprobado + 1;
                        Console.WriteLine(NomApe[i] + " esta aprobado, su calificacion fue " + nota[i]);
                    }
                }
                Console.ReadKey();

                double prom = 0;
                prom = ((nota[0] + nota[1] + nota[2] + nota[3] + nota[4])/5);
                Console.WriteLine("Promedio notas: " + prom);
                Console.ReadKey();
            }
        }
    }
}
