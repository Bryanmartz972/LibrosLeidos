using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrosLeidos.Domain
{
    class ClsVisualizarDatos
    {
        public void AbrirFrmIngresoLibros()
        {
            FrmIngresoLibros frmIngresoLibros = new FrmIngresoLibros(false);
            frmIngresoLibros.ShowDialog();
        }
    }
}
