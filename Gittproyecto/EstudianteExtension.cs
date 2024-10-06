using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gittproyecto
{
    internal static class EstudianteExtension
    {
        public static string MostrarInformacion(this Universidad.Estudiante estudiante)
        {
            var porcentajeAsistencia = estudiante.CalcularPorcentajeAsistencia();
            var estado = estudiante.ValidarAsistencia();

            return $"Nombre: {estudiante.nombre}" +
                   $"Asistencia Total: {estudiante.asistenciaTotal}" +
                   $"Asistencia Asistida: {estudiante.asistenciaAsistida}" +
                   $"Porcentaje de asistencia: {porcentajeAsistencia}" +
                   $"Estado: {estado}";
        }
    }
}
