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

namespace practicando01
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.Listar();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

            
        }


        public void Listar()
        {
            NegocioAlumno alu = new NegocioAlumno();
            dataGridAlu.DataSource = alu.RecuperarTodos();
        }
        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista l1 = new Lista();
            this.Hide();
            l1.Show();
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
