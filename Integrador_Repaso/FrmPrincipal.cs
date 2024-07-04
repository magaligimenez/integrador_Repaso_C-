using Clases;
using Clases.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador_Repaso
{
    public partial class FrmPrincipal : Form
    {
        Empresa miEmpresa;
        public FrmPrincipal()
        {
            InitializeComponent();
            miEmpresa = new Empresa("utn221");
            Desarrollador desarrollador1 = new Desarrollador(1, "Juan", "Pérez", 30, "Desarrollo", 3000, 50);
            Gerente gerente1 = new Gerente(2, "Ana", "García", 40, "Gerencia", 5000, 5);
            Desarrollador desarrollador2 = new Desarrollador(3, "Maria", "Lopez", 25, "Testing", 8000, 70);
            Desarrollador desarrollador3 = new Desarrollador(4, "Juan", "Pérez", 30, "Desarrollo", 3000, 50);
            Gerente gerente2 = new Gerente(5, "Alan", "Gomez", 42, "Gerencia", 5050, 13);

            miEmpresa.AñadirEmpleado(desarrollador1);
            miEmpresa.AñadirEmpleado(desarrollador2); 
            miEmpresa.AñadirEmpleado(desarrollador3);
            miEmpresa.AñadirEmpleado(gerente1);
            miEmpresa.AñadirEmpleado(gerente2);
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDesarrollador miFormulario = new FrmDesarrollador();
                if (miFormulario.ShowDialog() == DialogResult.OK)
                {
                    miEmpresa.AñadirEmpleado(miFormulario.DesarrolladorFormulario);
                }
                else
                {
                    MessageBox.Show("accion cancelada por el usuario");
                }
            }
            catch (EmpleadoNoEncotradoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(miEmpresa);
            mostrar.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
