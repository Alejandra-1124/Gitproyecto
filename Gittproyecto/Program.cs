using System;

namespace Gittproyecto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al registro de control de asistencias");

            while (true)
            {
                Console.WriteLine("Estudiante a registrar");
                Console.WriteLine("Ingrese el primer nombre y apellido del estudiante:");
                string nombre = Console.ReadLine();

                int asistenciaTotal;
                while (true)
                {
                    Console.WriteLine("Ingrese la asistencia total: ");
                    if (int.TryParse(Console.ReadLine(), out asistenciaTotal) && asistenciaTotal >= 0)
                    {
                        break;
                    }
                    Console.WriteLine("La asistencia total debe ser un número entero no negativo. Intente nuevamente.");
                }

                int asistenciaAsistida;
                while (true)
                {
                    Console.WriteLine("Ingrese la asistencia asistida: ");
                    if (int.TryParse(Console.ReadLine(), out asistenciaAsistida) && asistenciaAsistida >= 0)
                    {
                        if (asistenciaAsistida <= asistenciaTotal)
                        {
                            break;
                        }
                        Console.WriteLine("La asistencia asistida no puede ser mayor que la asistencia total. Intente nuevamente.");
                    }
                    else
                    {
                        Console.WriteLine("La asistencia asistida debe ser un número entero no negativo. Intente nuevamente.");
                    }
                }

                // Instancia estudiante
                var estudiante = new Universidad.Estudiante(nombre, asistenciaTotal, asistenciaAsistida);

                Console.WriteLine();
                string informacion = estudiante.MostrarInformacion();
                Console.WriteLine(informacion);

                Console.WriteLine("¿Desea registrar otro estudiante? (si/no)");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "si")
                {
                    Console.WriteLine("Gracias por usar el sistema. Hasta luego!");
                    break; 
                }
            }
        }
    }
}
