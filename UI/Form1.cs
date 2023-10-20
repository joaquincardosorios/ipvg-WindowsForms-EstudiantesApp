using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace UI
{
    public partial class Form1 : Form
    {
        private EstudianteBLL estudianteBLL;
        public Form1()
        {
            InitializeComponent();
            estudianteBLL = new EstudianteBLL();
            this.CargarEstudiantes();
        }

        public void CargarEstudiantes()
        {
            this.dtgvEstudiantes.Rows.Clear();
            List<Estudiante> estudiantes = estudianteBLL.ObtenerEstudiantes();
            foreach (Estudiante e in estudiantes)
            {
                int n = dtgvEstudiantes.Rows.Add();
                dtgvEstudiantes.Rows[n].Cells[0].Value = e.Rut;
                dtgvEstudiantes.Rows[n].Cells[1].Value = e.Nombres;
                dtgvEstudiantes.Rows[n].Cells[2].Value = e.Apellidos;
                dtgvEstudiantes.Rows[n].Cells[3].Value = e.DoB.ToString("dd-MM-yyyy");

            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string rut = txtRut.Text;
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            DateTime dob = dtpDoB.Value.Date;

            Estudiante estudiante = new Estudiante(rut, nombres, apellidos, dob);
            try
            {
                this.estudianteBLL.AgregarEstudiante(estudiante);
                txtRut.Clear();
                txtNombres.Clear();
                txtApellidos.Clear();
                dtpDoB.ResetText();
                this.CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvEstudiantes.SelectedRows.Count > 0)
                {

                    DataGridViewRow filaSeleccionada = dtgvEstudiantes.SelectedRows[0];
                    string rut = filaSeleccionada.Cells[0].Value.ToString();

                    string mensaje = $"¿Estás seguro de que deseas eliminar al estudiante? Esta acción no se puede deshacer.";
                    DialogResult resultado = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        this.estudianteBLL.EliminarEstudiante(rut);
                        this.CargarEstudiantes();
                        MessageBox.Show("El estudiante ha sido eliminado exitosamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    
                    MessageBox.Show("No se ha seleccionado ninguna fila. Haga click en la celda vacia de la primera columna para seleccionar al alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
