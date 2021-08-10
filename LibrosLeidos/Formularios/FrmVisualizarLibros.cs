using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using LibrosLeidos.Domain;

namespace LibrosLeidos
{
    public partial class FrmVisualizarLibros : KryptonForm
    {
        ClsVisualizarDatos datos = new ClsVisualizarDatos();
        private BusinessLogicLayer _businessLogicLayer = new BusinessLogicLayer();

        public FrmVisualizarLibros()
        {
            InitializeComponent();
        }

        private void FrmVisualizarLibros_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private void CargarLibros()
        {
            List<ClsIngresoDatos> libros = _businessLogicLayer.ObtenerLibros();
            dgvLibrosLeidos.DataSource = libros;
        }

        private void btnIngresarLibro_Click(object sender, EventArgs e)
        {
            this.Hide();
            datos.AbrirFrmIngresoLibros();
            this.Close();
        }  
    }
}
