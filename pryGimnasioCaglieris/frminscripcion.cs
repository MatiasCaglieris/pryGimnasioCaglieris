using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGimnasioCaglieris
{
    public partial class frmInscripcion : Form
    {
        // Constantes a nivel de clase (NOMBRES EN MAYÚSCULAS)
        // Ajustar los valores por defecto según necesidad
        private const decimal PRECIO_NATACION = 100.00m;
        private const decimal PRECIO_BASE_MENSUAL = 500.00m;
        private const int EDAD_MINIMA = 14;
        private const decimal PORC_DESCUENTO_ESTUDIANTE = 0.15m; // 15%
        private const decimal PORC_AJUSTE_POR_TARJETA = 0.05m;  // 5%

        public frmInscripcion()
        {


            InitializeComponent();
            // Asociar los filtros después de inicializar los controles.
            txtNombre.KeyPress += SoloLetras_KeyPress;
            txtEdad.KeyPress += SoloDigitos_KeyPress;
            txtMeses.KeyPress += SoloDigitos_KeyPress;
        }

        private void EventoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";
            cboCuotas.SelectedIndex = 0;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            rdbEfectivo.Checked = true;
            rdbTarjeta.Checked = false;
            btnCalcular.Enabled = false;


        }



        private void addItems(ComboBox cbo, params string[] items)
        {
            cbo.Items.AddRange(items);

        }

        private void frminscripcion_Load(object sender, EventArgs e)
        {
            addItems(cboCuotas, "1", "3", "6");

            EventoInicial();

        }

        private void cboPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void gpbPago_Enter(object sender, EventArgs e)
        {

        }

        private void txtMeses_TextChanged(object sender, EventArgs e)
        {
           
            }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void cboCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EventoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declarar e inicializar las variables del cálculo (camelCase)
            string nombre = txtNombre.Text.Trim();
            int edad = 0;
            int meses = 1;
            decimal precioMensual = 0m;
            decimal subtotal = 0m;
            decimal porcentajeDescuento = 0m;
            decimal porcentajeAjustePorPago = 0m;
            decimal total = 0m;
            decimal valorCuota = 0m;

            // Parsear entradas de usuario de forma segura
            int.TryParse(txtEdad.Text, out edad);
            int.TryParse(txtMeses.Text, out meses);

            // -> Aquí irá la lógica de cálculo usando las constantes de clase
        }

        // Manejador KeyPress para permitir sólo dígitos y Backspace
        private void SoloDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // descartar la tecla
            }
        }

        // Permitir letras, espacios y Backspace en el nombre; descartar números.
        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Reusar el filtro de letras para el evento del diseñador
            SoloLetras_KeyPress(sender, e);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

