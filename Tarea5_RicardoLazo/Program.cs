using System;
using System.Collections.Generic;
using System.Linq;

namespace Tarea5_RicardoLazo
{
    class Program
    {
        static void Main()
        {
            List<IMostrarInformacion> EmpleadosYGerentes = new List<IMostrarInformacion>();
            // Datos quemados para empleados
            EmpleadosYGerentes.Add(new Empleado("Ronald", 50000));
            EmpleadosYGerentes.Add(new Empleado("Ricardo", 60000));
            EmpleadosYGerentes.Add(new Empleado("Walter", 70000));

            // Datos quemados para gerentes
            EmpleadosYGerentes.Add(new Gerente("Yolanda", 80000, "Ventas"));
            EmpleadosYGerentes.Add(new Gerente("Maria", 90000, "Marketing"));
            EmpleadosYGerentes.Add(new Gerente("Carmen", 100000, "Recursos Humanos"));

            int opcionPrincipal;

            do
            {
                Console.WriteLine("1. Ingresar Datos");
                Console.WriteLine("2. Visualizar Datos");
                Console.WriteLine("3. Terminar la ejecucion");
                Console.Write("Ingrese la opción deseada: ");


                while (!int.TryParse(Console.ReadLine(), out opcionPrincipal) || opcionPrincipal < 1 || opcionPrincipal > 3)
                {
                    Console.WriteLine("Opción no válida. Ingrese nuevamente.");
                    Console.Write("Ingrese la opción deseada: ");
                }

                switch (opcionPrincipal)
                {
                    case 1:
                        int opcionIngresarDatos;

                        do
                        {
                            Console.WriteLine("1. Ingresar Datos de Empleado");
                            Console.WriteLine("2. Ingresar Datos de Gerente");
                            Console.WriteLine("3. Volver Atrás");
                            Console.Write("Ingrese la opción deseada: ");


                            while (!int.TryParse(Console.ReadLine(), out opcionIngresarDatos) || opcionIngresarDatos < 1 || opcionIngresarDatos > 3)
                            {
                                Console.WriteLine("Opción no válida. Ingrese nuevamente.");
                                Console.Write("Ingrese la opción deseada: ");
                            }

                            switch (opcionIngresarDatos)
                            {
                                case 1:
                                    Console.Write("Ingrese el nombre del empleado: ");
                                    string nombreEmpleado = Console.ReadLine();
                                    Console.Write("Ingrese el salario del empleado: ");
                                    decimal salarioEmpleado;
                                    while (!decimal.TryParse(Console.ReadLine(), out salarioEmpleado) || salarioEmpleado < 0)
                                    {
                                        Console.WriteLine("Salario no válido. Ingrese nuevamente.");
                                        Console.Write("Ingrese el salario del empleado: ");
                                    }
                                    EmpleadosYGerentes.Add(new Empleado(nombreEmpleado, salarioEmpleado));
                                    break;
                                case 2:
                                    Console.Write("Ingrese el nombre del gerente: ");
                                    string nombreGerente = Console.ReadLine();
                                    Console.Write("Ingrese el salario del gerente: ");
                                    decimal salarioGerente;
                                    while (!decimal.TryParse(Console.ReadLine(), out salarioGerente) || salarioGerente < 0)
                                    {
                                        Console.WriteLine("Salario no válido. Ingrese nuevamente.");
                                        Console.Write("Ingrese el salario del gerente: ");
                                    }
                                    Console.Write("Ingrese el departamento del gerente: ");
                                    string departamentoGerente = Console.ReadLine();
                                    EmpleadosYGerentes.Add(new Gerente(nombreGerente, salarioGerente, departamentoGerente));
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida. Ingrese nuevamente.");
                                    break;
                            }
                        } while (opcionIngresarDatos != 3);

                        break;

                    case 2:
                        int opcionVisualizarDatos;

                        do
                        {
                            Console.WriteLine("1. Visualizar Datos");
                            Console.WriteLine("2. Salir");
                            Console.Write("Ingrese la opción deseada: ");

                            while (!int.TryParse(Console.ReadLine(), out opcionVisualizarDatos) || opcionVisualizarDatos < 1 || opcionVisualizarDatos > 2)
                            {
                                Console.WriteLine("Opción no válida. Ingrese nuevamente.");
                                Console.Write("Ingrese la opción deseada: ");
                            }

                            switch (opcionVisualizarDatos)
                            {
                                case 1:
                                    Console.WriteLine("Datos de Empleados y Gerentes:");
                                    foreach (var empleado in EmpleadosYGerentes.OfType<Empleado>())
                                    {
                                        empleado.MostrarInformacion();
                                        Console.WriteLine();
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Saliendo...");
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida. Ingrese nuevamente.");
                                    break;
                            }

                            

                        } while (opcionVisualizarDatos != 2);

                        break;

                    case 3:
                        Console.WriteLine("Terminando la ejecución del programa.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Ingrese nuevamente.");
                        break;
                }


            } while (opcionPrincipal != 3);
        }
    }
}