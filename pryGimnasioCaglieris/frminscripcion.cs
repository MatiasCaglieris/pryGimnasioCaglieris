using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// -------------- PARA PENSAR ESTE CODIGO DE NENAZO TIKTOK ----------------

namespace pryGimnasioCaglieris
{
    public partial class frminscripcion : Form
    {
        struct SOCIO
        {
            public string nombre;
            public int edad;
            public string categoria;
            public string plan;
            public string horario;
            public int meses;
            public string formadepago;
            public decimal total;
            public decimal valorcuota;

        }


        const decimal Precio_Musculacion = 15000m;
        const decimal Precio_Funcional = 18000m;
        const decimal Precio_Natacion = 22000m;

        const decimal Precio_Casillero = 3000m;
        const int Edad_Minima = 14;
        const int Meses_Minimos = 1;
        const int Meses_Maximos = 12;
        const decimal Descuento_Menor = 0.25m;
        const decimal Descuneto_Mayor65 = 0.30m;
        const decimal Descuento_Estudiante = 0.15m;
        const decimal Descuento_Efectivo = 0.10m;
        const decimal Recargo_3_Cuotas = 0.10m;
        const decimal Recargo_6_Cuotas = 0.20m;
        

        public frminscripcion()
        {
            InitializeComponent();
        }

        private void EventoInicial()
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtMeses.Text = "1";
            cboCuotas.SelectedIndex = -1;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            rdbEfectivo.Checked = true;
            rdbTarjeta.Checked = false;
            btnCalcular.Enabled = false;
            cboCuotas.Enabled = false;
            txtNombre.Focus();    //  <-- esta linea de codigo es medio nenazo IA PROFE YO SE LA EXPLICO TRANQUI


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

        private void chkEstudiante_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSoloDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }


        }

        private void Campos_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "" &&
                txtEdad.Text.Trim() != "" &&
                txtMeses.Text.Trim() != "")
            {
                btnCalcular.Enabled = true;
            }
            else
            {
                btnCalcular.Enabled = false;
            }

        }

        private void rdbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            { 
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }

        }

        // AHORA VIENE LA VERDADERA CREMA DE LAS CREMAS EL MARDITO BOTON DE CALCULAR HUESO CUANTO PELUCHE


        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string plan = cboPlan.Text;
            decimal precioMensual = 0;
            switch (plan)
            {
                case "Musculacion":
                    precioMensual = Precio_Musculacion;
                    break;

                case "Funcional":
                    precioMensual = Precio_Funcional;
                    break;

                case "Natacion":
                    precioMensual = Precio_Natacion;
                    break;

                default:
                    MessageBox.Show(
                        "el plan seleccionado no es valido",
                        "error broder",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
            }


            string horario = "";
            switch (cboTurno.SelectedIndex)
            {
                case 0:
                    horario = "7 a 12 hrs";
                    break;

                case 1:
                    horario = "14 a 18 hrs";
                    break;

                case 2:
                    horario = "18 a 23 hrs";
                    break;

                default:
                    MessageBox.Show(
                        "el turno no es valido Bolsa de as",
                        "error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
            }

            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);
            

            if (edad < Edad_Minima)
            {
                MessageBox.Show(
                    "La edad minima es de 14 años WACHIN",
                    "edad invalida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;

            }

            if (meses < Meses_Minimos || meses > Meses_Maximos)
            {
                MessageBox.Show(
                    "La cantidad de meses debe ser entre 1 y 12 y si claro que si master cuantos meses tene vo extraterrestre que se remonta a la estratosfera ",
                    "mes invalido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (nombre == "ADMIN")
            {
                MessageBox.Show(
                    "Advertencia: NO ME TRATE COMO UN PENDEJO SABE ",
                    "Error broder : OJITO CON LO QUE PONES ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            if (chkCasillero.Checked) precioMensual += Precio_Casillero;

            decimal subtotal = precioMensual * meses;

            decimal porcentajeDescuento;

            if (edad < 18)
            {
                porcentajeDescuento = 0.25m;
            }
            else
            {
                if (edad >= 65)
                {
                    porcentajeDescuento = 0.30m;
                }
                else
                {
                    if (chkEstudiante.Checked)
                        porcentajeDescuento = 0.15m;
                    else
                        porcentajeDescuento = 0m;
                }
            }

            decimal descuento = subtotal * porcentajeDescuento;

            decimal importecondescuento = subtotal - descuento;

            decimal porcentajeajuste = 0;
            
            int cuotas = 0;

            if (rdbEfectivo.Checked)
            {
                porcentajeajuste = -0.10m;
            }
            else
            {
                 cuotas = int.Parse(cboCuotas.Text);

                if (cuotas == 1)
                    porcentajeajuste = 0m;
                else if (cuotas == 3)
                    porcentajeajuste = 0.10m;
                else if (cuotas == 6)
                    porcentajeajuste = 0.20m;
            }

            decimal ajuste = importecondescuento * porcentajeajuste;

            decimal total = importecondescuento + ajuste;

            string categoria = edad < 18 ? "menor" : "mayor";

            string formadepago = rdbEfectivo.Checked
                ? "efectivo"
                : "tarjeta en " + cuotas + " cuotas";

            decimal valorcuota = rdbEfectivo.Checked
                ? total
                : total / cuotas;

            SOCIO socio = new SOCIO(); // <- acordate que esto crea una variable que tiene los datos del socio broly

            socio.nombre = nombre;
            socio.edad = edad;
            socio.categoria = categoria;
            socio.plan = plan;
            socio.horario = horario;
            socio.meses = meses;
            socio.formadepago = formadepago;
            socio.total = total;
            socio.valorcuota = valorcuota;

            string mensaje =
                "Nombre: " + socio.nombre +
                "\nEdad: " + socio.edad +
                "\nCategoria: " + socio.categoria +
                "\nPlan: " + socio.plan +
                "\nHorario: " + socio.horario +
                "\nMeses: " + socio.meses +
                "\nForma de Pago: " + socio.formadepago +
                "\nTotal: " + socio.total.ToString("C") +
                "\nValor de cuota: " + socio.valorcuota.ToString("C");

            MessageBox.Show(
                mensaje,
                "datos del socio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information );

            EventoInicial();

        }

        private void chkCasillero_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void gpbPlanyTurno_Enter(object sender, EventArgs e)
        {

        }
    }
}

