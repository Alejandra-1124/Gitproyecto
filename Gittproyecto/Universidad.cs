using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gittproyecto
{
    public class Universidad
    {
        public class Estudiante
        {


            public string nombre { get; set; }
            public int asistenciaTotal { get; set; }
            public int asistenciaAsistida { get; set; }

            public Estudiante(string nombre, int asistenciaTotal, int asistenciaAsistida)
            {
                this.nombre = nombre;
                this.asistenciaTotal = asistenciaTotal;
                this.asistenciaAsistida = asistenciaAsistida;
            }

            public double CalcularPorcentajeAsistencia()
            {
                if (asistenciaTotal == 0) return 0;
                return (double)asistenciaAsistida / asistenciaTotal * 100;
            }

            public string ValidarAsistencia()
            {
                if(asistenciaTotal < 0 || asistenciaAsistida < 0)
                {
                    return "La asistencia no puede ser negativa";
                }
                if(asistenciaAsistida > asistenciaTotal)
                {
                    return "La asistencia del estudiante no puede ser mayor que el total de asistencias";
                }
                
                double porcentajeAsistencia = CalcularPorcentajeAsistencia();

                if(porcentajeAsistencia < 0 || porcentajeAsistencia > 100)
                {
                    return "El porcentaje de asistencia debe ser entre 0% y 100%";
                }

                const int asistenciaMinima = 75;
                if(asistenciaAsistida <= 0 || porcentajeAsistencia < asistenciaMinima)
                {
                    return "Reprobado";
                }
                return "Aprobado";
            }


        }
    }
}
