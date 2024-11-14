using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitasMedicasEstudiantes
{
    internal class CitaUtil
    {
        public static void CrearCita(ref Cita[] citas, ref int contadorCitas)
        {

            Console.WriteLine("Ingrese el código del estudiante:");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del estudiante:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la universidad del estudiante:");
            string universidad = Console.ReadLine();

            Estudiante estudiante = new Estudiante(codigo, nombre, universidad);

            Console.WriteLine("Ingrese la enfermedad:");
            string enfermedad = Console.ReadLine();
            Console.WriteLine("Ingrese el precio de la cita:");
            double precio = double.Parse(Console.ReadLine());

            Cita nuevaCita = new Cita(contadorCitas + 1, estudiante, enfermedad, precio);

            Array.Resize(ref citas, citas.Length + 1);
            citas[citas.Length - 1] = nuevaCita;

            contadorCitas++;
            Console.WriteLine("Cita creada con éxito.");
        }

        public static void ListarCitas(Cita[] citas)
        {
            double sumaPrecios = 0;

            Console.WriteLine("\nListado de citas médicas:");
            foreach (var cita in citas)
            {
                Console.WriteLine(cita.ToString());
                sumaPrecios += cita.Precio;
            }

            Console.WriteLine($"\nTotal de precios de todas las citas: {sumaPrecios}");
        }

        public static void ModificarMasivo(ref Cita[] citas, string textoBuscar, string textoReemplazar)
        {
            foreach (var cita in citas)
            {
                if (cita.Estudiante.Universidad.Contains(textoBuscar))
                {
                    cita.Estudiante.Universidad = cita.Estudiante.Universidad.Replace(textoBuscar, textoReemplazar);
                }
            }

            Console.WriteLine($"Se modificaron las universidades que contenían '{textoBuscar}' por '{textoReemplazar}'.");
        }
    }
}
