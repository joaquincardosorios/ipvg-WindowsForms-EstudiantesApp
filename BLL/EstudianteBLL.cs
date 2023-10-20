using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class EstudianteBLL
    {
        private EstudianteDAL estudianteDal;
        public EstudianteBLL()
        {
            estudianteDal = new EstudianteDAL();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            Type tipo = estudiante.GetType();
            PropertyInfo[] propiedades = tipo.GetProperties();

            estudiante.Rut = estudiante.Rut.TrimEnd();
            estudiante.Nombres = estudiante.Nombres.TrimEnd();
            estudiante.Apellidos = estudiante.Apellidos.TrimEnd();

            // Verifica que todos los campos no esten vacios excepto el fecha
            foreach (var propiedad in propiedades)
            {
                if (propiedad.PropertyType == typeof(string))
                {
                    string valor = propiedad.GetValue(estudiante) as string;
                    if (string.IsNullOrEmpty(valor))
                    {
                        throw new Exception($"La propiedad {propiedad.Name} no debe estar vacia.");
                    }
                }
            }

            // TODO: Verificar que el alumno no esta registrado
            Estudiante estudianteExiste = estudianteDal.ObtenerEstudiantes().Where(e => e.Rut.Equals(estudiante.Rut)).FirstOrDefault();
            if (estudianteExiste != null){
             throw new Exception("El estudiante ya fue registrado");
            }

            // TODO: Intentar guardar al estudiante
            if(!estudianteDal.GuardarEstudiante(estudiante)) {
            throw new Exception("No se ha podido guardar al estudiante");
            }

        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            return estudianteDal.ObtenerEstudiantes();
        }

        public void EliminarEstudiante(string rut)
        {
            if (!estudianteDal.EliminarEstudiante(rut))
            {
                throw new Exception("No se ha podido eliminar al estudiante");
            }
        }

    }
}
