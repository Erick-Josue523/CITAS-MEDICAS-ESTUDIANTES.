using System;
using CitasMedicasEstudiantes;

class Program
{
    static void Main()
    {
        Cita[] citas = new Cita[0];
        int contadorCitas = 0;
        bool salir = false;

        while (!salir)
        {
            // Menú de opciones
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Crear Cita");
            Console.WriteLine("2. Listar Citas");
            Console.WriteLine("3. Modificar Masivamente");
            Console.WriteLine("4. Fin");
            Console.Write("Seleccione una opción (1-4): ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    CitaUtil.CrearCita(ref citas, ref contadorCitas);
                    break;

                case "2":
                    CitaUtil.ListarCitas(citas);
                    break;

                case "3":
                    Console.WriteLine("Ingrese el texto a buscar:");
                    string buscar = Console.ReadLine();
                    Console.WriteLine("Ingrese el texto para reemplazar:");
                    string reemplazar = Console.ReadLine();
                    CitaUtil.ModificarMasivo(ref citas, buscar, reemplazar);
                    break;

                case "4":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción inválida, por favor intente de nuevo.");
                    break;
            }
        }

        Console.WriteLine("Gracias por usar el sistema de citas médicas.");
    }
}
