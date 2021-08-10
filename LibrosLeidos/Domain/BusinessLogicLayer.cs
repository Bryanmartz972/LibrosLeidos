using LibrosLeidos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrosLeidos.Domain
{
    class BusinessLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }

        public ClsIngresoDatos GuardarLibro(ClsIngresoDatos ingreso)
        {
            if (ingreso.id == 0)
                _dataAccessLayer.InsertarLibro(ingreso);
            //else
            // _dataAccessLayer.ModificarLibro();

            return ingreso;
        }

        public List<ClsIngresoDatos> ObtenerLibros()
        {
           return _dataAccessLayer.ObtenerLibros();
        }
    }
}
