using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrosLeidos.Domain
{
    class ClsIngresoDatos
    {
        public int id { get; set; }
        public int numero_id_ano { get; set; }
        public string nombre_libro { get; set; }
        public string nombre_autor { get; set; }
        public string saga_serie_trilogia { get; set; }
        public double numero_saga { get; set; }
        public int ano_leido { get; set; }

        public void AbrirFrmVisualizarDatos()
        {
            FrmVisualizarLibros frmVisualizarLibros = new FrmVisualizarLibros();
            frmVisualizarLibros.ShowDialog();
        }
    }
}
