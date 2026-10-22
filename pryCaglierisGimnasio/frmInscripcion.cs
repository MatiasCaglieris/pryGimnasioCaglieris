using System;
using System.Windows.Forms;

namespace pryCaglierisGimnasio
{
    public partial class frmInscripcion : Form
    {
        private struct SOCIO
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

        private const decimal PRECIO_MUSCULACION = 15000m;
        private const decimal PRECIO_FUNCIONAL = 18000m;
        private const decimal PRECIO_NATACION = 22000m;
        private const decimal PRECIO_CASILLERO = 3000m;
        private const int EDAD_MINIMA = 14;
        private const int EDAD_MENOR = 18;
        private const int EDAD_MAYOR = 65;
        private const int MESES_MINIMOS = 1;
        private const int MESES_MAXIMOS = 12;
        private const decimal DESCUENTO_MENOR = 0.25m;
        private const decimal DESCUENTO_MAYOR = 0.30m;
        private const decimal DESCUENTO_ESTUDIANTE = 0.15m;
        private const decimal DESCUENTO_EFECTIVO = 0.10m;
        private const decimal RECARGO_TRES_CUOTAS = 0.10m;
        private const decimal RECARGO_SEIS_CUOTAS = 0.20m;

        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void EstadoInicial()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = MESES_MINIMOS.ToString();
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            btnCalcular.Enabled = false;
            txtNombre.Focus();
        }

        private void Campos_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.Enabled = !string.IsNullOrWhiteSpace(txtNombre.Text)
                && !string.IsNullOrWhiteSpace(txtEdad.Text)
                && !string.IsNullOrWhiteSpace(txtMeses.Text);
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
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            EstadoInicial();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int edad;
            int meses;
            if (!int.TryParse(txtEdad.Text, out edad) || !int.TryParse(txtMeses.Text, out meses))
            {
                MessageBox.Show("Ingresá una edad y una cantidad de meses válidas.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("La edad mínima para inscribirse es de 14 años.", "Edad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (meses < MESES_MINIMOS || meses > MESES_MAXIMOS)
            {
                MessageBox.Show("La cantidad de meses debe estar entre 1 y 12.", "Meses inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string plan = cboPlan.SelectedItem as string;
            decimal precioMensual;
            switch (plan)
            {
                case "Musculación":
                    precioMensual = PRECIO_MUSCULACION;
                    break;
                case "Funcional":
                    precioMensual = PRECIO_FUNCIONAL;
                    break;
                case "Natación":
                    precioMensual = PRECIO_NATACION;
                    break;
                default:
                    MessageBox.Show("El plan seleccionado no es válido.", "Plan inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            string horario;
            switch (cboTurno.SelectedIndex)
            {
                case 0:
                    horario = "7 a 12 h";
                    break;
                case 1:
                    horario = "14 a 18 h";
                    break;
                case 2:
                    horario = "18 a 23 h";
                    break;
                default:
                    MessageBox.Show("El turno seleccionado no es válido.", "Turno inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            if (chkCasillero.Checked) precioMensual += PRECIO_CASILLERO;
            decimal subtotal = precioMensual * meses;

            decimal porcentajeDescuento;
            if (edad < EDAD_MENOR)
            {
                porcentajeDescuento = DESCUENTO_MENOR;
            }
            else
            {
                if (edad >= EDAD_MAYOR)
                {
                    porcentajeDescuento = DESCUENTO_MAYOR;
                }
                else
                {
                    if (chkEstudiante.Checked)
                        porcentajeDescuento = DESCUENTO_ESTUDIANTE;
                    else
                        porcentajeDescuento = 0m;
                }
            }

            decimal importeConDescuento = subtotal - subtotal * porcentajeDescuento;
            decimal porcentajeAjuste;
            int cuotas;
            if (rbtEfectivo.Checked)
            {
                porcentajeAjuste = -DESCUENTO_EFECTIVO;
                cuotas = 1;
            }
            else
            {
                if (!int.TryParse(cboCuotas.Text, out cuotas))
                {
                    MessageBox.Show("Seleccioná una cantidad de cuotas válida.", "Cuotas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cuotas == 1)
                    porcentajeAjuste = 0m;
                else if (cuotas == 3)
                    porcentajeAjuste = RECARGO_TRES_CUOTAS;
                else if (cuotas == 6)
                    porcentajeAjuste = RECARGO_SEIS_CUOTAS;
                else
                {
                    MessageBox.Show("La cantidad de cuotas seleccionada no es válida.", "Cuotas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            decimal total = importeConDescuento + importeConDescuento * porcentajeAjuste;
            string categoria = edad < EDAD_MENOR ? "Menor" : "Mayor";
            string formaDePago = rbtEfectivo.Checked ? "Efectivo" : "Tarjeta en " + cuotas + " cuotas";
            decimal valorCuota = rbtEfectivo.Checked ? total : total / cuotas;

            SOCIO socio = new SOCIO();
            socio.nombre = txtNombre.Text.Trim();
            socio.edad = edad;
            socio.categoria = categoria;
            socio.plan = plan;
            socio.horario = horario;
            socio.meses = meses;
            socio.formadepago = formaDePago;
            socio.total = total;
            socio.valorcuota = valorCuota;

            string mensaje =
                "Nombre: " + socio.nombre +
                "\nEdad: " + socio.edad +
                "\nCategoría: " + socio.categoria +
                "\nPlan: " + socio.plan +
                "\nHorario: " + socio.horario +
                "\nMeses: " + socio.meses +
                "\nForma de pago: " + socio.formadepago +
                "\nTotal: " + socio.total.ToString("C") +
                "\nValor de cuota: " + socio.valorcuota.ToString("C");

            MessageBox.Show(mensaje, "Datos del socio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EstadoInicial();
        }
    }
}
