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
using System.Text.RegularExpressions;

namespace LibrosLeidos
{
    public partial class FrmIngresoLibros : KryptonForm
    {
        private BusinessLogicLayer _businessLogicLayer = new BusinessLogicLayer();
        private ClsIngresoDatos ingreso;
        private ClsIngresoDatos _ingreso;


        public FrmIngresoLibros()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ingreso = new ClsIngresoDatos();
            ingreso.numero_id_ano = int.Parse(txtNumeroLibroLeido.Text.Trim());
            ingreso.nombre_libro = txtNombreLibro.Text.Trim();
            ingreso.nombre_autor = txtAutorLibro.Text.Trim();
            ingreso.ano_leido = Convert.ToInt32(nmrAnoLeido.Value);
            ingreso.saga_serie_trilogia = txtSagaSerieTrilogia.Text.Trim();

            ingreso.id = _ingreso != null ? _ingreso.id : 0;

            if (String.IsNullOrEmpty(txtNumeroSaga.Text))
                ingreso.numero_saga = 0;
            else
                ingreso.numero_saga = double.Parse(txtNumeroSaga.Text.Trim());

            try
            {
                _businessLogicLayer.GuardarLibro(ingreso);
                LimpiarCampos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnLibrosLeidos_Click(object sender, EventArgs e)
        {
            ingreso = new ClsIngresoDatos();
            this.Hide();
            ingreso.AbrirFrmVisualizarDatos();
            this.Close();
        }

        private void txtNumeroSaga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (Regex.IsMatch(txtNumeroSaga.Text, @"\.\d") && e.KeyChar != 8)  //Valida que solo se puedan colocar dos digitos despues del punto decimal
            {
                e.Handled = true;
            }
        }

        private void txtNumeroLibroLeido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void LimpiarCampos()
        {
            txtAutorLibro.Text = String.Empty;
            txtNombreLibro.Text = String.Empty;
            txtNumeroSaga.Text = String.Empty;
            txtNumeroLibroLeido.Text = String.Empty;
            txtSagaSerieTrilogia.Text = String.Empty;
        }

        public void CargarLibros(ClsIngresoDatos ingreso)
        {
            _ingreso = ingreso;

            if (ingreso != null)
            {
                LimpiarCampos();
                txtNombreLibro.Text = ingreso.nombre_libro;
                txtAutorLibro.Text = ingreso.nombre_autor;
                txtNumeroSaga.Text = ingreso.numero_saga.ToString();
                txtNumeroLibroLeido.Text = ingreso.numero_id_ano.ToString();
                txtSagaSerieTrilogia.Text = ingreso.saga_serie_trilogia;
                nmrAnoLeido.Value = ingreso.ano_leido;
            }
        }
    }
}
