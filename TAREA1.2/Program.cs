using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables para estadísticas
            int cantidadSol = 0, cantidadSombra = 0, cantidadPreferencial = 0;
            int acumuladoSol = 0, acumuladoSombra = 0, acumuladoPreferencial = 0;

            // Variables de control de ciclo
            string continuar = "si";

            do
            {
                // Lectura de datos de la venta
                Console.Write("Número de factura: ");
                int numeroFactura = int.Parse(Console.ReadLine());

                Console.Write("Cédula: ");
                string cedula = Console.ReadLine();

                Console.Write("Nombre del comprador: ");
                string nombreComprador = Console.ReadLine();

                Console.WriteLine("Seleccione la localidad (1- Sol Norte/Sur, 2- Sombra Este/Oeste, 3- Preferencial): ");
                int localidad = int.Parse(Console.ReadLine());

                string nombreLocalidad = "";
                int precioEntrada = 0;

                switch (localidad)
                {
                    case 1:
                        nombreLocalidad = "Sol Norte/Sur";
                        precioEntrada = 10500;
                        break;
                    case 2:
                        nombreLocalidad = "Sombra Este/Oeste";
                        precioEntrada = 20500;
                        break;
                    case 3:
                        nombreLocalidad = "Preferencial";
                        precioEntrada = 25500;
                        break;
                    default:
                        Console.WriteLine("Localidad no válida.");
                        continue;
                }

                int cantidadEntradas = 0;
                do
                {
                    Console.Write("Cantidad de entradas (máximo 4): ");
                    cantidadEntradas = int.Parse(Console.ReadLine());
                } while (cantidadEntradas < 1 || cantidadEntradas > 4);

                // Cálculo de costos
                int subtotal = cantidadEntradas * precioEntrada;
                int cargosServicios = cantidadEntradas * 1000;
                int totalPagar = subtotal + cargosServicios;

                // Mostrar información de la venta
                Console.WriteLine($"\nNúmero de Factura: {numeroFactura}");
                Console.WriteLine($"Cédula: {cedula}");
                Console.WriteLine($"Nombre comprador: {nombreComprador}");
                Console.WriteLine($"Localidad: {nombreLocalidad}");
                Console.WriteLine($"Cantidad de Entradas: {cantidadEntradas}");
                Console.WriteLine($"Subtotal: {subtotal} colones");
                Console.WriteLine($"Cargos por Servicios: {cargosServicios} colones");
                Console.WriteLine($"Total a pagar: {totalPagar} colones\n");

                // Actualizar estadísticas
                switch (localidad)
                {
                    case 1:
                        cantidadSol += cantidadEntradas;
                        acumuladoSol += subtotal;
                        break;
                    case 2:
                        cantidadSombra += cantidadEntradas;
                        acumuladoSombra += subtotal;
                        break;
                    case 3:
                        cantidadPreferencial += cantidadEntradas;
                        acumuladoPreferencial += subtotal;
                        break;
                }

                // Preguntar si desea continuar
                Console.Write("¿Desea ingresar otra venta? (si/no): ");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "si");

            // Mostrar estadísticas finales
            Console.WriteLine("\nEstadísticas:");
            Console.WriteLine($"Cantidad Entradas Localidad Sol Norte/Sur: {cantidadSol}");
            Console.WriteLine($"Acumulado Dinero Localidad Sol Norte/Sur: {acumuladoSol} colones");
            Console.WriteLine($"Cantidad Entradas Localidad Sombra Este/Oeste: {cantidadSombra}");
            Console.WriteLine($"Acumulado Dinero Localidad Sombra Este/Oeste: {acumuladoSombra} colones");
            Console.WriteLine($"Cantidad Entradas Localidad Preferencial: {cantidadPreferencial}");
            Console.WriteLine($"Acumulado Dinero Localidad Preferencial: {acumuladoPreferencial} colones");
        }
    }
}


