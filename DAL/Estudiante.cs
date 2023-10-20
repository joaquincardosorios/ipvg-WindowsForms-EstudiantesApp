using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Estudiante
    {

        public Estudiante() { }

        public Estudiante(int id, String rut, String nombres, String apellidos, DateTime dob) 
        {
            this.Id = id;
            this.Rut = rut;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.DoB = dob;
        }

        public Estudiante(String rut, String nombres, String apellidos, DateTime dob)
        {
            this.Rut = rut;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.DoB = dob;
        }

        public int Id { get; set; }
        public String Rut { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public DateTime DoB { get; set; }

    }
}
