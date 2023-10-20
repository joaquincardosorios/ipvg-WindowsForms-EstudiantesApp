using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL
{
    public class EstudianteDAL
    {
        public bool GuardarEstudiante(Estudiante estudiante)
        {
            string fecharFormateada = estudiante.DoB.ToString("yyyy-MM-dd");
            string query = $"" +
                $"INSERT INTO Estudiantes(rut, nombres, apellidos, dob) " +
                $"VALUES('{estudiante.Rut}', '{estudiante.Nombres}', '{estudiante.Apellidos}', '{fecharFormateada}')";
            int rows = DatabaseHelper.Instance.ExecuteNonQuery(query);
            if (rows == 0)
            {
                return false;
            }
            return true;
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            string query = "SELECT * FROM Estudiantes";
            DataTable dt = DatabaseHelper.Instance.ExecuteQuery(query);
            List<Estudiante> tareas = new List<Estudiante>();
            foreach (DataRow row in dt.Rows)
            {
                Estudiante e = new Estudiante();
                e.Rut = row["rut"].ToString().TrimEnd();
                e.Nombres = row["nombres"].ToString().TrimEnd();
                e.Apellidos = row["apellidos"].ToString().TrimEnd();

                if (DateTime.TryParse(row["dob"].ToString(), out DateTime fechaNacimiento))
                {
                    e.DoB  = fechaNacimiento;
                }
                tareas.Add(e);
            }
            return tareas;

        }

        public bool EliminarEstudiante(string rut)
        {
            string query = $"DELETE FROM Estudiantes WHERE rut = {rut}";
            int rows = DatabaseHelper.Instance.ExecuteNonQuery(query);
            return rows > 0;

        }
    }
}
