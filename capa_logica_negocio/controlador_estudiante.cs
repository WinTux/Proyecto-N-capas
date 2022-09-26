using capa_datos;
using capa_datos.Modelos;
using capa_logica_negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace capa_logica_negocio
{
    public class controladorEstudiante
    {
        public static List<Estudiante> GetEstudiantes() {
            using (GestionEmpresaXDbContext ddbb = new GestionEmpresaXDbContext()) {
                return ddbb.Estudiantes.ToList();
            }
        }
        public static List<EstudianteMin> GetEstudiantesMin()
        {
            using (GestionEmpresaXDbContext ddbb = new GestionEmpresaXDbContext())
            {
                return ddbb.Estudiantes
                    .Select(es => new EstudianteMin { 
                        carnet = es.ci, 
                        nombre = es.nombre, 
                        apellidos = es.apellido})
                    .ToList();
            }
        }
    }
}
