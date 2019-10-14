using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace practicando01
{
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
            cargarComboBox();
        }

        private void cargarComboBox()
        {
            comboBoxApeNom.DataSource = NegocioAlumno.RecuperarTodos(); // de aca salen los datos
            comboBoxApeNom.DisplayMember="ApeNom"; // mostrar apellido y nombre
            comboBoxApeNom.ValueMember = "Id"; //lo muestra por id????
            comboBoxApeNom.SelectedIndex = -1; //no tiene seleccionado ninguno por default
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void comboBoxApeNom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (comboBoxApeNom.SelectedIndex != -1)
            {
                NegocioAlumno alu = new NegocioAlumno();
                int id_seleccion = Convert.ToInt32(comboBoxApeNom.SelectedValue);
                MessageBox.Show(AlumnoaTexto((alu.RecuperarUno(id_seleccion))));
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún alumno");
            }

        }

        public string AlumnoaTexto(EAlumno alumno) //necesito pasarlo a texto para poder usar el messagebox
        {
            string textoAlumno = "Datos del alumno seleccionado \n";
            textoAlumno+="Id:"+ alumno.Id + "\n";
            textoAlumno+="Apellido y nombre:"+alumno.ApeNom +"\n";
            textoAlumno += "Email:" + alumno.Email + "\n";
            textoAlumno += "Edad:" + alumno.Edad.ToString() + "\n";
            textoAlumno += "Nota promedio:" + alumno.NotaAvg.ToString() + "\n";
            return textoAlumno;

        }
    }
}
